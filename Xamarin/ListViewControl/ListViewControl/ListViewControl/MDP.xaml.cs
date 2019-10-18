using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewControl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MDP : MasterDetailPage
    {
        public MDP()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new PersonelListe.PListe());
            IsPresented = false;
        }
    }
}