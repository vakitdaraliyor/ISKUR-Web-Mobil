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
using System.IO;
using System.Diagnostics;

namespace PRATİK
{
    public partial class FrmMUSHAR : Form
    {
        DBClass db = new DBClass();
        DataTable dt = new DataTable();
        public FrmMUSHAR()
        {
            InitializeComponent();
        }

        private void FrmMUSHAR_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM MUSTERI";
            DataTable dt = db.TableGetir(sql);
            Genel.ListeDoldur(comboBox1, dt, "UNVANI", "MUSTERI_REFNO");
            comboBox1.SelectedIndex = 0; // ilk musteriyi secer
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sorgula();
        }

        void Sorgula()
        {
            string sql = "SELECT * FROM MUSTERI_HAREKET WHERE MUSTERI_REFNO=@p1 AND TARIH BETWEEN @p2 AND @p3";
            SqlParameter prm1 = new SqlParameter("@p1", comboBox1.SelectedValue.ToString());
            SqlParameter prm2 = new SqlParameter("@p2", dateTimePicker1.Value.ToString("MM.dd.yyyy"));
            SqlParameter prm3 = new SqlParameter("@p3", dateTimePicker2.Value.ToString("MM.dd.yyyy"));
            dt = db.TableGetir(sql, false, prm1, prm2, prm3);
            dataGridView1.DataSource = dt;
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Sorgula();
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            Sorgula();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet 
            try
            {
                worksheet = workbook.Sheets["Sayfa1"];
            }
            catch (Exception)
            {
                worksheet = workbook.Sheets["Sheet1"];
            }
            
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            // workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            // app.Quit();
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string dosyaAdi = "MUSTERI_EXCEL_" + DateTime.Now.ToString().Replace(":", ".") + ".csv";
            StreamWriter sw = new StreamWriter(@"c:\Users\AYBU\Desktop\outputs\" + dosyaAdi, false, Encoding.UTF8) ;

            string satir = "";
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                satir = satir + dataGridView1.Columns[i].HeaderText;
                if(i != dataGridView1.Columns.Count - 1)
                {
                    satir = satir + ";";
                }
            }

            sw.WriteLine(satir);
            // satirlar eklenecek

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                satir = "";
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    satir = satir + dataGridView1.Rows[i].Cells[j].Value.ToString();
                    if (j != dataGridView1.Columns.Count - 1)
                    {
                        satir = satir + ";";
                    }
                }
                sw.WriteLine(satir);
            }
            sw.Close();

            Process.Start(@"c:\Users\AYBU\Desktop\outputs\" + dosyaAdi);
        }
    }
}
