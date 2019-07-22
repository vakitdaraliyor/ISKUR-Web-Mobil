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
    }
}
