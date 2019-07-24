using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanalKlavye
{
    class Klavye
    {
        public TextBox yazi;

        public void Yaz(string harf)
        {
            yazi.Text += harf;
        }
    }
}
