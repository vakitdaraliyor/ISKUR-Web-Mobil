using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfLoginApp
{
    /// <summary>
    /// MyAccount.xaml etkileşim mantığı
    /// </summary>
    public partial class MyAccount : Window
    {
        public MyAccount()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lblWelcome.Content =  "Welcome " + LoginUser.Name;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            UygulamaKontrol.AddUserControlToGrid(UserControlGrid, new HesapBilgileri());
        }
    }
}
