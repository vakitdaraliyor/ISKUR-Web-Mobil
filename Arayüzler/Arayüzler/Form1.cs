using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arayüzler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Kisi k = new Kisi();
            k.Calis(1);
            textBox1.Text = Kisi.birikim.ToString();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Kisi k = new Kisi();
            k.HarcamaYap(1);
            textBox1.Text = Kisi.birikim.ToString();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int tutar = Convert.ToInt32(textBox2.Text);

            IOdemeSistemi os;

            if(radioButton1.Checked == true)
            {
                os = new KrediKarti();
                button3.Text = os.OdemeYap(tutar).ToString();
            }

            if (radioButton2.Checked == true)
            {
                os = new Havale();
                button3.Text = os.OdemeYap(tutar).ToString();
            }

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {

                if(this.Controls[i] is TextBox)
                {
                    this.Controls[i].Text = "";
                }
               
            }
        }
    }
}
