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
    public partial class FrmURUNHAR : Form
    {
        DBClass db = new DBClass();
        DataTable dt = new DataTable();
        public FrmURUNHAR()
        {
            InitializeComponent();
        }

        private void FrmURUNHAR_Load(object sender, EventArgs e)
        {
            string sql1 = "SELECT * FROM URUN";
            DataTable dt = db.TableGetir(sql1);
            Genel.ListeDoldur(comboURUN, dt, "ADI", "URUN_REFNO");
            comboURUN.SelectedIndex = 0; // ilk urunu secer
        }

        void Sorgula()
        {
            string sql = "SELECT * FROM URUN_HAREKET WHERE URUN_REFNO=@p1 AND TARIH BETWEEN @p2 AND @p3";
            SqlParameter prm1 = new SqlParameter("@p1", comboURUN.SelectedValue.ToString());
            SqlParameter prm2 = new SqlParameter("@p2", dateTimePicker1.Value.ToString("MM.dd.yyyy"));
            SqlParameter prm3 = new SqlParameter("@p3", dateTimePicker2.Value.ToString("MM.dd.yyyy"));
            dt = db.TableGetir(sql, false, prm1, prm2, prm3);
            dataGridView1.DataSource = dt;
        }

        private void ComboURUN_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sorgula();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Sorgula();
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            Sorgula();
        }

        private void ComboTIPI_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sorgula();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Excel e aktar

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
    }
}
