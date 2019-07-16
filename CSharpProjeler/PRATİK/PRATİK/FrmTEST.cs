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

namespace PRATİK
{
    public partial class FrmTEST : Form
    {
        DBClass db = new DBClass();

        public FrmTEST()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM URUN";
            object sonuc = db.TekDegerGetir(sql);
            button1.Text = sonuc.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string sql = "SELECT COUNT(*) FROM URUN";
            object sonuc = db.TekDegerGetir(sql);
            button2.Text = sonuc.ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string sql = "SELECT MAX(KDVSIZ_ALIS_FIYATI) FROM URUN";
            object sonuc = db.TekDegerGetir(sql);
            button3.Text = sonuc.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SqlDataReader dr = db.VeriOkuyucu("SELECT * FROM KATEGORI");
            listBox1.Items.Clear();

            while(dr.Read() == true)
            {
                listBox1.Items.Add(dr["KATEGORI_REFNO"].ToString() + "-" + dr["KATEGORI_ADI"].ToString());
            }
            
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            SqlDataReader dr = db.VeriOkuyucu("SELECT * FROM KATEGORI");
            listBox1.Items.Clear();

            while (dr.Read() == true)
            {
                listBox1.Items.Add(dr["KATEGORI_REFNO"].ToString() + "-" + dr["KATEGORI_ADI"].ToString());
            }

        }
    }
}
