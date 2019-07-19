using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LambdaIfadeler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool F1(int sayi)
        {
            if(sayi > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool F2(int sayi)
        {
            if (sayi < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool F3(int sayi, int ilk, int son)
        {
            if(sayi>ilk && sayi < son)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int[] dizi = { 1, 2, 3, -5, -6 };
            // int sonuc1 = Genel.DiziIslem(F2, dizi);
            // int sonuc2 = Genel.DiziIslem(sayi => (sayi>0 ? true : false), dizi);
            int sonuc3 = dizi.DiziIslem(F2);
            // button1.Text = sonuc1.ToString();
            // this.Text = sonuc2.ToString();
            button1.Text = sonuc3.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int[] dizi = { 1, 2, 3, -5, -6 };
            int[] sonuc = dizi.Where1(F2);
            for (int i = 0; i < sonuc.Length; i++)
            {
                listBox1.Items.Add(sonuc[i]);
            }
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int[] dizi = { 1, 2, 3, -5, -6 };
            int[] sonuc = dizi.Where2(F3,-2,2);
            for (int i = 0; i < sonuc.Length; i++)
            {
                listBox1.Items.Add(sonuc[i]);
            }
        }
    }
}
