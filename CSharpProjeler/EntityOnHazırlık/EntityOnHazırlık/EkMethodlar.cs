using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityOnHazırlık
{
    public static class EkMethodlar
    {
        public static int KareAl(this int sayi)
        {
            return sayi * sayi;
        }

        public static int UsAl(this int sayi, int us)
        {
            int sonuc = 1;
            for (int i = 0; i < us; i++)
            {
                sonuc = sonuc * sayi;
            }
            return sonuc;
        }

        public static int RakamBul(this string yazi)
        {
            string sonuc = "";
            for (int i = 0; i < yazi.Length; i++)
            {
                if(Char.IsNumber(yazi[i]) == true)
                {
                    sonuc = sonuc + yazi[i];
                }
            }
            return Convert.ToInt32(sonuc);
        } 
    }
}
