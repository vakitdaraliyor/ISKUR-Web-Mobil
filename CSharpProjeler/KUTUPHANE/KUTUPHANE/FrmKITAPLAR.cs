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
    public partial class FrmKITAPLAR : Form
    {
        KUTUPHANEEntities entities = new KUTUPHANEEntities();

        int ToplamSatir = 0;
        int SayfadakiSatir = 10;
        int ToplamSayfa = 0;
        int AktifSayfa = 1;

        public FrmKITAPLAR()
        {
            InitializeComponent();
        }

        private void FrmKITAPLAR_Load(object sender, EventArgs e)
        {
            ToplamSatir = entities.KITAPs.Count();
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
            var liste = (from kitap in entities.KITAPs
                         orderby kitap.KITAP_REFNO
                         select new
                         {
                             kitap.KITAP_REFNO,
                             kitap.ADI,
                             kitap.YAZARI,
                             kitap.ISBN,
                             kitap.BASIM_TARIHI,
                             kitap.YAYIN_EVI,
                             kitap.OZET
                         }).Skip((AktifSayfa - 1) * SayfadakiSatir).Take(SayfadakiSatir).ToList();
            dataGridView1.DataSource = liste;
        }
    }
}
