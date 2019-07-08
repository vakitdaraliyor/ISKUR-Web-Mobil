using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMagaza
{
    class Genel
    {
        /// <summary>
        /// Bütün listeleri doldurur
        /// </summary>
        /// <param name="lst">Doldurulacak liste</param>
        /// <param name="dt">Datatable dan doldurulacak</param>
        /// <param name="display">Ekranda görünecek</param>
        /// <param name="value"></param>
        public static void ListeDoldur(ListControl lst, DataTable dt, string display, string value)
        {
            lst.DisplayMember = display; // ekranda gorunecek olan
            lst.ValueMember = value; // secili bir kategorinin refno su
            lst.DataSource = dt; // veri kaynagi
        }
    }
}
