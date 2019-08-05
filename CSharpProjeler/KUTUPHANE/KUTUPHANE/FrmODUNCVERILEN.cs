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
    public partial class FrmODUNCVERILEN : Form
    {
        KUTUPHANEEntities entities = new KUTUPHANEEntities();
        public FrmODUNCVERILEN()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Odunc Verilen kitaplari gird e listeler
        /// </summary>
        private void FrmODUNCVERILEN_Load(object sender, EventArgs e)
        {
            var liste = (from uyee in entities.UYEs
                         from kitapp in entities.KITAPs
                         from o_kitap in entities.ODUNC_KITAP
                         where uyee.UYE_REFNO == o_kitap.UYE_REFNO
                         where kitapp.KITAP_REFNO == o_kitap.KITAP_REFNO
                         where o_kitap.DURUMU == true
                         select new
                         {
                             kitapp.ADI,
                             uyee.ADI_SOYADI,
                             kitapp.ISBN,
                             o_kitap.VERILIS_TARIHI
                         }).ToList();

            dataGridView1.DataSource = liste;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
