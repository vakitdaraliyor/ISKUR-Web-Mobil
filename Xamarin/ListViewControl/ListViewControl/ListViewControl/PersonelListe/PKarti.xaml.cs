using ListViewControl.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewControl.PersonelListe
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PKarti : ContentPage
    {
        Personel personel;

        public PKarti()
        {
            InitializeComponent();
        }

        public PKarti(int index)
        {
            InitializeComponent();
            personel = App.personeller.ToList()[index];
            Kart.BindingContext = personel;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            personel.ACIKLAMA = ACIKLAMA.Text;
            personel.ADI = ADI.Text;
            personel.ADRES = ADRES.Text;
            personel.MAIL = MAIL.Text;
            personel.SOYADI = SOYADI.Text;
            personel.TELEFON = TELEFON.Text;
            Navigation.PopAsync();
        }
    }
}