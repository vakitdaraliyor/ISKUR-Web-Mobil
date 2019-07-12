using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADO.Net;

namespace PRATİK
{
    class Genel
    {
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
    }
}
