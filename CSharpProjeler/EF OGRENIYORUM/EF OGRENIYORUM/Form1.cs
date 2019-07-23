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
    public partial class Form1 : Form
    {
        PRATIKEntities db = new PRATIKEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var liste = db.URUNs.ToList(); // ToList() dersek sorgulama baslar ve biter
            listBox1.Items.Clear();
            for (int i = 0; i < liste.Count; i++)
            {
                listBox1.Items.Add(liste[i].ADI);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var liste = db.URUNs; // sadece sorgu tanımı (ToList() yok)

            foreach (var item in liste) // sorgulama baslıyor.
            {
                listBox1.Items.Add(item.ADI);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // Butun kolonlari secmek istemiyorum
            var liste = db.URUNs.Select(u => new { u.ADI, u.KDVSIZ_SATIS_FIYATI});
            foreach (var item in liste)
            {
                listBox1.Items.Add(item.ADI + " " + item.KDVSIZ_SATIS_FIYATI.ToString());
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            var liste = from urun in db.URUNs select urun; // SQL LIKE LINQ
            foreach (var item in liste)
            {
                listBox1.Items.Add(item.ADI + " " + item.KDVSIZ_SATIS_FIYATI.ToString());
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string adi = "ASUS"; // SQL injection önlemek için bu sekilde tanımladık
            var liste = db.URUNs.Where(u => (u.KDVSIZ_SATIS_FIYATI > 10 && u.KDVSIZ_SATIS_FIYATI < 100) && u.ADI.Contains(adi)); // Tanımlandı 
            // adi = "HP" adi HP olarak alır. Çünkü Yukarda henüz çalıştırılmadı sadece tanımlandı.
            foreach (var item in liste) // Çalıştı
            {
                listBox1.Items.Add(item.ADI + " " + item.KDVSIZ_SATIS_FIYATI.ToString());
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            string adi = "ASUS"; // SQL injection önlemek için bu sekilde tanımladık
            var liste = db.URUNs.Select(u => new { UrunAdi = u.ADI, Fiyati = u.KDVSIZ_SATIS_FIYATI}) // column adlari değişti
                                .Where(u => (u.Fiyati > 10 && u.Fiyati < 100) && u.UrunAdi.Contains(adi)); // Tanımlandı (değişen column isimleriyle devam edildi)
            
            foreach (var item in liste) // Çalıştı
            {
                listBox1.Items.Add(item.UrunAdi + " " + item.Fiyati.ToString());
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            string adi = "ASUS";
            var liste = db.URUNs.Where(u => (u.KDVSIZ_SATIS_FIYATI > 10 && u.KDVSIZ_SATIS_FIYATI < 100) && u.ADI.Contains(adi))
                                .Select(u => new { UrunAdi = u.ADI, Fiyati = u.KDVSIZ_SATIS_FIYATI });
                                
            foreach (var item in liste) // Çalıştı
            {
                listBox1.Items.Add(item.UrunAdi + " " + item.Fiyati.ToString());
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            string adi = "ASUS";
            var liste = from urun in db.URUNs
                        where (urun.KDVSIZ_SATIS_FIYATI > 10 && urun.KDVSIZ_SATIS_FIYATI < 100) || urun.ADI.Contains(adi)
                        select new { UrunAdi = urun.ADI, Fiyati = urun.KDVSIZ_SATIS_FIYATI };
            adi = "HP";
            foreach (var item in liste) // Çalıştı
            {
                listBox1.Items.Add(item.UrunAdi + " " + item.Fiyati.ToString());
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            var liste = db.URUNs.OrderBy(u => u.ADI);
            foreach (var item in liste)
            {
                listBox1.Items.Add(item.ADI + " " + item.KDVSIZ_SATIS_FIYATI.ToString());
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            var liste = db.URUNs.OrderBy(u => u.KATEGORI_REFNO).ThenBy(u => u.KDVSIZ_SATIS_FIYATI);
            foreach (var item in liste)
            {
                listBox1.Items.Add(item.KATEGORI_REFNO.ToString() + " " + item.KDVSIZ_SATIS_FIYATI.ToString());
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            var liste = db.URUNs.OrderByDescending(u => u.KATEGORI_REFNO).ThenByDescending(u => u.KDVSIZ_SATIS_FIYATI);
            foreach (var item in liste)
            {
                listBox1.Items.Add(item.KATEGORI_REFNO.ToString() + " " + item.KDVSIZ_SATIS_FIYATI.ToString());
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            var liste = db.URUNs.OrderBy(u => new { u.KATEGORI_REFNO, u.KDVSIZ_ALIS_FIYATI });
            foreach (var item in liste)
            {
                listBox1.Items.Add(item.KATEGORI_REFNO.ToString() + " " + item.KDVSIZ_SATIS_FIYATI.ToString());
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            var liste = from urun in db.URUNs
                        where urun.KDVSIZ_SATIS_FIYATI > 100
                        orderby urun.KATEGORI_REFNO, urun.KDVSIZ_SATIS_FIYATI
                        select urun;
            foreach (var item in liste)
            {
                listBox1.Items.Add(item.KATEGORI_REFNO.ToString() + " " + item.KDVSIZ_SATIS_FIYATI.ToString());
            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            // SQL => SELECT * FROM JOIN KATEGORI ON URUN.KATEGORI_REFNO=KATEGORI.KATEGORI_REFNO
            var liste = db.KATEGORIs.SelectMany(d => d.URUNs, (k, u) => new { k.KATEGORI_ADI, u.ADI });
            foreach (var item in liste)
            {
                listBox1.Items.Add("Kategori Adı: " + item.KATEGORI_ADI.ToString() + " Urun Adı: " + item.ADI.ToString());
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            var liste = db.KATEGORIs.SelectMany(k => k.ALT_KATEGORI, (k, a) => new { k.KATEGORI_ADI, a.ALT_KATEGORI_ADI });
            foreach (var item in liste)
            {
                listBox1.Items.Add("Kategori Adı: " + item.KATEGORI_ADI.ToString() + " Alt kategori Adı: " + item.ALT_KATEGORI_ADI.ToString());
            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            var liste = db.URUNs.SelectMany(u => u.SIP_DETAY, (u, s) => new { u.ADI, s.MIKTAR, s.KDVSIZ_BIRIM_FIYATI });
            foreach (var item in liste)
            {
                listBox1.Items.Add("Urun adı: " + item.ADI.ToString() + "\t" +
                                   " Miktarı: " + item.MIKTAR.ToString() + "\t" + 
                                   " Birim Fiyatı: " + item.KDVSIZ_BIRIM_FIYATI.ToString());
            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            var liste = from urun in db.URUNs
                        from sipdetay in db.SIP_DETAY
                        where urun.URUN_REFNO == sipdetay.URUN_REFNO
                        select new { urun.ADI, sipdetay.MIKTAR, sipdetay.KDVSIZ_BIRIM_FIYATI };
            foreach (var item in liste)
            {
                listBox1.Items.Add("Urun adı: " + item.ADI.ToString() + "\t\t" +
                                   " Miktarı: " + item.MIKTAR.ToString() + "\t\t" +
                                   " Birim Fiyatı: " + item.KDVSIZ_BIRIM_FIYATI.ToString());
            }
        }

        //                GROUP BY (Istatistiksel veri elde etmekte kullanılır.Raporlama!)
        /*-----------------------------------------------------------------------------------------------
        SELECT COUNT(*) FROM URUN
        -------------------------------------------------------------------------------------------------
        SELECT KATEGORY_REFNO COUNT(*) FROM URUN
        GROUP BY KATEGORY_REFNO
        -------------------------------------------------------------------------------------------------
        SEELCT ALT_KATEGORY_REFNO COUNT(*),MIN(FIYATI), MAX(FIYATI), AVG(FIYATI), SUM(FIYATI) FROM URUN
        GROUP BY ALT_KATEGORI_REFNO
        -------------------------------------------------------------------------------------------------
        SEELCT ALT_KATEGORI.ALT_KATEGORY_ADI,
	        COUNT(*) SAYI,
	        MIN(FIYATI) "MINIMUM FIYATI", 
	        MAX(FIYATI) [MAKSIMUM FIYATI], 
	        AVG(FIYATI) AS ORTALAMA, 
	        SUM(FIYATI) [SUM]
        FROM URUN, ALT_KATEORI
        WHERE URUN.ALT_KATEGORI_REFNO=ALT_KATEGORI.ALT_KATEGORI_REFNO
        GROUP BY ALT_KATEGORI.ALT_KATEGORI_ADI
        -----------------------------------------------------------------------------------------------*/

        private void Button18_Click(object sender, EventArgs e)
        {
            var liste = db.URUNs.GroupBy(u => u.KATEGORI_REFNO)
                                .Select(g => new { groupkey = g.Key, min = g.Min(u => u.KDVSIZ_SATIS_FIYATI),
                                                                     max = g.Max(u => u.KDVSIZ_SATIS_FIYATI),
                                                                     avg = g.Average(u => u.KDVSIZ_SATIS_FIYATI),
                                                                     sum = g.Sum(u => u.KDVSIZ_SATIS_FIYATI),
                                                                     count = g.Count()});

            listBox1.Items.Clear();
            listBox1.Items.Add("REFNO\tCount\tOrtalama\t\tMin\tMax\tSum");
            foreach (var item in liste)
            {                
                listBox1.Items.Add(item.groupkey + "\t" + item.count + "\t" + item.avg + "\t" + item.min + "\t" + item.max + "\t" + item.sum);
            }
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            var liste = db.URUNs.GroupBy(u => u.KATEGORI_REFNO)
                                .Select(g => new {
                                    groupkey = g.Key,
                                    grup = g,
                                    min = g.Min(u => u.KDVSIZ_SATIS_FIYATI),
                                    max = g.Max(u => u.KDVSIZ_SATIS_FIYATI),
                                    avg = g.Average(u => u.KDVSIZ_SATIS_FIYATI),
                                    sum = g.Sum(u => u.KDVSIZ_SATIS_FIYATI),
                                    count = g.Count()
                                });

            listBox1.Items.Clear();
            foreach (var item in liste)
            {
                listBox1.Items.Add("REFNO\tCount\tOrtalama\t\tMin\tMax\tSum");
                listBox1.Items.Add(item.groupkey + "\t" + item.count + "\t" + item.avg + "\t" + item.min + "\t" + item.max + "\t" + item.sum);
                listBox1.Items.Add("--------------------------------------------------------------------------------------------------------------");
                foreach (var urun in item.grup)
                {
                    listBox1.Items.Add(urun.ADI + " " + urun.KDVSIZ_SATIS_FIYATI);
                }
                listBox1.Items.Add("--------------------------------------------------------------------------------------------------------------");
            }
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            var liste = from urun in db.URUNs
                        group urun by urun.KATEGORI_REFNO into urunler
                        select new
                        {
                            groupkey = urunler.Key,
                            grup = urunler,
                            min = urunler.Min(u => u.KDVSIZ_SATIS_FIYATI),
                            max = urunler.Max(u => u.KDVSIZ_SATIS_FIYATI),
                            avg = urunler.Average(u => u.KDVSIZ_SATIS_FIYATI),
                            sum = urunler.Sum(u => u.KDVSIZ_SATIS_FIYATI),
                            count = urunler.Count()
                        };

            listBox1.Items.Clear();
            foreach (var item in liste)
            {
                listBox1.Items.Add("REFNO\tCount\tOrtalama\t\tMin\tMax\tSum");
                listBox1.Items.Add(item.groupkey + "\t" + item.count + "\t" + item.avg + "\t" + item.min + "\t" + item.max + "\t" + item.sum);
                listBox1.Items.Add("--------------------------------------------------------------------------------------------------------------");
                foreach (var urun in item.grup)
                {
                    listBox1.Items.Add(urun.ADI + " " + urun.KDVSIZ_SATIS_FIYATI);
                }
                listBox1.Items.Add("--------------------------------------------------------------------------------------------------------------");
            }
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            // SelectMany başka yöntemi
            var liste = db.KATEGORIs.Join(db.URUNs,
                                          k => k.KATEGORI_REFNO,
                                          u => u.KATEGORI_REFNO,
                                          (k, u) => new { k.KATEGORI_ADI, u.ADI, u.KDVSIZ_SATIS_FIYATI});

            listBox1.Items.Clear();
            foreach (var item in liste)
            {
                listBox1.Items.Add(item.KATEGORI_ADI + " " + item.ADI);
            }
        }
    }
}
