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

    public partial class Bilgisayar_zar : Form
    {
        public Bilgisayar_zar()
        {
            InitializeComponent();
        }
        int e = 0;
        Random rd = new Random();
        int f = 0;
        int g = 0;
        int birtp = 0;
        int ikitp = 0;
        int tur = 0;
        int a = 0;
        
        private void Bilgisayar_zar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Bilgisayar_zar_Load(object sender, EventArgs e)
        {
            
            //
            button2.Enabled = false;
            button3.Enabled = false;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;

            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox1.Image = Image.FromFile("C:\\zar\\zar.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = Image.FromFile("C:\\zar\\zar.gif");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void birzar()
        {
           e = rd.Next(1, 7);
           label5.Text = e.ToString();
           birtp += e;
           textBox4.Text = birtp.ToString();
          
           if (e == 1)
           {
               label5.Text = e.ToString();
               pictureBox1.Image = Image.FromFile("C:\\zar\\1.jpg");
           }

           if (e == 2)
           {
               label5.Text = e.ToString();
               pictureBox1.Image = Image.FromFile("C:\\zar\\2.jpg");
           }

           if (e == 3)
           {
               label5.Text = e.ToString();
               pictureBox1.Image = Image.FromFile("C:\\zar\\3.jpg");
           }

           if (e == 4)
           {
               label5.Text = e.ToString();
               pictureBox1.Image = Image.FromFile("C:\\zar\\4.jpg");
           }

           if (e == 5)
           {
               label5.Text = e.ToString();
               pictureBox1.Image = Image.FromFile("C:\\zar\\5.jpg");
           }

           if (e == 6)
           {
               label5.Text = e.ToString();
               pictureBox1.Image = Image.FromFile("C:\\zar\\6.jpg");
           }
        }
       
        public void ikizarresim()
        {
            if (f==1)
            {
                pictureBox2.Image=Image.FromFile("C:\\zar\\1.jpg");
            }
            if (f == 2)
            {
                pictureBox2.Image = Image.FromFile("C:\\zar\\2.jpg");
            }
            if (f == 3)
            {
                pictureBox2.Image = Image.FromFile("C:\\zar\\3.jpg");
            }
            if (f == 4)
            {
                pictureBox2.Image = Image.FromFile("C:\\zar\\4.jpg");
            }
            if (f == 5)
            {
                pictureBox2.Image = Image.FromFile("C:\\zar\\5.jpg");
            }
            if (f == 6)
            {
                pictureBox2.Image = Image.FromFile("C:\\zar\\6.jpg");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            birzar();
            timer1.Enabled = true;
            timer1.Start();
            button2.Enabled = false;
            g=0;
            //saniyezar();
            a = rd.Next(2, 6);
        }
      
        private void timer1_Tick(object sender, EventArgs e)
        {
          //  Random rdsn = new Random();
            
            g++;
           
                if (g == 1)
                {
                    label6.Text = "...";
                    pictureBox2.Image = Image.FromFile("C:\\zar\\zar.gif");
                }
                if (g == a)
                {
                    f = rd.Next(1, 7);
                    label6.Text = f.ToString();
                    ikitp += f;
                    textBox5.Text = ikitp.ToString();
                    ikizarresim();
                    tur++;
                    label8.Text = tur.ToString();
                    button2.Enabled = true;
                }
                if (g == a+1)
                {
                    if (tur==Convert.ToInt16(textBox6.Text))
                    {
                        if (birtp > ikitp)
                        {
                            MessageBox.Show("1.Oyuncu kazandı");
                            button2.Enabled = false;
                            button3.Enabled = true;
                            timer1.Enabled = false;
                        }
                        else if (ikitp > birtp)
                        {
                            MessageBox.Show("2.Oyuncu kazandı");
                            button2.Enabled = false;
                            timer1.Enabled = false;
                            button3.Enabled = true;
                        }
                        else
                            MessageBox.Show("Beraberlik");
                            button2.Enabled = false;
                            button3.Enabled = true;
                            timer1.Enabled = false;
                    }
                    else
                    {
                        timer1.Enabled = true;
                    }
                  
                }

            }

        private void button1_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button2.Enabled = true;
            pictureBox1.Enabled = true;
            textBox6.ReadOnly = true;
            button1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox6.ReadOnly = false;
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
            
        

        
    

