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
    public partial class PListe : ContentPage
    {

        public PListe()
        {
            InitializeComponent();
            lstPersonel.ItemsSource = App.personeller.ToList();
        }

        private void lstPersonel_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            int index = e.SelectedItemIndex;
            Navigation.PushAsync(new PersonelListe.PKarti(index));
        }

        private void lstPersonel_Refreshing(object sender, EventArgs e)
        {
            App.personeller.ToList().Add(new Personel { ADI="Murtaza", SOYADI="GEZIN" });
            lstPersonel.ItemsSource = null;
            lstPersonel.ItemsSource = App.personeller.ToList();
            lstPersonel.IsRefreshing = false;
        }
    }
}