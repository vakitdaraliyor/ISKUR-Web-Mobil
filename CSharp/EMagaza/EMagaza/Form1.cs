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
using ADO.Net;

namespace EMagaza
{
    public partial class Form1 : Form
    {
        DBClass db = new DBClass();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = db.TableGetir("SELECT * FROM KATEGORI");
            Genel.ListeDoldur(comboBox1, dt, "KATEGORI_ADI", "KATEGORI_REFNO");
            //comboBox1.DataSource = dt; // veri kaynagi
            //comboBox1.DisplayMember = "KATEGORI_ADI"; // ekranda gorunecek olan
            //comboBox1.ValueMember = "KATEGORI_REFNO"; // secili bir kategorinin refno su
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kategorirefno = comboBox1.SelectedValue.ToString();
            string sql = "SELECT * FROM ALT_KATEGORI WHERE KATEGORI_REFNO = @p1";
            SqlParameter prm1 = new SqlParameter("@p1", Convert.ToInt32(kategorirefno));

            DataTable dt = db.TableGetir(sql, prm1);
            Genel.ListeDoldur(listBox1, dt, "ALT_KATEGORI_ADI", "ALT_KATEGORI_REFNO");
            //listBox1.DataSource = dt; // veri kaynagi
            //listBox1.DisplayMember = "ALT_KATEGORI_ADI"; // ekranda gorunecek olan
            //listBox1.ValueMember = "ALT_KATEGORI_REFNO"; // secili bir kategorinin refno su
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string alt_kategori_refno = listBox1.SelectedValue.ToString();
            string sql = "SELECT * FROM URUN WHERE ALT_KATEGORI_REFNO = @p1";

            SqlParameter prm1 = new SqlParameter("@p1", Convert.ToInt32(alt_kategori_refno));

            DataTable dt = db.TableGetir(sql, prm1);
            dataGridView1.DataSource = dt;
        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string sql = "SELECT * FROM URUN WHERE URUN_ADI LIKE '%'+@p1+'%'";
            SqlParameter prm1 = new SqlParameter("@p1", textBox1.Text);

            DataTable dt = db.TableGetir(sql, prm1);
            dataGridView1.DataSource = dt;
        }
    }
}
