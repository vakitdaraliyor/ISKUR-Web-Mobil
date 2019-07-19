using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityOnHazırlık
{
    public partial class Form1 : Form
    {

        class Adres
        {
            public string Adi;
            public string Soyadi;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var sayi = 10;
            var yazi = "osman";
            var adr = new Adres();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var s1 = new Adres();

            // Nesne ilklendirme
            var s2 = new Adres(){ Adi = "Mustafa", Soyadi = "Savas" };
            button2.Text = s2.GetType().ToString();
            
            // Anonim tip belirleme
            var s3 = new { Adi = "Osman", Soyadi = "Savas" }; // Burası çok önemli
            this.Text = s3.GetType().ToString();

            var liste = new List<Adres>();
            liste.Add(s1); ;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MyList<int> liste1 = new MyList<int>();
            MyList<Adres> adrList = new MyList<Adres>();

            liste1.Add(2);
            liste1.Add(3);

            adrList.Add(new Adres() { Adi = "osman", Soyadi = "savas" });
            adrList.Add(new Adres() { Adi = "ramo", Soyadi = "mero" });
            adrList.Add(new Adres() { Adi = "mustafa", Soyadi = "akay" });

            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int sayi = 10;
            button4.Text = sayi.KareAl().ToString();
            // button4.Text = Convert.ToString(EkMethodlar.KareAl(10));
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            int sayi = 10;
            button5.Text = sayi.UsAl(3).ToString();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            string yazi = "Ramazan98Osman93";
            button6.Text = yazi.RakamBul().ToString();
        }
    }
}
