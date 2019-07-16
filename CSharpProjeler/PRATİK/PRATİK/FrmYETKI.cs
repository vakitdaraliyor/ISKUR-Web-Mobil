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
    public partial class FrmYETKI : Form
    {
        DBClass db = new DBClass();
        DataTable dt = new DataTable();
        public FrmYETKI()
        {
            InitializeComponent();
        }

        private void FrmYETKI_Load(object sender, EventArgs e)
        {
            dt = db.TableGetir("SELECT * FROM MODUL");
            Genel.ListeDoldur(listBox1, dt, "MODUL_ADI", "MODUL_REFNO");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Kaydet
            int modul_refno = Convert.ToInt32(listBox1.SelectedValue);
            string sql = "DELETE FROM YETKI WHERE KULLANICI_REFNO=@p1 AND MODUL_REFNO=@p2";
            SqlParameter prm1 = new SqlParameter("@p1", label1.Text);
            SqlParameter prm2 = new SqlParameter("@p2", modul_refno);
            db.SqlCalistir(sql, prm1, prm2);

            string sqlYetkiEkle = "INSERT INTO YETKI(KULLANICI_REFNO, MODUL_REFNO,EKLE, GUNCELLE, SIL, OKU)";
            sqlYetkiEkle += "VALUES(@p11, @p22, @p33, @p44, @p55, @p66)";

            SqlParameter prm11 = new SqlParameter("@p11", label1.Text);
            SqlParameter prm22 = new SqlParameter("@p22", modul_refno);
            SqlParameter prm33 = new SqlParameter("@p33", checkedListBox1.GetItemChecked(0));
            SqlParameter prm44 = new SqlParameter("@p44", checkedListBox1.GetItemChecked(1));
            SqlParameter prm55 = new SqlParameter("@p55", checkedListBox1.GetItemChecked(2));
            SqlParameter prm66 = new SqlParameter("@p66", checkedListBox1.GetItemChecked(3));

            db.SqlCalistir(sqlYetkiEkle, prm11, prm22, prm33, prm44, prm55, prm66);

            MessageBox.Show("Yetki Verildi!");
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int modul_refno = Convert.ToInt32(listBox1.SelectedValue);
            string sql = "SELECT * FROM YETKI WHERE KULLANICI_REFNO=@p1 AND MODUL_REFNO=@p2";
            SqlParameter prm1 = new SqlParameter("@p1", label1.Text);
            SqlParameter prm2 = new SqlParameter("@p2", modul_refno);
            DataTable dt = db.TableGetir(sql, false, prm1, prm2);

            checkedListBox1.SetItemChecked(0, false);
            checkedListBox1.SetItemChecked(1, false);
            checkedListBox1.SetItemChecked(2, false);
            checkedListBox1.SetItemChecked(3, false);

            if(dt.Rows.Count > 0)
            {
                checkedListBox1.SetItemChecked(0, Convert.ToBoolean(dt.Rows[0]["EKLE"]));
                checkedListBox1.SetItemChecked(1, Convert.ToBoolean(dt.Rows[0]["GUNCELLE"]));
                checkedListBox1.SetItemChecked(2, Convert.ToBoolean(dt.Rows[0]["SIL"]));
                checkedListBox1.SetItemChecked(3, Convert.ToBoolean(dt.Rows[0]["OKU"]));
            }
        }
    }
}
