using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalKlavye
{
    class Daire
    {
        // deger tipi degisken ve referans tipi degisken arasındaki farktan yola cıkarak yapıldı
        public float yaricap = 0;
        public float AlanHesapla()
        {
            return 3.14F * yaricap * yaricap;
        }
        public float CevreHesapla()
        {
            return 3.14F * 2 * yaricap;
        }

    }
}
