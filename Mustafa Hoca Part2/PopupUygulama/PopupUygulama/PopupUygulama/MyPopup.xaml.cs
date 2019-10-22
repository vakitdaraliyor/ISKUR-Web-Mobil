using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PopupUygulama
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyPopup : Rg.Plugins.Popup.Pages.PopupPage
    {
        public MyPopup()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}