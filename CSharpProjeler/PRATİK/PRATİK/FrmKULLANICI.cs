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
    public partial class FrmKULLANICI : Form
    {

        DBClass db = new DBClass();
        DataTable dt = new DataTable();
        string sql = "SELECT * FROM KULLANICI";
        int satir = -1;
        public FrmKULLANICI()
        {
            InitializeComponent();
        }

        private void FrmKULLANICI_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }

        void GridDoldur()
        {
            dt = db.TableGetir(sql,true);
            dataGridView1.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                KayitVar();
            }
            else
            {
                KayitYok();
            }
        }

        private void DataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            satir = e.RowIndex;
            KayitGoster(satir);
            btnSIL.Enabled = true;
            btnARAMA.Enabled = true;
        }

        void KayitGoster(int satir)
        {
            if (satir > -1)
            {
                txtKULLANICI_REFNO.Text = dataGridView1.Rows[satir].Cells["KULLANICI_REFNO"].Value.ToString();
                txtKULLANICI_ADI.Text = dataGridView1.Rows[satir].Cells["KULLANICI_ADI"].Value.ToString();
                txtSIFRESI.Text = dataGridView1.Rows[satir].Cells["SIFRESI"].Value.ToString();
                comboDURUMU.SelectedItem = dataGridView1.Rows[satir].Cells["DURUMU"].Value.ToString();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Yeni
            Genel.EkranıTemizle(this);
            YeniKayit();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //Vazgeç
            KayitGoster(satir);
            if (dt.Rows.Count > 0)
            {
                KayitVar();
            }
            else
            {
                KayitYok();
            }

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            // Ilk kullanıcı
            satir = 0;
            KayitGoster(satir);
            btnILK.Enabled = false;
            btnONCEKI.Enabled = false;
            btnSON.Enabled = true;
            btnSONRAKI.Enabled = true;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            // Bir onceki kullanici
            if (satir > 0)
            {
                satir--;
                KayitGoster(satir);
            }
            else
            {
                btnILK.Enabled = false;
                btnONCEKI.Enabled = false;
                btnSON.Enabled = true;
                btnSONRAKI.Enabled = true;
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            // Bir sonraki kullanici
            if (satir < dt.Rows.Count - 1)
            {
                satir++;
                KayitGoster(satir);
            }
            else
            {
                btnSON.Enabled = false;
                btnSONRAKI.Enabled = false;
                btnILK.Enabled = true;
                btnONCEKI.Enabled = true;
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            // Son kullanıcı
            satir = dt.Rows.Count - 1;
            KayitGoster(satir);
            btnSON.Enabled = false;
            btnSONRAKI.Enabled = false;
            btnILK.Enabled = true;
            btnONCEKI.Enabled = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string mesaj = "";
            if(txtKULLANICI_ADI.Text == "")
            {
                mesaj = "Kullanıcı adı boş bırakılamaz!\r\n";
            }
            if(txtSIFRESI.Text == "")
            {
                mesaj += "Şifre boş bırakılamaz!\r\n";
            }
            if(comboDURUMU.SelectedIndex == -1)
            {
                mesaj += "Durumu boş bırakılamaz";
            }
            if (mesaj!="")
            {
                FrmUYARI uyarı = new FrmUYARI();
                uyarı.textBox1.Text = mesaj;
                uyarı.ShowDialog();
                return;
            }

            // Yeni kullanıcı ekleme / Güncelleme
            SqlParameter prm1 = new SqlParameter("@p1", txtKULLANICI_ADI.Text);
            SqlParameter prm2 = new SqlParameter("@p2", txtKULLANICI_REFNO.Text);
            SqlParameter prm3 = new SqlParameter("@p3", txtSIFRESI.Text);
            SqlParameter prm4 = new SqlParameter("@p4", comboDURUMU.SelectedItem.ToString());

            string sql2 = "";
            if (txtKULLANICI_REFNO.Text != "")
            {
                sql2 = "UPDATE KULLANICI SET KULLANICI_ADI = @p1, SIFRESI = @p3, DURUMU = @p4 WHERE KULLANICI_REFNO = @p2";
            }
            else
            {
                sql2 = "INSERT INTO KULLANICI(KULLANICI_ADI, SIFRESI, DURUMU) VALUES(@p1, @p3, @p4)";
            }

            db.SqlCalistir(sql2, prm1, prm2, prm3, prm4);
            // verilen gride listelenecek

            GridDoldur();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // Sil
            DialogResult dr = MessageBox.Show("Silmek istediğinize emin misiniz?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != DialogResult.Yes) return;

            if(txtKULLANICI_REFNO.Text != "")
            {
                SqlParameter prm1 = new SqlParameter("@p1", txtKULLANICI_REFNO.Text);
                string sql2 = "DELETE FROM KULLANICI WHERE KULLANICI_REFNO = @p1";
                db.SqlCalistir(sql2, prm1);
                GridDoldur();
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            // Arama
            string sql2 = "SELECT * FROM KULLANICI WHERE KULLANICI_ADI LIKE '%'+@p1+'%' OR DURUMU LIKE '%'+@p2+'%'";
            List<SqlParameter> prms = new List<SqlParameter>();
            SqlParameter prm1 = new SqlParameter("@p1", "");
            SqlParameter prm2 = new SqlParameter("@p2", "");
            prms.Add(prm1);
            prms.Add(prm2);

            FrmARAMA kullanara = new FrmARAMA(prms, sql2, "KULLANICI_REFNO"); 
            kullanara.ShowDialog();

            DataRow dr = dt.Rows.Find(FrmARAMA.REFNO); // Ref no ya gore satiri bulur.
            satir = dt.Rows.IndexOf(dr); // DataRow kacinci sirada

            KayitGoster(satir);
        }

        void KayitYok()
        {
            btnYENI.Enabled = true;
            btnKAYDET.Enabled = false;
            btnVAZGEC.Enabled = false;
            btnSIL.Enabled = false;
            btnARAMA.Enabled = false;
        }
        void YeniKayit()
        {
            btnYENI.Enabled = false;
            btnKAYDET.Enabled = true;
            btnVAZGEC.Enabled = true;
            btnSIL.Enabled = false;
            btnARAMA.Enabled = false;
        }
        void KayitVar()
        {
            btnYENI.Enabled = true;
            btnKAYDET.Enabled = false;
            btnVAZGEC.Enabled = false;
            btnSIL.Enabled = true;
            btnARAMA.Enabled = true;
        }

        private void TxtSIFRESI_TextChanged(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void TxtKULLANICI_ADI_TextChanged(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void ComboDURUMU_SelectedIndexChanged(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            FrmYETKI yetki = new FrmYETKI();
            yetki.label1.Text = txtKULLANICI_REFNO.Text;
            yetki.ShowDialog();
        }
    }
}
