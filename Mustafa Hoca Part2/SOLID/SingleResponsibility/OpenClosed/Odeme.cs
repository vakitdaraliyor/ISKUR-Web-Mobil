using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    interface IOdemeTipi
    {
        void OdemeYap();
    }

    class Havale : IOdemeTipi
    {
        public void OdemeYap()
        {
            Console.WriteLine("Havale yapildi");
        }
    }

    class Kredi : IOdemeTipi
    {
        public void OdemeYap()
        {
            Console.WriteLine("Kredi ile yapildi");
        }
    }

    class Paypall : IOdemeTipi
    {
        public void OdemeYap()
        {
            Console.WriteLine("Paypall ile yapildi");
        }
    }

    class Odeme
    {
        public void Ode(IOdemeTipi tip)
        {
            tip.OdemeYap();
        }
    }
}
