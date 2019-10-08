using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.Klasik
{
    class Odeme
    {

        public enum ETip
        {
            Havale = 1,
            KrediKarti = 2,
            Paypall = 3
        }

        public void OdemeYap(ETip tip)
        {
            switch (tip)
            {
                case ETip.Havale:
                    Console.WriteLine("Havale ile odeme yapildi");
                    break;
                case ETip.KrediKarti:
                    Console.WriteLine("Kredi ile odeme yapildi");
                    break;
                case ETip.Paypall:
                    Console.WriteLine("Paypall ile odeme yapildi");
                    break;
                default:
                    break;
            }
            
        }
    }
}
