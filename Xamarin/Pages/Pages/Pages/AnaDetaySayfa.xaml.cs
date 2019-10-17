using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnaDetaySayfa : MasterDetailPage
    {
        public AnaDetaySayfa()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new GezinmeSayfasi());
            IsPresented = false;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Detail = new SekmeSayfasi();
            IsPresented = false;
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Detail = new CarouselSayfasi();
            IsPresented = false;
        }
    }
}