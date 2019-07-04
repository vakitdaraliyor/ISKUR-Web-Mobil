using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YildirimBeyazit.Iskur.Windows;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // shift + Home veya shift + End
            // ctrl + sağ ok ya da sol ok
            int s1 = Convert.ToInt32(textBox1.Text);
            int s2 = Convert.ToInt32(textBox2.Text);

            int toplam = s1 + s2;

            button1.Text = toplam.ToString();

        }


        private void Button2_Click_1(object sender, EventArgs e)
        {
            // shift + Home veya shift + End
            // ctrl + sağ ok ya da sol ok
            int s1 = Convert.ToInt32(textBox1.Text);
            int s2 = Convert.ToInt32(textBox2.Text);

            HesapMakinesi h = new HesapMakinesi();

            int toplam = h.Topla(s1, s2);

            button2.Text = toplam.ToString();
        }
    }
}
