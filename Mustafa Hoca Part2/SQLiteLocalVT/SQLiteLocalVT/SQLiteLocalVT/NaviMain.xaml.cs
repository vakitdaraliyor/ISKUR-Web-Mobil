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
    public partial class NaviMain : ContentPage
    {
        public NaviMain()
        {
            InitializeComponent();
            //Kisi k1 = new Kisi() { KisiId = 1, AdiSoyadi = "Mustafa Celikcan", Resim = "resim1.jpg"};
            //Kisi k2 = new Kisi() { KisiId = 2, AdiSoyadi = "Osman Savas", Resim = "resim1.jpg"};
            //Kisi k3 = new Kisi() { KisiId = 3, AdiSoyadi = "Ramazan Mercan", Resim = "resim1.jpg"};
            //App.db.Insert(k1);
            //App.db.Insert(k2);
            //App.db.Insert(k3);

            lsKisiler.ItemsSource = App.db.GetTable();
            
        }

        private void lsKisiler_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // List<Kisi> liste = lsKisiler.ItemsSource as List<Kisi>;
            Navigation.PushAsync(new NaviKayitKisi(e.SelectedItemIndex));
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NaviKayitKisi());
        }

        private void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}