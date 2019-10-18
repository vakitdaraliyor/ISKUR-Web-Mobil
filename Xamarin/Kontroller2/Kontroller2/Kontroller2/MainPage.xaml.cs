using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Kontroller2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        List<string> liste = new List<string> { "Secenek1", "Secenek2", "Secenek3", "Secenek4", "Secenek5" };
        public MainPage()
        {
            InitializeComponent();
            pcListe.ItemsSource = liste;
        }

        private void pcListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            secim.Text = pcListe.Items[pcListe.SelectedIndex].ToString();
        }
    }
}
