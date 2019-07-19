using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASS_ILE_VT.Model;

namespace CLASS_ILE_VT
{
    public partial class Form1 : Form
    {
        MODUL m = new MODUL();
        DBTABLES dbtables = new DBTABLES();
        int satir = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Yeni
            txtMODUL_REFNO.Text = "";
            txtMODUL_ADI.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbtables.MODULS = Model.MODUL.Load();
            dataGridView1.DataSource = dbtables.MODULS;
        }

        private void DataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            satir = e.RowIndex;
            if(satir > -1)
            {
                txtMODUL_REFNO.Text = dataGridView1.Rows[satir].Cells["MODUL_REFNO"].Value.ToString();
                txtMODUL_ADI.Text = dataGridView1.Rows[satir].Cells["MODUL_ADI"].Value.ToString();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // Vazgeç
            if (satir > -1)
            {
                txtMODUL_REFNO.Text = dataGridView1.Rows[satir].Cells["MODUL_REFNO"].Value.ToString();
                txtMODUL_ADI.Text = dataGridView1.Rows[satir].Cells["MODUL_ADI"].Value.ToString();
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Kaydet
            MODUL m = new MODUL();

            if (txtMODUL_REFNO.Text != "")
            {
                m.MODUL_REFNO = Convert.ToInt32(txtMODUL_REFNO.Text);
                m.MODUL_ADI = txtMODUL_ADI.Text;
                m.Update();
            }
            else
            {
                m.MODUL_ADI = txtMODUL_ADI.Text;
                m.Insert();
            }

            dbtables.MODULS = MODUL.Load();
            dataGridView1.DataSource = dbtables.MODULS;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // Sil

            DialogResult dr = MessageBox.Show("Silmek istediğinize emin misiniz?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) return;

            if (txtMODUL_REFNO.Text != "")
            {
                MODUL m = new MODUL();
                m.MODUL_REFNO = Convert.ToInt32(txtMODUL_REFNO.Text);
                m.Delete();
                dbtables.MODULS = MODUL.Load();
                dataGridView1.DataSource = dbtables.MODULS;
            }
        }
    }
}
