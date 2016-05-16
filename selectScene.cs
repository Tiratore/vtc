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
    public partial class selectScene : Form
    {
        public selectScene()
        {
            InitializeComponent();
        }

        string title, imgsDir;

        public selectScene(string inTitle, string inImgsDir)
        {
            title = inTitle;
            imgsDir = inImgsDir;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage
        }

        private void selectScene_Load(object sender, EventArgs e)
        {
            subtitlesText.Text = title;
            
        }
    }
}
