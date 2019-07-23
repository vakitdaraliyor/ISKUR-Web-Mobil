using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_OGRENIYORUM
{
    public partial class FrmPAGING : Form
    {
        PRATIKEntities db = new PRATIKEntities();

        int ToplamSatir = 0;
        int SayfadakiSatir = 20;
        int ToplamSayfa = 0;
        int AktifSayfa = 1;

        public FrmPAGING()
        {
            InitializeComponent();
        }

        private void FrmPAGING_Load(object sender, EventArgs e)
        {
            ToplamSatir = db.URUNs.Count();
            ToplamSayfa = ToplamSatir / SayfadakiSatir;

            if (ToplamSatir % SayfadakiSatir != 0) ToplamSayfa++;

            var liste = db.URUNs.OrderBy(u => u.URUN_REFNO).Skip((AktifSayfa - 1)*SayfadakiSatir).Take(SayfadakiSatir).ToList();
            dataGridView1.DataSource = liste;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // Sonraki sayfa
            if (AktifSayfa < ToplamSayfa)
            {
                AktifSayfa++;
                var liste = db.URUNs.OrderBy(u => u.URUN_REFNO).Skip((AktifSayfa - 1) * SayfadakiSatir).Take(SayfadakiSatir).ToList();
                dataGridView1.DataSource = liste;
            }
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Onceki Sayfa
            if(AktifSayfa > 1)
            {
                AktifSayfa--;
                var liste = db.URUNs.OrderBy(u => u.URUN_REFNO).Skip((AktifSayfa - 1) * SayfadakiSatir).Take(SayfadakiSatir).ToList();
                dataGridView1.DataSource = liste;
            }            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Ilk Sayfa
            AktifSayfa = 1;
            var liste = db.URUNs.OrderBy(u => u.URUN_REFNO).Skip((AktifSayfa - 1) * SayfadakiSatir).Take(SayfadakiSatir).ToList();
            dataGridView1.DataSource = liste;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // Son Sayfa
            AktifSayfa = ToplamSayfa;
            var liste = db.URUNs.OrderBy(u => u.URUN_REFNO).Skip((AktifSayfa - 1) * SayfadakiSatir).Take(SayfadakiSatir).ToList();
            dataGridView1.DataSource = liste;
        }
    }
}
