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
            if (gridObj.Children.Count > 0)
            {
                gridObj.Children.Clear();
                gridObj.Children.Add(ucObj);
            }
            else
            {
                gridObj.Children.Add(ucObj);
            }
        }

    }
}
