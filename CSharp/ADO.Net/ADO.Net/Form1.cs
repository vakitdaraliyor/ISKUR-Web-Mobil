using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO.Net
{
    public partial class Form1 : Form
    {
         
        SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS; initial catalog=İŞKUR; user id=sa; password=1234");
        int satir = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }

        private void DataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            satir = e.RowIndex;
            if(satir > -1)
            {
                txtKATEGORI_REFNO.Text = dataGridView1.Rows[satir].Cells["KATEGORI_REFNO"].Value.ToString();
                txtKATEGORI_ADI.Text = dataGridView1.Rows[satir].Cells["KATEGORI_ADI"].Value.ToString();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Yeni(Button)
            txtKATEGORI_REFNO.Text = "";
            txtKATEGORI_ADI.Text = "";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //Vazgeç
            if (satir > -1)
            {
                txtKATEGORI_REFNO.Text = dataGridView1.Rows[satir].Cells["KATEGORI_REFNO"].Value.ToString();
                txtKATEGORI_ADI.Text = dataGridView1.Rows[satir].Cells["KATEGORI_ADI"].Value.ToString();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Kaydet

            if(txtKATEGORI_ADI.Text.Trim() == "")
            {
                errorProvider1.SetError(txtKATEGORI_ADI, "Kategori Adı giriniz");
                return;
            }
            else
            {
                errorProvider1.SetError(txtKATEGORI_ADI, "");
            }

            SqlParameter prm1 = new SqlParameter("@p1", txtKATEGORI_ADI.Text);
            SqlParameter prm2 = new SqlParameter("@p2", txtKATEGORI_REFNO.Text);

            string sql = "";
            if(txtKATEGORI_REFNO.Text == "")
            {
                sql = "INSERT INTO KATEGORI(KATEGORI_ADI) VALUES(@p1)";
            }
            else
            {
                sql = "UPDATE KATEGORI SET KATEGORI_ADI = '@p1' WHERE KATEGORI_REFNO = @p2";
            }

            SqlCalistir(sql, prm1, prm2);            

            connection.Close();

            GridDoldur();

            MessageBox.Show("Başarıyla eklendi");

        }

        void GridDoldur()
        {
            // Komut oluşturup connection oluşturuyoruz.
            SqlCommand command = new SqlCommand("SELECT * FROM KATEGORI", connection);
            // Veri taşıma işlemlerini yapan bir adapter oluşturuyoruz.
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            adapter.Fill(dt); // sql cümlesini çalıştırıp dt tablosuna doldur
            dataGridView1.DataSource = dt;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // Silme
            string sql = "";

            DialogResult dialogResult = MessageBox.Show("Silmek istediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                
                if (txtKATEGORI_REFNO.Text != "")
                {
                    sql = "DELETE FROM KATEGORI WHERE KATEGORI_REFNO = @p2";
                    SqlParameter prm2 = new SqlParameter("@p2", txtKATEGORI_REFNO.Text);

                    SqlCalistir(sql, prm2);
                    GridDoldur();

                    MessageBox.Show("Başarıyla silindi");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }     

        }

        private void SqlCalistir(string sql, params SqlParameter[] prms)
        {

            SqlCommand cmd = new SqlCommand(sql, connection);

            if(prms != null) cmd.Parameters.AddRange(prms);
       
            if (connection.State == ConnectionState.Closed) connection.Open();
            
            cmd.ExecuteNonQuery(); // INSERT UPDATE DELETE komutlarını çalıştırır                

            connection.Close();

            GridDoldur();
        }

    }
}
