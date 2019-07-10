using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRATİK
{
    class Genel
    {
        public static void EkranıTemizle(Form frm)
        {
            for (int i = 0; i < frm.Controls.Count; i++)
            {
                Control ctl = frm.Controls[i];

                if(ctl is GroupBox)
                {
                    GroupBox gb = (GroupBox)ctl;
                    for(int j = 0; j < gb.Controls.Count; j++)
                    {
                        Control ctl2 = gb.Controls[j];
                        if (ctl2 is TextBox)
                        {
                            ctl2.Text = "";
                        }
                        if (ctl2 is ComboBox)
                        {
                            ComboBox c2 = (ComboBox)ctl2;
                            c2.SelectedIndex = -1;
                        }
                    }
                }

                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
                if (ctl is ComboBox)
                {
                    ComboBox c = (ComboBox)ctl;
                    c.SelectedIndex = -1;
                }

            }
        }

    }
}
