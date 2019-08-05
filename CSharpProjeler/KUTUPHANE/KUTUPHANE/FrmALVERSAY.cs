using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KUTUPHANE
{
    public partial class FrmALVERSAY : Form
    {
        KUTUPHANEEntities entities = new KUTUPHANEEntities();
        public FrmALVERSAY()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Alınan ve Verilen kitaplarin sayisini grid e  listeler
        /// </summary>
        private void FrmALVERSAY_Load(object sender, EventArgs e)
        {
            var liste = (from oduncKitap in entities.ODUNC_KITAP
                        group oduncKitap by oduncKitap.DURUMU == true ? "Verildi":"Alındı" into kitaplar
                        select new
                        {
                            DURUMU = kitaplar.Key, 
                            SAYISI = kitaplar.Count()
                        }).ToList();

            dataGridView1.DataSource = liste;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
