using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arayüzler
{
    interface IOdemeSistemi
    {
        Boolean OdemeYap(int para);
    }

    class KrediKarti : IOdemeSistemi
    {

        public void test1()
        {

        }

        public bool OdemeYap(int para)
        {
            if(para > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Havale : IOdemeSistemi
    {

        public void test2()
        {

        }

        public bool OdemeYap(int para)
        {
            if (para*1.05 > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
