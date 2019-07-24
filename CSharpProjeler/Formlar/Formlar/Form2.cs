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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Text = frm1.Text + DateTime.Now.ToString();
            // frm1.ShowDialog();
            frm1.Show(); // Bir cok kez aynı form açılabiliyor
            pencerelerToolStripMenuItem.DropDownItems.Clear();
            AcikPencereListesi(pencerelerToolStripMenuItem);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                listBox1.Items.Add(Application.OpenForms[i].Text);
            } 
        }

        public static void AcikPencereListesi(ToolStripMenuItem mi)
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                mi.DropDownItems.Add(Application.OpenForms[i].Text);
            }            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            AcikPencereListesi(pencerelerToolStripMenuItem);
        }
    }
}
