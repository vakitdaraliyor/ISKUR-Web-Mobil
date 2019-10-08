using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    class Program
    {
        static void Main(string[] args)
        {
            //OpenClosed.Klasik.Odeme od = new Klasik.Odeme();
            //od.OdemeYap();
            //Console.ReadKey();

            Odeme od = new Odeme();
            od.Ode(new Havale());
            od.Ode(new Kredi());
            od.Ode(new Paypall());
            Console.ReadKey();
        }
    }
}
