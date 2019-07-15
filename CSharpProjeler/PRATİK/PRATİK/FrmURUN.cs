﻿using System;
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
    public partial class FrmURUN : Form
    {
        DBClass db = new DBClass();
        DataTable dt = new DataTable();
        string sql = "SELECT * FROM URUN";
        int satir = -1;
        public FrmURUN()
        {
            InitializeComponent();
        }

        private void FrmURUN_Load(object sender, EventArgs e)
        {
            DataTable dt2 = db.TableGetir("SELECT * FROM KATEGORI");
            Genel.ListeDoldur(comboKATEGORI_REFNO, dt2, "KATEGORI_ADI", "KATEGORI_REFNO");

            DataTable dt3 = db.TableGetir("SELECT * FROM MUSTERI");
            Genel.ListeDoldur(comboTEDARIKCI_REFNO, dt3, "UNVANI", "MUSTERI_REFNO");

            DataTable dt4 = db.TableGetir("SELECT * FROM KDV");
            Genel.ListeDoldur(comboSATIS_KDV_ORANI, dt4, "KDV_ORANI", "KDV_REFNO");

            DataTable dt5 = db.TableGetir("SELECT * FROM KDV");
            Genel.ListeDoldur(comboALIS_KDV_ORANI, dt5, "KDV_ORANI", "KDV_REFNO");

            dt = db.TableGetir(sql, true);
            if (dt.Rows.Count > 0) satir = 0;
            KayitGetir(0);
        }

        void KayitGetir(int satirno)
        {
            if(satir > -1)
            {
                txtADI.Text = dt.Rows[satirno]["ADI"].ToString();
                comboALIS_KDV_ORANI.SelectedValue = dt.Rows[satirno]["ALIS_KDV_ORANI"].ToString();
                txtBARKODU.Text = dt.Rows[satirno]["BARKODU"].ToString();
                txtBIRIM1.Text = dt.Rows[satirno]["BIRIM1"].ToString();
                txtBIRIM2.Text = dt.Rows[satirno]["BIRIM2"].ToString();
                txtKDVSIZ_ALIS_FIYATI.Text = dt.Rows[satirno]["KDVSIZ_ALIS_FIYATI"].ToString();
                txtKDVSIZ_SATIS_FIYATI.Text = dt.Rows[satirno]["KDVSIZ_SATIS_FIYATI"].ToString();
                comboSATIS_KDV_ORANI.SelectedValue = dt.Rows[satirno]["SATIS_KDV_ORANI"].ToString();
                txtURUN_REFNO.Text = dt.Rows[satirno]["URUN_REFNO"].ToString();
                comboALT_KATEGORI_REFNO.SelectedValue = dt.Rows[satirno]["ALT_KATEGORI_REFNO"].ToString();
                comboKATEGORI_REFNO.SelectedValue = dt.Rows[satirno]["KATEGORI_REFNO"].ToString();
                comboTEDARIKCI_REFNO.SelectedValue = dt.Rows[satirno]["TEDARIKCI_REFNO"].ToString();
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            // Ilk urun
            satir = 0;
            KayitGetir(0);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            // Son urun
            satir = dt.Rows.Count - 1;
            KayitGetir(satir);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            // Bir onceki urun
            if(satir > 0)
            {
                satir--;
                KayitGetir(satir);
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            // Bir sonraki urun
            if(satir < dt.Rows.Count - 1)
            {
                satir++;
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

            string mesaj = "";
            if (txtADI.Text == "")
            {
                mesaj = "Ürün Adı boş bırakılamaz!\r\n";
            }
            if (txtBARKODU.Text == "")
            {
                mesaj += "Ürün Barkodu boş bırakılamaz!\r\n";
            }
            if (txtKDVSIZ_ALIS_FIYATI.Text == "")
            {
                mesaj += "Kdv siz alış fiyatı boş bırakılamaz\r\n";
            }
            if (txtKDVSIZ_SATIS_FIYATI.Text == "")
            {
                mesaj = "Kdv siz satış fiyatı boş bırakılamaz!\r\n";
            }
            if (txtBIRIM1.Text == "")
            {
                mesaj += "Birim1 boş bırakılamaz!\r\n";
            }
            if (comboALIS_KDV_ORANI.SelectedIndex == -1)
            {
                mesaj += "Alış kdv oranı boş bırakılamaz\r\n";
            }
            if (comboALT_KATEGORI_REFNO.SelectedIndex == -1)
            {
                mesaj += "Alt kategori alanı boş bırakılamaz\r\n";
            }
            if (comboKATEGORI_REFNO.SelectedIndex == -1)
            {
                mesaj += "Kategori alanı boş bırakılamaz\r\n";
            }
            if (comboSATIS_KDV_ORANI.SelectedIndex == -1)
            {
                mesaj += "Satış kdv oranı boş bırakılamaz\r\n";
            }
            if (comboTEDARIKCI_REFNO.SelectedIndex == -1)
            {
                mesaj += "Tedarikçi boş bırakılamaz";
            }
            if (mesaj != "")
            {
                FrmUYARI uyarı = new FrmUYARI();
                uyarı.textBox1.Text = mesaj;
                uyarı.ShowDialog();
                return;
            }

            // Kaydet
            SqlParameter prm1 = new SqlParameter("@p1", txtADI.Text);
            SqlParameter prm2 = new SqlParameter("@p2", comboALIS_KDV_ORANI.SelectedValue);
            SqlParameter prm3 = new SqlParameter("@p3", txtBARKODU.Text);
            SqlParameter prm4 = new SqlParameter("@p4", txtBIRIM1.Text);
            SqlParameter prm5 = new SqlParameter("@p5", txtBIRIM2.Text);
            SqlParameter prm6 = new SqlParameter("@p6", txtKDVSIZ_ALIS_FIYATI.Text);
            SqlParameter prm7 = new SqlParameter("@p7", txtKDVSIZ_SATIS_FIYATI.Text);
            SqlParameter prm8 = new SqlParameter("@p8", comboSATIS_KDV_ORANI.SelectedValue);
            SqlParameter prm9 = new SqlParameter("@p9", txtURUN_REFNO.Text);
            SqlParameter prm10 = new SqlParameter("@p10", comboALT_KATEGORI_REFNO.SelectedValue);
            SqlParameter prm11 = new SqlParameter("@p11", comboKATEGORI_REFNO.SelectedValue);
            SqlParameter prm12 = new SqlParameter("@p12", comboTEDARIKCI_REFNO.SelectedValue);

            string sql1 = "";
            if(txtURUN_REFNO.Text == "")
            {
                sql1 = "INSERT INTO URUN(ADI, ALIS_KDV_ORANI, BARKODU, BIRIM1, BIRIM2, KDVSIZ_ALIS_FIYATI, KDVSIZ_SATIS_FIYATI, SATIS_KDV_ORANI, ALT_KATEGORI_REFNO, KATEGORI_REFNO, TEDARIKCI_REFNO)" +
                    " VALUES(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p10, @p11, @p12)";
            }
            else
            {
                sql1 = "UPDATE URUN SET ADI=@p1, ALIS_KDV_ORANI=@p2, BARKODU=@p3, BIRIM1=@p4, BIRIM2=@p5, KDVSIZ_ALIS_FIYATI=@p6, KDVSIZ_SATIS_FIYATI=@p7, SATIS_KDV_ORANI=@p8, ALT_KATEGORI_REFNO=@p10, KATEGORI_REFNO=@p11, TEDARIKCI_REFNO=@p12 WHERE URUN_REFNO=@p9";
            }
            db.SqlCalistir(sql1, prm1, prm2, prm3, prm4, prm5, prm6, prm7, prm8, prm9, prm10, prm11, prm12);
            dt = db.TableGetir(sql);
            satir = 0;
            KayitGetir(0);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // Vazgeç
            KayitGetir(satir);
        }

        private void ComboKATEGORI_REFNO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboKATEGORI_REFNO.SelectedIndex > -1)
            {
                string kategorirefno = comboKATEGORI_REFNO.SelectedValue.ToString();
                string sql = "SELECT * FROM ALT_KATEGORI WHERE KATEGORI_REFNO = @p1";
                SqlParameter prm1 = new SqlParameter("@p1", Convert.ToInt32(kategorirefno));

                DataTable dt = db.TableGetir(sql, false, prm1);
                Genel.ListeDoldur(comboALT_KATEGORI_REFNO, dt, "ALT_KATEGORI_ADI", "ALT_KATEGORI_REFNO");
            }
            
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            // Arama
            string sql = "SELECT * FROM URUN WHERE ADI LIKE '%'+@p1+'%' ";
            List<SqlParameter> prms = new List<SqlParameter>();
            SqlParameter prm1 = new SqlParameter("@p1", "");
            prms.Add(prm1);

            FrmARAMA arama = new FrmARAMA(prms, sql, "URUN_REFNO");
            arama.ShowDialog();

            DataRow dr = dt.Rows.Find(FrmARAMA.REFNO);
            satir = dt.Rows.IndexOf(dr);

            KayitGetir(satir);
        }
    }
}
