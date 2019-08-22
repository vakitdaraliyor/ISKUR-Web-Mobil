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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button a basildi");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            object obj = listbox1.SelectedItem;

            // string selected = (obj == null) ? "No item selected" : ((ListBoxItem)obj).Content + ""; // string e cast ettik
            // MessageBox.Show(selected, "Seçilen değer", MessageBoxButton.OK, MessageBoxImage.Information);

            string selected = "";
            if (obj == null)
            {
                selected = "No item Selected";
            }
            else
            {
                foreach (ListBoxItem item in listbox1.Items)
                {
                    if (item.IsSelected)
                    {
                        selected += item.Content + " ";
                    }
                }
            }
            MessageBox.Show(selected, "Secilen degerler");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            object obj = combobox1.SelectedItem;
            string selected = (obj == null) ? "No selected item" : ((ComboBoxItem)obj).Content.ToString();  
            MessageBox.Show(selected, "Secilen deger", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_mouse_enter(object sender, MouseEventArgs e)
        {
            clickButton.Content = "Ramazan Uzerime Geldi";
        }

        private void Button_mouse_leave(object sender, MouseEventArgs e)
        {
            clickButton.Content = "Click Me";
        }

        private void Button_event_click(object sender, RoutedEventArgs e)
        {
            string text = clickButton.Content.ToString();
            clickButton.Content = (text == "Tiklandi" || text == "Tekrar Tiklandi") ? "Tekrar Tiklandi" : "Tiklandi";
        }
    }
}
