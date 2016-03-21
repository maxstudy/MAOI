using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAOI_Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ReadBmp = new OpenFileDialog();
            //ReadBmp.ShowDialog();
            if (ReadBmp.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(ReadBmp.FileName);
                //Graphics gr = Graphics.FromImage(pictureBox1.Image);
                //gr.DrawImage(pictureBox1.Image, 5);
                Bitmap Bitmap = new Bitmap(ReadBmp.FileName);
                Bitmap bit = new Bitmap(Bitmap, 100, 100);
                pictureBox1.Image = bit;
                
                //Bitmap = Bitmap.FromFile(ReadBmp.FileName);
                //pictureBox1.Width *= 5;
                //pictureBox1.Height *= 5;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
