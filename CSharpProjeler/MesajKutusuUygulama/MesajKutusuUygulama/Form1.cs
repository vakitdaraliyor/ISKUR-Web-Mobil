using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesajKutusuUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MesajKutusu.Goster("Evet mi Hayır mı?", "Secim yap");
            if (dr == DialogResult.Yes)
            {
                button1.Text = "Evet";
            }
            else
            {
                button1.Text = "Hayır";
            }
        }
    }
}
