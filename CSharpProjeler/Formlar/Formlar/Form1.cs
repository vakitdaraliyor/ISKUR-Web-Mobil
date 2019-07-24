using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 frm2 = Application.OpenForms[0] as Form2;
            frm2.pencerelerToolStripMenuItem.DropDownItems.Clear(); // modifier public
            Form2.AcikPencereListesi(frm2.pencerelerToolStripMenuItem); // static method kullanıyoruz
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Kapatılsın mı?", "DIKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                e.Cancel = false; // Kapatma işlemi gerçekleşsin
            }
            else
            {
                e.Cancel = true; // Kapatma işlemi gerçekleşmesin
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
