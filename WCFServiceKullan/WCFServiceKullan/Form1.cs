using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCFServiceKullan
{
    public partial class Form1 : Form
    {
        ServiceReference1.ServiceBlogClient client = new ServiceReference1.ServiceBlogClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var liste = client.GetAllKATEGORI();
            dataGridView1.DataSource = liste;
        }
    }
}
