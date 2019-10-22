using SQLiteLocalVT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SQLiteLocalVT
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NaviKayitKisi : ContentPage
    {
        public NaviKayitKisi()
        {
            InitializeComponent();
        }

        public NaviKayitKisi(int index)
        {
            InitializeComponent();
            Kisi k = App.db.GetTable()[index];
            KisiId.Text = k.KisiId.ToString();
            AdiSoyadi.Text = k.AdiSoyadi;
            Resim.Text = k.Resim;
        }

        private void btnKayit_Clicked(object sender, EventArgs e)
        {
            Kisi k = new Kisi();
            k.AdiSoyadi = AdiSoyadi.Text;
            k.Resim = Resim.Text;
            if (String.IsNullOrEmpty(KisiId.Text))
            {
                App.db.Insert(k);
            }
            else
            {
                k.KisiId = Convert.ToInt32(KisiId.Text);
                App.db.Update(k);
            }

            Listele();

            Navigation.PopAsync(); // Stackten bu page i siler
        }

        void Listele()
        {
            // Navigasyon sayfalari arasindaki ilk sayfayi buluyoruz
            NaviMain sayfa = Navigation.NavigationStack[0] as NaviMain;
            var liste = sayfa.Content.FindByName("lsKisiler") as ListView;

            // ana sayfadaki listeyi değişiklikler yapıldıktan sonra yeniden doldurur.
            liste.ItemsSource = null;
            liste.ItemsSource = App.db.GetTable();
        }

        private void btnVazgec_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btnSil_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(KisiId.Text) == false)
            {
                Kisi k = new Kisi() { KisiId = Convert.ToInt32(KisiId.Text) };
                App.db.Delete(k);
                Listele();
                Navigation.PopAsync(); 
            }
        }
    }
}