using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YildirimBeyazit.Iskur.Windows
{
    class HesapMakinesi
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Cikarma(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

        public int Carpma(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Bolme(int sayi1, int sayi2)
        {
            return sayi1 / sayi2;
        }

    }

}


namespace YildirimBeyazit.Iskur
{
    class HesapMakinesi
    {
        public String Mesaj(String m)
        {
            return m;
        }
    }
}