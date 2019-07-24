using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanalKlavye
{
    public partial class Form1 : Form
    {
        // deger tipi degisken ve referans tipi degisken arasındaki farktan yola cıkarak yapıldı

        Klavye k = new Klavye();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int sayi = 10;
            int kopya = sayi;
            sayi = 5;
            button1.Text = kopya.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Daire d = new Daire();
            d.yaricap = 10;

            Daire dCopy = d;
            d.yaricap = 45;

            button2.Text = dCopy.yaricap.ToString();
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            k.yazi = t;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            k.Yaz(b.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            k.yazi = textBox1;
        }
    }
}
