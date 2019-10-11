using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            UyeIslemFacade uf = new UyeIslemFacade();
            bool sonuc = uf.CheckAllRules();

            if (sonuc == true)
            {
                Console.WriteLine("Giris Yapildi");
            }
            else
            {
                Console.WriteLine("Giris Yapilmadi");
            }

            Console.ReadLine();
        }

        class TCKimlikKontrol
        {
            public bool CheckTC(string tc)
            {
                Random r = new Random();
                int sayi = r.Next(0,2);

                return (sayi == 0) ? false : true;
            }

        }

        class UyeKontrol
        {
            public bool CheckUye(string kullaniciadi)
            {
                Random r = new Random();
                int sayi = r.Next(0, 2);

                return (sayi == 0) ? false : true;
            }

        }

        class UyeIslemFacade
        {
            TCKimlikKontrol tck = new TCKimlikKontrol();
            UyeKontrol uk = new UyeKontrol();

            public bool CheckAllRules()
            {
                return tck.CheckTC("1651651651651") && uk.CheckUye("ramo");
            }
        }

    }
}
