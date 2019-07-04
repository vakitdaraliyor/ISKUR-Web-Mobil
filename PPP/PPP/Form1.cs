using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPP
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
            this.Text = Class1.sayi4.ToString();
            Class3 c3 = new Class3();

            button1.Text = Class1.sayi4.ToString();

            Class1 c1 = new Class1();
            MessageBox.Show(Class1.sayi4.ToString());
        }
    }
}
