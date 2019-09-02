using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfLoginApp
{
    class UygulamaKontrol
    {

        public static void AddUserControlToGrid(Grid gridObj, UserControl ucObj)
        {
            // Grid in ici doluysa once temizle sonra ekleme yap
            if (gridObj.Children.Count > 0)
            {
                gridObj.Children.Clear();
                gridObj.Children.Add(ucObj);
            }
            // Grid in ici bos ise direk ekle
            else
            {
                gridObj.Children.Add(ucObj);
            }
        }

        public static void SeferEkle(StackPanel spObj, UserControl ucObj)
        {
            // Grid in ici doluysa once temizle sonra ekleme yap
            if (spObj.Children.Count > 0)
            {
                spObj.Children.Add(ucObj);
            }
            // Grid in ici bos ise direk ekle
            else
            {
                spObj.Children.Add(ucObj);
            }
        }

    }
}
