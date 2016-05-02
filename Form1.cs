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

        public struct subTitles
        {
            public string startTime; //Начало показа
            public string stopTime; //Конец показа
            public string text; //Текст титра
        }

        static void parser(string Dir, out subTitles[] arrTitles)
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
            arrTitles = new subTitles[count];
            fs.Seek(0, System.IO.SeekOrigin.Begin);
            for (int i = 0; i < count; i++)
            {
                openText.ReadLine();
                string[] time = openText.ReadLine().Split(new string[1] { " --> " }, StringSplitOptions.RemoveEmptyEntries);
                arrTitles[i].startTime = time[0];
                arrTitles[i].stopTime = time[1];
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
            subTitles[] arrTitles;
            parser(srtDir, out arrTitles);
            //for (int i = 0; i < fragmCols; i++)
            //{
            //    System.Diagnostics.Process.Start(@"ffmpeg\ffmpeg.exe", "ffmpeg -i -an -ss" + times[i] + "-an -r 1 -vframes 1 -y -f image2 -s 190x142" + i + "-snapshot.jpg");
            //}
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
