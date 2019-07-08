using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ogrenci
{
    public partial class Form1 : Form
    {
        DBClass db = new DBClass();
        int satir = -1;
        

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }

        void GridDoldur()
        {
            DataTable dt = db.TabloGetir("SELECT * FROM OGRENCI");
            dataGridView1.DataSource = dt;
        }

        private void DataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            satir = e.RowIndex;
            if(satir > -1)
            {
                txtOgrenciREFNO.Text = dataGridView1.Rows[satir].Cells["OGRENCI_REFNO"].Value.ToString();
                txtAdı.Text = dataGridView1.Rows[satir].Cells["ADI"].Value.ToString();
                txtSoyadı.Text = dataGridView1.Rows[satir].Cells["SOYADI"].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[satir].Cells["DOGUM_TARIHI"].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[satir].Cells["DOGUM_YERI"].Value.ToString();
                txtAnneAdı.Text = dataGridView1.Rows[satir].Cells["ANNE_ADI"].Value.ToString();
                txtBabaAdı.Text = dataGridView1.Rows[satir].Cells["BABA_ADI"].Value.ToString();
                txtAcıklama.Text = dataGridView1.Rows[satir].Cells["ACIKLAMA"].Value.ToString();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Yeni
            txtOgrenciREFNO.Text = "";
            txtAdı.Text = "";
            txtSoyadı.Text = "";
            dateTimePicker1.Text = "";
            comboBox1.Text = "";
            txtAnneAdı.Text = "";
            txtBabaAdı.Text = "";
            txtAcıklama.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Vazgeç
            if (satir > -1)
            {
                txtOgrenciREFNO.Text = dataGridView1.Rows[satir].Cells["OGRENCI_REFNO"].Value.ToString();
                txtAdı.Text = dataGridView1.Rows[satir].Cells["ADI"].Value.ToString();
                txtSoyadı.Text = dataGridView1.Rows[satir].Cells["SOYADI"].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[satir].Cells["DOGUM_TARIHI"].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[satir].Cells["DOGUM_YERI"].Value.ToString();
                txtAnneAdı.Text = dataGridView1.Rows[satir].Cells["ANNE_ADI"].Value.ToString();
                txtBabaAdı.Text = dataGridView1.Rows[satir].Cells["BABA_ADI"].Value.ToString();
                txtAcıklama.Text = dataGridView1.Rows[satir].Cells["ACIKLAMA"].Value.ToString();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // Kaydet
            string islem = "ekleme";
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if(this.Controls[i] is TextBox || this.Controls[i] is DateTimePicker || this.Controls[i] is ComboBox)
                {
                    if (this.Controls[i].Name != "txtOgrenciREFNO" && this.Controls[i].Text == "")
                    {
                        errorProvider1.SetError(Controls[i], "Boş bırakılamaz");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(Controls[i], "");
                    }
                }
            }

            string sql = "";
            if(txtOgrenciREFNO.Text == "")
            {
                sql = "INSERT INTO OGRENCI(ADI, SOYADI, DOGUM_TARIHI, DOGUM_YERI, ANNE_ADI, BABA_ADI, ACIKLAMA)" +
                    " VALUES(@p1, @p2, @p3, @p4, @p5, @p6, @p7)";                
            }
            else
            {

                sql = "UPDATE OGRENCI SET ADI = @p1, SOYADI = @p2, DOGUM_TARIHI = @p3, DOGUM_YERI = @p4, ANNE_ADI = @p5, BABA_ADI = @p6, ACIKLAMA = @p7" +
                    " WHERE OGRENCI_REFNO = @p0";
                islem = "güncelleme";
            }

            SqlParameter prm0 = new SqlParameter("@p0", txtOgrenciREFNO.Text);
            SqlParameter prm1 = new SqlParameter("@p1", txtAdı.Text);
            SqlParameter prm2 = new SqlParameter("@p2", txtSoyadı.Text);
            SqlParameter prm3 = new SqlParameter("@p3", dateTimePicker1.Text);
            SqlParameter prm4 = new SqlParameter("@p4", comboBox1.Text);
            SqlParameter prm5 = new SqlParameter("@p5", txtAnneAdı.Text);
            SqlParameter prm6 = new SqlParameter("@p6", txtBabaAdı.Text);
            SqlParameter prm7 = new SqlParameter("@p7", txtAcıklama.Text);

            db.SqlCalistir(sql, prm0, prm1, prm2, prm3, prm4, prm5, prm6, prm7);
            GridDoldur();
            if(islem == "ekleme")
            {
                MessageBox.Show("Başarıyla Eklendi!");
            }
            else
            {
                MessageBox.Show("Başarıyla Güncellendi!");
            }
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string sql = "";

            DialogResult dialogResult = MessageBox.Show("Silmek istediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                sql = "DELETE FROM OGRENCI WHERE OGRENCI_REFNO = @p0";
                SqlParameter prm0 = new SqlParameter("@p0", txtOgrenciREFNO.Text);

                db.SqlCalistir(sql, prm0);
                GridDoldur();

                MessageBox.Show("Başarıyla Silindi!");
            }
        }
    }
}
