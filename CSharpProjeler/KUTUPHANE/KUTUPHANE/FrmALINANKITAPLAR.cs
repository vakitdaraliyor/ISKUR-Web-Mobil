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
    public partial class FrmALINANKITAPLAR : Form
    {
        KUTUPHANEEntities entities = new KUTUPHANEEntities();

        public FrmALINANKITAPLAR()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form yuklenirken alınan kitapları gride listeler
        /// </summary>
        private void FrmALINANKITAPLAR_Load(object sender, EventArgs e)
        {
            var liste = (from uyee in entities.UYEs
                         from kitapp in entities.KITAPs
                         from o_kitap in entities.ODUNC_KITAP
                         where uyee.UYE_REFNO == o_kitap.UYE_REFNO
                         where kitapp.KITAP_REFNO == o_kitap.KITAP_REFNO
                         where o_kitap.DURUMU == false
                         orderby o_kitap.VERILIS_TARIHI
                         select new
                         {
                             kitapp.ADI,
                             uyee.ADI_SOYADI,
                             kitapp.ISBN,
                             o_kitap.VERILIS_TARIHI,
                         }).ToList();

            dataGridView1.DataSource = liste;
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            GridDoldur();
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            GridDoldur();
        }

        /// <summary>
        /// Alınan Kitapların Veriliş Tarihine Gore Kucukten Buyuge Sıralı Hali
        /// </summary>
        void GridDoldur()
        {
            var liste = (from uyee in entities.UYEs
                         from kitapp in entities.KITAPs
                         from o_kitap in entities.ODUNC_KITAP
                         where uyee.UYE_REFNO == o_kitap.UYE_REFNO
                         where kitapp.KITAP_REFNO == o_kitap.KITAP_REFNO
                         where o_kitap.DURUMU == false
                         where o_kitap.VERILIS_TARIHI >= dtILK_TARIH.Value && o_kitap.VERILIS_TARIHI <= dtSON_TARIH.Value
                         orderby o_kitap.VERILIS_TARIHI
                         select new
                         {
                             kitapp.ADI,
                             uyee.ADI_SOYADI,
                             kitapp.ISBN,
                             o_kitap.VERILIS_TARIHI,
                         }).ToList();

            dataGridView1.DataSource = liste;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
