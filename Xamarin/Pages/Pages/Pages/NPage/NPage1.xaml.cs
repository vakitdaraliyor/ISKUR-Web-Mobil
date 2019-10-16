using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pages.NPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NPage1 : ContentPage
    {
        public NPage1()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NPage.NPage2());
        }
    }
}