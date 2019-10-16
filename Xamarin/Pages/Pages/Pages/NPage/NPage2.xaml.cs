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
    public partial class NPage2 : ContentPage
    {
        public NPage2()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NPage.NPage3());
        }
    }
}