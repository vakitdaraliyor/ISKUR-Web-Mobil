using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoapHeaderWSKullan
{
    public partial class Form2 : Form
    {
        ServiceReference2.WSKATEGORISoapClient client = new ServiceReference2.WSKATEGORISoapClient();
        ServiceReference2.GirisDenetle kullanici = new ServiceReference2.GirisDenetle()
        {
            prm1 = "mustafa",
            prm2 = "123"
        };

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = client.GetAllKATEGORI(kullanici, "");
        }
    }
}
