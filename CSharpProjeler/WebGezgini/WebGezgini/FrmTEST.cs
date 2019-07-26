using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebGezgini
{
    public partial class FrmTEST : Form
    {
        int sayi1 = 0; // KeyDown
        int sayi2 = 0; // KeyPress
        int sayi3 = 0; // KeyUp
        public FrmTEST()
        {
            InitializeComponent();
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // Sadece harf ya da sadece rakam girebiliriz 
            // e.SuppressKeyPress = true; gizler

            if (e.Control == true && e.KeyCode == Keys.Enter)
            {
                this.Text = "Koşul sağlandı";
            }

            textBox2.Text = e.KeyCode.ToString() + "\r\n";
            textBox2.Text = e.KeyData.ToString() + "\r\n";
            textBox2.Text = e.KeyValue.ToString() + "\r\n"; // ASCII

            sayi1++;
            Goster();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {// KeyChar var
            sayi2++;
            Goster();
        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            sayi3++;
            Goster();
        }

        void Goster()
        {
            label1.Text = sayi1.ToString();
            label2.Text = sayi2.ToString();
            label3.Text = sayi3.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            sayi1 = 0;
            sayi2 = 0;
            sayi3 = 0;
        }

    }
}
