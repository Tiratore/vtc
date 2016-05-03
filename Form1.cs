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
        string srtDir, movDir;

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
            Form waitForm = new Form();
            waitForm.Show();
            SubTitles[] arrTitles;
            parser(srtDir, out arrTitles);
            cutter(arrTitles, movDir);
            waitForm.Close();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
