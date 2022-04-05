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
    public partial class iki_kisilik : Form
    {
        public iki_kisilik()
        {
            InitializeComponent();
        }
        int a, b = 0;
        Random rd = new Random();
        int ikitp, birtp = 0;
        int tur = 0;

        private void iki_kisilik_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public void zaratma1()
        {
            a = rd.Next(1, 7);
            if (a == 1)
            {
                label5.Text = a.ToString();
                pictureBox1.Image = Image.FromFile("C:\\zar\\1.jpg");
            }

            if (a == 2)
            {
                label5.Text = a.ToString();
                pictureBox1.Image = Image.FromFile("C:\\zar\\2.jpg");
            }

            if (a == 3)
            {
                label5.Text = a.ToString();
                pictureBox1.Image = Image.FromFile("C:\\zar\\3.jpg");
            }

            if (a == 4)
            {
                label5.Text = a.ToString();
                pictureBox1.Image = Image.FromFile("C:\\zar\\4.jpg");
            }

            if (a == 5)
            {
                label5.Text = a.ToString();
                pictureBox1.Image = Image.FromFile("C:\\zar\\5.jpg");
            }
            
            if (a == 6)
            {
              label5.Text = a.ToString();
              pictureBox1.Image = Image.FromFile("C:\\zar\\6.jpg");
            }
        }
        public void zaratma2()
        {
            b = rd.Next(1, 7);
            label6.Text = b.ToString();
            if (b == 1)
            {
                label6.Text = b.ToString();
                pictureBox2.Image = Image.FromFile("C:\\zar\\1.jpg");
            }

            if (b == 2)
            {
                label6.Text = b.ToString();
                pictureBox2.Image = Image.FromFile("C:\\zar\\2.jpg");
            }

            if (b == 3)
            {
                label6.Text = b.ToString();
                pictureBox2.Image = Image.FromFile("C:\\zar\\3.jpg");
            }

            if (b == 4)
            {
                label6.Text = b.ToString();
                pictureBox2.Image = Image.FromFile("C:\\zar\\4.jpg");
            }

            if (b == 5)
            {
                label6.Text = b.ToString();
                pictureBox2.Image = Image.FromFile("C:\\zar\\5.jpg");
            }

            if (b == 6)
            {
                label6.Text = b.ToString();
                pictureBox2.Image = Image.FromFile("C:\\zar\\6.jpg");
            }
            
        }

        private void iki_kisilik_Load(object sender, EventArgs e)
        {
            
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            pictureBox1.Image = Image.FromFile("C:\\zar\\zar.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = Image.FromFile("C:\\zar\\zar.gif");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox6.Text!="")
            {
            textBox6.Enabled = false;
            button1.Enabled = false;
          

            pictureBox1.Enabled = true;
            pictureBox2.Enabled = false;
            button2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Boş geçmeyin");
            }
            
        }
       
       
        private void button2_Click(object sender, EventArgs e)
        {
            zaratma1();
            button4.Enabled = true;
            button2.Enabled = false;
            birtp += Convert.ToInt16(a);
            textBox4.Text = birtp.ToString();
            pictureBox2.Enabled = true;

        }
      

        private void button4_Click(object sender, EventArgs e)
        {
            zaratma2();
            button2.Enabled = true;
            button4.Enabled = false;
            ikitp += Convert.ToInt16(label6.Text);
            textBox5.Text = ikitp.ToString();
            tur += 1;
            label8.Text = tur.ToString();
            if (tur==Convert.ToInt16(textBox6.Text))
            {
                if (birtp>ikitp)
                {
                    MessageBox.Show("1.Oyuncu kazandı");
                    button2.Enabled = false;
                    button3.Enabled = true;
                }
                if (ikitp>birtp)
                {
                    MessageBox.Show("2.Oyuncu kazandı");
                    button2.Enabled = false;
                    button3.Enabled = true;
                }
                else if(ikitp==birtp)
                {
                    MessageBox.Show("Beraberlik");
                    button2.Enabled = false;
                    button3.Enabled = true;
                }
            }
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            textBox6.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Enabled = true;
            button1.Enabled = true;
            textBox4.Text = "0";
            textBox5.Text = "0";
            label8.Text = "-";
            label6.Text = "Değer";
            label5.Text = "Değer";
            tur = 0;
            a = 0;
            b = 0;
            birtp = 0;
            ikitp = 0;
            pictureBox2.Image = Image.FromFile("C:\\zar\\zar.gif");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Enabled = false;

            pictureBox1.Image = Image.FromFile("C:\\zar\\zar.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Enabled = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            int basilantus = Convert.ToInt32(e.KeyChar);

            if (!(basilantus >= 48 && basilantus <= 57 || basilantus == 8))
            {

                e.Handled = true;
            }
        }
        
    }
}
