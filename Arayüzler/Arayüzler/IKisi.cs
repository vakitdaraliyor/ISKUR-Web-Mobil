using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arayüzler
{
    interface IKisi
    {
        void Calis(int kazanc);
        void HarcamaYap(int sayi);
    }

    class Kisi : IKisi
    {
        public static int birikim = 1;

        public void Calis(int kazanc)
        {
            birikim = birikim + kazanc;
        }

        public void HarcamaYap(int sayi)
        {
            birikim = birikim - sayi;
        }

    }
}
