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

namespace ADO.Net
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS; initial catalog=İŞKUR; user id=sa; password=1234");
        int satir = -1;

        private void Form2_Load(object sender, EventArgs e)
        {
            
            string sql = "SELECT * FROM GOREVTABLOSU";
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void DataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            satir = e.RowIndex;
            if (satir > -1)
            {
                txtGOREV_REFNO.Text = dataGridView1.Rows[satir].Cells["GOREV_REFNO"].Value.ToString();
                txtGOREV_ADI.Text = dataGridView1.Rows[satir].Cells["GOREV_ADI"].Value.ToString();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtGOREV_ADI.Text = "";
            txtGOREV_REFNO.Text = "";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (satir > -1)
            {
                txtGOREV_REFNO.Text = dataGridView1.Rows[satir].Cells["GOREV_REFNO"].Value.ToString();
                txtGOREV_ADI.Text = dataGridView1.Rows[satir].Cells["GOREV_ADI"].Value.ToString();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if(txtGOREV_ADI.Text.Trim() == "")
            {
                errorProvider1.SetError(txtGOREV_ADI, "Görev adı giriniz");
                return;
            }
            else
            {
                errorProvider1.SetError(txtGOREV_ADI, "");
            }

            SqlParameter prm1 = new SqlParameter("@p1", txtGOREV_ADI.Text);
            SqlParameter prm2 = new SqlParameter("@p2", txtGOREV_REFNO.Text);

            string sql = "";
            if(txtGOREV_REFNO.Text == "")
            {
                sql = "INSERT INTO GOREVTABLOSU(GOREV_ADI) VALUES(@p1)";
            }
            else
            {
                sql = "UPDATE GOREVTABLOSU SET GOREV_ADI = '@p1' WHERE GOREV_REFNO = @p2";
            }

            SqlCommand cmd = new SqlCommand(sql, connection);

            cmd.Parameters.Add(prm1);
            cmd.Parameters.Add(prm2);

            if (connection.State == ConnectionState.Closed) connection.Open();
            cmd.ExecuteNonQuery();

            //dataGridView1.DataSource = dt;

        }
    }
}