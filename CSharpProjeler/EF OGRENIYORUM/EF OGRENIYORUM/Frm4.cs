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
    public partial class Frm4 : Form
    {
        public Frm4()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 1, 2, 5, -20, 3, 4, -6, -9, 90, 80 };

            var yeni = sayilar.Where(x => x > 1 && x < 50);

            foreach (var item in yeni)
            {
                listBox1.Items.Add(item.ToString());
            }
        }

        class Kisi
        {
            public string adi;
            public string soyadi;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var liste = new List<Kisi>();
            liste.Add(new Kisi() { adi = "Osman", soyadi = "Savas" });
            liste.Add(new Kisi() { adi = "Ramazan", soyadi = "Mercan" });
            liste.Add(new Kisi() { adi = "Mustafa", soyadi = "Akay" });
            liste.Add(new Kisi() { adi = "Soner", soyadi = "Dag" });

            var sonuc =liste.Where(k => k.adi.Contains("a"));

            foreach (var item in sonuc)
            {
                listBox1.Items.Add(item.adi);
            }
        }
    }
}
