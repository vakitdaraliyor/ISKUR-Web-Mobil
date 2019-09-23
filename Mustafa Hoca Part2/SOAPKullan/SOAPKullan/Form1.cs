using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOAPKullan
{
    public partial class Form1 : Form
    {
        ServiceReference1.OrnekServiceSoapClient client = new ServiceReference1.OrnekServiceSoapClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string yazi = client.HelloWorld();
            button1.Text = yazi;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtSAYI1.Text);
            int sayi2 = Convert.ToInt32(txtSAYI2.Text);
            button2.Text = Convert.ToString(client.Topla(sayi1, sayi2));
        }

        
    }
}
