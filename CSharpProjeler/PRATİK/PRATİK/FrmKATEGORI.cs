using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADO.Net;

namespace PRATİK
{
    public partial class FrmKATEGORI : Form
    {
        DBClass db = new DBClass();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        public FrmKATEGORI()
        {
            InitializeComponent();
        }

        private void FrmKATEGORI_Load(object sender, EventArgs e)
        {
            dt1 = db.TableGetir("SELECT * FROM KATEGORI", false);
            dataGridView1.DataSource = dt1;
        }

        private void DataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            db.UpdateTable("SELECT * FROM KATEGORI", dt1, null);
        }

        private void DataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            db.UpdateTable("SELECT * FROM KATEGORI", dt1, null);
        }
    }
}
