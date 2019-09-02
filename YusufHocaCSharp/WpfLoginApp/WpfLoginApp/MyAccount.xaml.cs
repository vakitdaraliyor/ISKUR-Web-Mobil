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
            lblWelcome.Content =  "Hoşgeldiniz " + LoginUser.Name;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UygulamaKontrol.AddUserControlToGrid(UserControlGrid, new HesapBilgileri());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Close Button (Ekrani Kapatma)
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // Maximize Button (Tam ekran yapma)
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            // Minimize Button (Ekrani asagi alir)
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            UygulamaKontrol.AddUserControlToGrid(UserControlGrid, new BiletAl());
        }
    }
}
