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
    public partial class FrmLOGIN : Form
    {

        DBClass db = new DBClass();
        public FrmLOGIN()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Vazgeç
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Giriş
            string sql = "SELECT * FROM KULLANICI WHERE KULLANICI_ADI = @p1 AND SIFRESI = @p2 AND DURUMU = 'Aktif'";
            SqlParameter prm1 = new SqlParameter("@p1", txtKULLANICI_ADI.Text);
            SqlParameter prm2 = new SqlParameter("@p2", txtSIFRESI.Text);

            DataTable dt = db.TableGetir(sql, false, prm1, prm2);

            if(dt.Rows.Count == 1)
            {
                Hide();
                FrmANA frmAna = new FrmANA();
                frmAna.ShowDialog();
                Close();
            }

            MessageBox.Show("Kullanıcı adı veya şifre yanlış");
        }

       
    }
}
