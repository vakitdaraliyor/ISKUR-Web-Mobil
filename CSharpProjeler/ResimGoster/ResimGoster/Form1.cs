using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ResimGoster
{
    public partial class Form1 : Form
    {
        string[] dosyalar;
        int sayac = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dosyalar = Directory.GetFiles(@"c:\resim", "*.png");
            trackBar1.Maximum = dosyalar.Length - 1;
            pictureBox1.ImageLocation = dosyalar[0];
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac < dosyalar.Length)
            {
                pictureBox1.ImageLocation = dosyalar[sayac];
                trackBar1.Value = sayac;
            }
            else
            {
                sayac = 0;
                timer1.Enabled = false; // bütün resimler gösterildiginde dur
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
                button1.Text = "Durdur";
            }
            else
            {
                timer1.Enabled = false;
                button1.Text = "Başlat";
            }
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            if (sayac < dosyalar.Length)
            {
                sayac = trackBar1.Value;
                pictureBox1.ImageLocation = dosyalar[sayac];
            }
             
        }
    }
}
