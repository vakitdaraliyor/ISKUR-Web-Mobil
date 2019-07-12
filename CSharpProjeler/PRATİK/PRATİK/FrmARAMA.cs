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
    public partial class FrmARAMA : Form
    {
        public static int REFNO = 0;
        DBClass db = new DBClass();
        string sql = "";
        string PK_REFNO = "";
        List<SqlParameter> prms = new List<SqlParameter>(); 
        
        public FrmARAMA()
        {
            InitializeComponent();
        }

        public FrmARAMA(List<SqlParameter> _prms, string _sql, string _pk_refno)
        {
            sql = _sql;
            prms = _prms;
            PK_REFNO = _pk_refno;
            InitializeComponent();
        }

        private void FrmARAMA_Load(object sender, EventArgs e)
        {
            txtArama.Focus();
        }

        private void TxtArama_KeyUp(object sender, KeyEventArgs e)
        {
            for (int i = 0; i < prms.Count; i++)
            {
                prms[i].Value = txtArama.Text;
            }

            DataTable dt = db.TableGetir(sql, false, prms.ToArray());
            dataGridView1.DataSource = dt;
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void DataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                REFNO = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[PK_REFNO].Value.ToString());
            }
        }
    }
}
