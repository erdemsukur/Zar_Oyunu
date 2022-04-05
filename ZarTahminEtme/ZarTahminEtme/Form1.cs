using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZarTahminEtme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void asdasd_Load(object sender, EventArgs e)
        {
            pictureBox1.Image=Image.FromFile("C:\\zar\\zar.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iki_kisilik iki = new iki_kisilik();
            iki.Show();
            this.Hide();
            

        }

        private void asdasd_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bilgisayar_zar bilg = new Bilgisayar_zar();
            bilg.Show();
            this.Hide();
        }
    }
}
