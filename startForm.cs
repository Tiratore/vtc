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
    public partial class startForm : Form
    {
        public startForm()
        {
            InitializeComponent();
        }

        string srtDir, movDir;

        private void selectSrtButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "SRT File (*.srt;)|*.srt;";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.Path.GetExtension(openFileDialog1.FileName) != ".srt")
                {
                    MessageBox.Show("Неверное расширение файла субтитров. Выберите файл формата SRT" , "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {                    
                    selectSrtButton.Text = openFileDialog1.FileName;
                    srtDir = openFileDialog1.FileName;
                }                
            }            
        }       

        private void openMovButton_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                openFileDialog2.Filter = "AVI File (*.avi;)|*.avi;";
                if (System.IO.Path.GetExtension(openFileDialog2.FileName) != ".avi")
                {
                    MessageBox.Show("Неверное расширение файла видео. Выберите файл формата AVI", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {                    
                    openMovButton.Text = openFileDialog2.FileName;
                    movDir = openFileDialog2.FileName;
                }
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(srtDir) && !String.IsNullOrEmpty(movDir))
            {
                Hide();
                MainForm mf = new MainForm(srtDir, movDir);
                mf.ShowDialog();
                Close();
            }
            else { MessageBox.Show("Не выбран один или оба файла. Выберите файлы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
