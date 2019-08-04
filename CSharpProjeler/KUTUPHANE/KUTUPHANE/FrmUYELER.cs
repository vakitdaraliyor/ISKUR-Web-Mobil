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
    public partial class FrmUYELER : Form
    {

        KUTUPHANEEntities entities = new KUTUPHANEEntities();

        int ToplamSatir = 0;
        int SayfadakiSatir = 10;
        int ToplamSayfa = 0;
        int AktifSayfa = 1;

        public FrmUYELER()
        {
            InitializeComponent();
        }

        private void FrmUYELER_Load(object sender, EventArgs e)
        {
            ToplamSatir = entities.UYEs.Count();
            ToplamSayfa = ToplamSatir / SayfadakiSatir;

            if (ToplamSatir % SayfadakiSatir != 0) ToplamSayfa++;
            GridDoldur();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Ilk sayfa
            AktifSayfa = 1;
            GridDoldur();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Onceki sayfa
            if (AktifSayfa > 1)
            {
                AktifSayfa--;
                GridDoldur();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // Sonraki Sayfa
            if (AktifSayfa < ToplamSayfa)
            {
                AktifSayfa++;
                GridDoldur();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // Son Sayfa
            AktifSayfa = ToplamSayfa;
            GridDoldur();
        }

        void GridDoldur()
        {
            var liste = (from uye in entities.UYEs
                         orderby uye.UYE_REFNO
                         select new
                         {
                             uye.UYE_REFNO,
                             uye.ADI_SOYADI,
                             uye.ADRES,
                             uye.TELEFON,
                             uye.EMAIL,
                             uye.EKLEME_TARIHI,
                             uye.DURUMU,
                             uye.ACIKLAMA
                         }).Skip((AktifSayfa - 1) * SayfadakiSatir).Take(SayfadakiSatir).ToList();
            dataGridView1.DataSource = liste;
        }
    }
}
