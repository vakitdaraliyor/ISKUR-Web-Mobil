using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Kontroller
{

    public class Kisi
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Resim { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            Listele();
        }
        public void Listele()
        {
            List<Kisi> liste = new List<Kisi>()
            {
                new Kisi{Adi="Mustafa", Soyadi="CELIKCAN", Resim="resim1.jpg" },
                new Kisi{Adi="Osman", Soyadi="SAVAS", Resim="resim2.jpg" },
                new Kisi{Adi="Ramazan", Soyadi="MERCAN", Resim="resim3.jpg" },
                new Kisi{Adi="Mustafa", Soyadi="AKAY", Resim="resim4.jpg" },
                new Kisi{Adi="Soner", Soyadi="SARIKABADAYI", Resim="resim1.jpg" }
            };

            listeKisi.ItemsSource = liste;
        }

    }
}