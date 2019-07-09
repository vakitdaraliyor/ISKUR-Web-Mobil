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
    public partial class FrmMUSTERI : Form
    {
        DBClass db = new DBClass();
        DataTable dt = new DataTable();
        string sql = "SELECT * FROM MUSTERI";
        int satir = -1;

        
        public FrmMUSTERI()
        {
            InitializeComponent();

        }

        private void FrmMUSTERI_Load(object sender, EventArgs e)
        {
            dt = db.TableGetir(sql);
            if (dt.Rows.Count > 0) satir = 0;
            KayitGetir(satir);
        }

        void KayitGetir(int satirno)
        {
            if(satir > -1)
            {
                txtACIKLAMA.Text = dt.Rows[satirno]["ACIKLAMA"].ToString();
                txtADRES.Text = dt.Rows[satirno]["ADRES"].ToString();
                txtALACAK.Text = dt.Rows[satirno]["ALACAK"].ToString();
                txtBAKIYE.Text = dt.Rows[satirno]["BAKIYE"].ToString();
                txtBORC.Text = dt.Rows[satirno]["BORC"].ToString();
                txtE_POSTA.Text = dt.Rows[satirno]["E_POSTA"].ToString();
                txtFAX.Text = dt.Rows[satirno]["FAX"].ToString();
                txtILGILI_KISI.Text = dt.Rows[satirno]["ILGILI_KISI"].ToString();
                txtMUSTERI_REFNO.Text = dt.Rows[satirno]["MUSTERI_REFNO"].ToString();
                txtPOSTA_KODU.Text = dt.Rows[satirno]["POSTA_KODU"].ToString();
                txtSEHIR.Text = dt.Rows[satirno]["SEHIR"].ToString();
                txtTELEFON1.Text = dt.Rows[satirno]["TELEFON1"].ToString();
                txtTELEFON2.Text = dt.Rows[satirno]["TELEFON2"].ToString();
                txtTELEFON3.Text = dt.Rows[satirno]["TELEFON3"].ToString();
                txtUNVANI.Text = dt.Rows[satirno]["UNVANI"].ToString();
                txtVERGI_DAIRESI.Text = dt.Rows[satirno]["VERGI_DAIRESI"].ToString();
                txtVERGI_NUMARASI.Text = dt.Rows[satirno]["VERGI_NUMARASI"].ToString();
                txtWEB_ADRESI.Text = dt.Rows[satirno]["WEB_ADRESI"].ToString();
                comboTIPI.SelectedItem = dt.Rows[satirno]["TIPI"].ToString();
            }            
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            // Ilk kayit tusu
            satir = 0;
            KayitGetir(satir);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            // Son kayit
            satir = dt.Rows.Count - 1;
            KayitGetir(satir);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            // Sonraki kayit
            if(satir != dt.Rows.Count - 1)
            {
                satir++;
                KayitGetir(satir);
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            // Onceki kayit
            if(satir > 0)
            {
                satir--;
                KayitGetir(satir);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Yeni
            Genel.EkranıTemizle(this);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Kaydet
            if (txtILGILI_KISI.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMUSTERI_REFNO, "Müsteri Adı giriniz");
                return;
            }
            else
            {
                errorProvider1.SetError(txtMUSTERI_REFNO, "");
            }

            SqlParameter prm1 = new SqlParameter("@p1", txtUNVANI.Text);
            SqlParameter prm2 = new SqlParameter("@p2", txtILGILI_KISI.Text);
            SqlParameter prm3 = new SqlParameter("@p3", txtMUSTERI_REFNO.Text);

            string sql = "";
            if (txtMUSTERI_REFNO.Text == "")
            {
                sql = "INSERT INTO MUSTERI(UNVANI, ILGILI_KISI) VALUES(@p1, @p2)";
            }
            else
            {
                sql = "UPDATE MUSTERI SET UNVANI = @p1, ILGILI_KISI = @p2 WHERE MUSTERI_REFNO = @p3";
            }
            db.SqlCalistir(sql, prm1, prm2, prm3);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // Vazgec
            KayitGetir(satir);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Silmek istediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                if (txtMUSTERI_REFNO.Text != "")
                {
                    sql = "DELETE FROM MUSTERI WHERE KATEGORI_REFNO = @p2";
                    SqlParameter prm2 = new SqlParameter("@p2", txtMUSTERI_REFNO.Text);

                    db.SqlCalistir(sql, prm2);

                    MessageBox.Show("Başarıyla silindi");
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
