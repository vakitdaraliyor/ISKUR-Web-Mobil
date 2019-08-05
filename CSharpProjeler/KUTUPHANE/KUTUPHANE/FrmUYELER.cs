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

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Ilk sayfa
            AktifSayfa = 1;
            GridDoldur();

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Onceki sayfa
            if (AktifSayfa > 1)
            {
                AktifSayfa--;
                GridDoldur();

                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
            if (AktifSayfa == 1)
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // Sonraki Sayfa
            if (AktifSayfa < ToplamSayfa)
            {
                AktifSayfa++;
                GridDoldur();

                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
            if (AktifSayfa == ToplamSayfa)
            {
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // Son Sayfa
            AktifSayfa = ToplamSayfa;
            GridDoldur();

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = false;

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
                             DURUMU = uye.DURUMU == true ? "Aktif":"Pasif",
                             uye.ACIKLAMA
                         }).Skip((AktifSayfa - 1) * SayfadakiSatir).Take(SayfadakiSatir).ToList();
            dataGridView1.DataSource = liste;
        }
    }
}
