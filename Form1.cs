using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTC
{
    public partial class MainForm : Form
    {
        bool isDrag = false;
        Rectangle theRectangle = new Rectangle(new Point(0, 0), new Size(0, 0));
        Point startPoint;

        string srtDir, movDir;

        List<Frame> frames = new List<Frame>();
        Frame currentFrame = null;

        static void parser(string Dir, out SubTitles[] arrTitles)
        {
            System.IO.FileStream fs = new System.IO.FileStream(Dir, System.IO.FileMode.Open);
            System.IO.StreamReader openText = new System.IO.StreamReader(fs);
            int count = 0;
            while (!openText.EndOfStream)
            {
                //определение кол-ва записей в файле субттитров
                try {
                    count = int.Parse(openText.ReadLine());
                }
                catch (Exception)
                {
                    continue;
                }
            }
            arrTitles = new SubTitles[count];
            fs.Seek(0, System.IO.SeekOrigin.Begin);
            for (int i = 0; i < count; i++)
            {
                openText.ReadLine();
                string[] time = openText.ReadLine().Split(new string[1] { " --> " }, StringSplitOptions.RemoveEmptyEntries);
                string[] startParams = time[0].Split(new char[2] {':', ','}, StringSplitOptions.RemoveEmptyEntries);
                string[] stopParams = time[1].Split(new char[2] { ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
                TimeSpan startTime = new TimeSpan(0, int.Parse(startParams[0]), int.Parse(startParams[1]), int.Parse(startParams[2]), int.Parse(startParams[3]));
                TimeSpan stopTime = new TimeSpan(0, int.Parse(stopParams[0]), int.Parse(stopParams[1]), int.Parse(stopParams[2]), int.Parse(stopParams[3]));
                arrTitles[i].startTime = startTime;
                arrTitles[i].stopTime = stopTime;
                arrTitles[i].text = openText.ReadLine();
                do
                {
                    string tmp = openText.ReadLine();
                    if (tmp != String.Empty)
                    {
                        arrTitles[i].text += " " + tmp;
                    }
                    else break;
                } while (true);                
            }
        }

        static void cutter(SubTitles[] arrTitles, string movDir)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.FileName = @"E:\Файлы\ffmpeg\ffmpeg.exe";

            for (int i = 0; i < arrTitles.Length; i++)
            {
                System.IO.Directory.CreateDirectory(@"c:\VideoToComics\" + i);
                TimeSpan duration = arrTitles[i].stopTime - arrTitles[i].startTime;
                TimeSpan tmp = TimeSpan.FromTicks(arrTitles[i].startTime.Ticks);
                for (int t = 0; t < duration.TotalSeconds * 2; t++)
                {
                    string time = tmp.ToString(@"hh\:mm\:ss\.fff");

                    proc.StartInfo.Arguments = @" -ss " + time + " -i " + movDir + @" -f image2 -vframes 1 c:\VideoToComics\" + i + @"\" + t + @".jpg";
                    proc.Start();
                    tmp = tmp.Add(TimeSpan.FromMilliseconds(500));                    
                }                
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(string inSrtDir, string inMovDir)
        {
            InitializeComponent();
            srtDir = inSrtDir;
            movDir = inMovDir;
        }

        private void открытьВидеоToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutOnMainForm1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Form waitForm = new Form();
            //waitForm.Show();
            //SubTitles[] arrTitles;
            //parser(srtDir, out arrTitles);
            //cutter(arrTitles, movDir);
            //waitForm.Close();
        }
        
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Frame f = new Frame(0, e.X, e.Y);
                frames.Add(f);

                isDrag = true;
                Control control = (Control)sender;

                //Сохраняем стартовый поинт
                startPoint = control.PointToScreen(new Point(e.X, e.Y));
            } else if (e.Button == MouseButtons.Right)
            {
                int maxId = 0, maxPriority = 0;
                
                bool isMax = false; currentFrame = null;

                for (int i = 0; i < frames.Count; i++)
                {
                    maxId = 0; maxPriority = 0; isMax = false;
                    if (frames[i].isPointInRectangle(e.X, e.Y))
                    {
                        if (maxId <= i)
                        {
                            maxId = i;
                            isMax = true;
                        }
                        if (maxPriority <= frames[i].priority)
                        {
                            maxPriority = frames[i].priority;
                        }
                        else
                        {
                            isMax = false;
                        }

                        if (isMax)
                        {
                            currentFrame = frames[i];
                        }
                    }
                }
                //MessageBox.Show(currentFrame.xStart.ToString() + " " + currentFrame.yStart.ToString());
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!isDrag) return;
                // Скрытие пердидущего ректангла вызовом DrawReversibleFrame с определенными параметрами
                ControlPaint.DrawReversibleFrame(theRectangle, this.BackColor, FrameStyle.Dashed);

                // Сохраняем конечный поинт и и размерыы нового прямоугольника
                Point endPoint = ((Control)sender).PointToScreen(new Point(e.X, e.Y));

                int width = endPoint.X - startPoint.X;
                int height = endPoint.Y - startPoint.Y;
                theRectangle = new Rectangle(startPoint.X, startPoint.Y, width, height);

                // Рисуем прямоугольник
                ControlPaint.DrawReversibleFrame(theRectangle,
                this.BackColor, FrameStyle.Dashed);
            } //else if (e.Button == MouseButtons.Right)
            //{

            //}


        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int maxId = 0, maxPriority = 0;

                bool isMax = false; currentFrame = null;

                for (int i = 0; i < frames.Count; i++)
                {
                    maxId = 0; maxPriority = 0; isMax = false;
                    if (frames[i].isPointInRectangle(e.X, e.Y))
                    {
                        if (maxId <= i)
                        {
                            maxId = i;
                            isMax = true;
                        }
                        if (maxPriority <= frames[i].priority)
                        {
                            maxPriority = frames[i].priority;
                        }
                        else
                        {
                            isMax = false;
                        }

                        if (isMax)
                        {
                            currentFrame = frames[i];
                        }
                    }
                }
                MessageBox.Show(currentFrame.xStart.ToString() + " " + currentFrame.yStart.ToString());
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Если маусап - выделение окончено.
                isDrag = false;

                // Draw the rectangle to be evaluated. Set a dashed frame style using the FrameStyle enumeration.
                ControlPaint.DrawReversibleFrame(theRectangle, this.BackColor, FrameStyle.Dashed);

                // Find out which controls intersect the rectangle and change their color.
                // The method uses the RectangleToScreen method to convert the Control's client coordinates to screen coordinates.
                Rectangle controlRectangle;
                for (int i = 0; i < Controls.Count; i++)
                {
                    controlRectangle = Controls[i].RectangleToScreen(Controls[i].ClientRectangle);
                    if (controlRectangle.IntersectsWith(theRectangle))
                    {
                        Controls[i].BackColor = Color.BurlyWood;
                    }
                }

                // Reset the rectangle.
                theRectangle = new Rectangle(0, 0, 0, 0);

                frames[frames.Count - 1].xStop = e.X;
                frames[frames.Count - 1].yStop = e.Y;
                Graphics g = pictureBox1.CreateGraphics();

                g.DrawRectangle(Pens.Red, frames[frames.Count - 1].xStart - 1, frames[frames.Count - 1].yStart - 1, frames[frames.Count - 1].xStop - frames[frames.Count - 1].xStart + 1, frames[frames.Count - 1].yStop - frames[frames.Count - 1].yStart + 1);

            }
        }
    }
}
