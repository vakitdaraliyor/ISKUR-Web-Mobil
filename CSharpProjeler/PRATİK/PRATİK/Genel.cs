using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADO.Net;

namespace PRATİK
{
    public enum MODUL
    {
        Müşteri = 1,
        Ürün = 2,
        Fatura = 3,
        Sipariş = 4,
        Kategori = 5,
        Kdv = 6,
        Yetki = 8,
        AnaEkran = 9,
        Kullanıcı = 10
    }

    public enum YETKI
    {
        EKLE = 1,
        GUNCELLE = 2,
        SIL = 3,
        OKU = 4
    }

    class Genel        
    {
        public static int KULLANICI_REFNO;
        public static string KULLANICI_ADI;
        public static void EkranıTemizle(Form frm)
        {
            for (int i = 0; i < frm.Controls.Count; i++)
            {
                Control ctl = frm.Controls[i];

                if(ctl is GroupBox)
                {
                    GroupBox gb = (GroupBox)ctl;
                    for(int j = 0; j < gb.Controls.Count; j++)
                    {
                        Control ctl2 = gb.Controls[j];
                        if (ctl2 is TextBox)
                        {
                            ctl2.Text = "";
                        }
                        if (ctl2 is ComboBox)
                        {
                            ComboBox c2 = (ComboBox)ctl2;
                            c2.SelectedIndex = -1;
                        }
                    }
                }

                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
                if (ctl is ComboBox)
                {
                    ComboBox c = (ComboBox)ctl;
                    c.SelectedIndex = -1;
                }

            }
        }

        public static void ListeDoldur(ListControl lst, DataTable dt, string display, string value) {
            lst.DisplayMember = display;
            lst.ValueMember = value;
            lst.DataSource = dt;
        }

        public static void csvReport(string yol, string dosyaAdi, string sql, bool raporver = false)
        {
            DBClass db = new DBClass();
            DataTable dt = db.TableGetir(sql);

            // string dosyaAdi = "MUSTERI_LISTESI" + DateTime.Now.ToString().Replace(":", ".") + ".csv";
            StreamWriter sw = new StreamWriter(yol + dosyaAdi, false, Encoding.UTF8);

            string columnNames = "";
            foreach(DataColumn column in dt.Columns)
            {
                columnNames = columnNames + column.ColumnName + ";";                
            }
            sw.WriteLine(columnNames);

            string satir = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                satir = "";
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    satir = satir + dt.Rows[i][j].ToString();
                    if (j != dt.Columns.Count - 1)
                    {
                        satir = satir + ";";
                    }
                }
                sw.WriteLine(satir);
            }

            sw.Close();
            if(raporver == true) Process.Start(yol + dosyaAdi);
        }

        public static bool YetkiVarmı(int kullanıcı_refno, int modul_refno, int yetkino)
        {
            DBClass db = new DBClass();
            string sql = "SELECT * FROM YETKI WHERE KULLANICI_REFNO=@p1 AND MODUL_REFNO=@p2";
            SqlParameter prm1 = new SqlParameter("@p1", kullanıcı_refno);
            SqlParameter prm2 = new SqlParameter("@p2", modul_refno);

            DataTable dt = db.TableGetir(sql, false, prm1, prm2);

            if (dt.Rows.Count == 0)
            {
                return false;
            }

            switch (yetkino)
            {
                case 1: // Ekle
                    return Convert.ToBoolean(dt.Rows[0]["EKLE"]);
                    break;
                case 2: // Güncelle
                    return Convert.ToBoolean(dt.Rows[0]["GUNCELLE"]);
                    break;
                case 3: // Sil
                    return Convert.ToBoolean(dt.Rows[0]["SIL"]);
                    break;
                case 4: // Oku
                    return Convert.ToBoolean(dt.Rows[0]["OKU"]);
                    break;
                default:
                    return false;
                    break;
            }
        }
    }
}
