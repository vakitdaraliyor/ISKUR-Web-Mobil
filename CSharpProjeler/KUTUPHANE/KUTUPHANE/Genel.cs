using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KUTUPHANE
{
    class Genel
    {
        public static void ListeDoldur<T>(ListControl lst, List<T> durum, string display, string value)
        {
            lst.DisplayMember = display;
            lst.ValueMember = value;
            lst.DataSource = durum;
        }
    }
}
