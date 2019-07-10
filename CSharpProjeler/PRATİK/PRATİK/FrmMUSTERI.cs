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
                errorProvider1.SetError(txtILGILI_KISI, "Müsteri Adı giriniz");
                return;
            }
            else
            {
                errorProvider1.SetError(txtILGILI_KISI, "");
            }

            SqlParameter prm1 = new SqlParameter("@p1", txtACIKLAMA.Text);
            SqlParameter prm2 = new SqlParameter("@p2", txtADRES.Text);
            SqlParameter prm3 = new SqlParameter("@p3", txtALACAK.Text);
            SqlParameter prm4 = new SqlParameter("@p4", txtBAKIYE.Text);
            SqlParameter prm5 = new SqlParameter("@p5", txtBORC.Text);
            SqlParameter prm6 = new SqlParameter("@p6", txtE_POSTA.Text);
            SqlParameter prm7 = new SqlParameter("@p7", txtFAX.Text);
            SqlParameter prm8 = new SqlParameter("@p8", txtILGILI_KISI.Text);
            SqlParameter prm9 = new SqlParameter("@p9", txtMUSTERI_REFNO.Text);
            SqlParameter prm10 = new SqlParameter("@p10", txtPOSTA_KODU.Text);
            SqlParameter prm11 = new SqlParameter("@p11", txtSEHIR.Text);
            SqlParameter prm12 = new SqlParameter("@p12", txtTELEFON1.Text);
            SqlParameter prm13 = new SqlParameter("@p13", txtTELEFON2.Text);
            SqlParameter prm14 = new SqlParameter("@p14", txtTELEFON3.Text);
            SqlParameter prm15 = new SqlParameter("@p15", txtUNVANI.Text);
            SqlParameter prm16 = new SqlParameter("@p16", txtVERGI_DAIRESI.Text);
            SqlParameter prm17 = new SqlParameter("@p17", txtVERGI_NUMARASI.Text);
            SqlParameter prm18 = new SqlParameter("@p18", txtWEB_ADRESI.Text);
            SqlParameter prm19 = new SqlParameter("@p19", comboTIPI.SelectedItem.ToString());

            string sql1 = "";            
            if (txtMUSTERI_REFNO.Text == "")
            {
                sql1 = "INSERT INTO MUSTERI(ACIKLAMA, ADRES, ALACAK, BAKIYE, BORC, E_POSTA, FAX, ILGILI_KISI, POSTA_KODU, SEHIR, TELEFON1, TELEFON2, TELEFON3, UNVANI, VERGI_DAIRESI, VERGI_NUMARASI, WEB_ADRESI, TIPI)" +
                    " VALUES(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p10, @p11, @p12, @p13, @p14, @p15, @p16, @p17, @p18, @p19)";
            }
            else
            {
                sql1 = "UPDATE MUSTERI SET ACIKLAMA = @p1, ADRES = @p2, ALACAK = @p3, BAKIYE = @p4, BORC = @p5, E_POSTA = @p6," +
                    " FAX = @p7, ILGILI_KISI = @p8, POSTA_KODU = @p10, SEHIR = @p11, TELEFON1 = @p12," +
                    " TELEFON2 = @p13, TELEFON3 = @p14, UNVANI = @p15, VERGI_DAIRESI = @p16, VERGI_NUMARASI = @p17, WEB_ADRESI = @p18, TIPI = @p19" +
                    " WHERE MUSTERI_REFNO = @p9";
            }
            db.SqlCalistir(sql1, prm1, prm2, prm3, prm4, prm5, prm6, prm7, prm8, prm9, prm10, prm11, prm12, prm13, prm14, prm15, prm16, prm17, prm18, prm19);
            
            dt = db.TableGetir(sql);
            satir = 0;
            KayitGetir(satir);
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
                try
                {
                    if (txtMUSTERI_REFNO.Text != "")
                    {
                        string sql1 = "DELETE FROM MUSTERI WHERE MUSTERI_REFNO = @p1";
                        SqlParameter prm1 = new SqlParameter("@p1", txtMUSTERI_REFNO.Text);

                        db.SqlCalistir(sql1, prm1);

                        MessageBox.Show("Başarıyla silindi");
                        dt = db.TableGetir(sql);
                        satir = 0;
                        KayitGetir(0);
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata Oluştu:" + hata.Message); // gecici
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM MUSTERI WHERE UNVANI LIKE '%'+@p1+'%' OR ADRES LIKE '%'+@p2+'%' OR SEHIR LIKE '%'+@p3+'%'";
            List<SqlParameter> prms = new List<SqlParameter>();
            SqlParameter prm1 = new SqlParameter("@p1", "");
            SqlParameter prm2 = new SqlParameter("@p2", "");
            SqlParameter prm3 = new SqlParameter("@p3", "");
            prms.Add(prm1);
            prms.Add(prm2);
            prms.Add(prm3);

            FrmARAMA arama = new FrmARAMA(prms, sql, "MUSTERI_REFNO");
            arama.ShowDialog();

            DataRow dr = dt.Rows.Find(FrmARAMA.REFNO);
            satir = dt.Rows.IndexOf(dr);

            KayitGetir(satir);
        }
    }
}
