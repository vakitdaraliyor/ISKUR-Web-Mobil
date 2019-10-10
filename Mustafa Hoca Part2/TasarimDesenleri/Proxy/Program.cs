using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            //OsenOlsanBari nesne1 = new OsenOlsanBari();

            //Console.WriteLine("Islem basladi 1.");
            //nesne1.IslemYap();
            //Console.WriteLine("Islem Bitti 1.");

            //Console.WriteLine("Islem basladi 2.");
            //nesne1.IslemYap();
            //Console.WriteLine("Islem Bitti 2.");

            OsenOlsanBariProxy p = new OsenOlsanBariProxy();
            Console.WriteLine("Islem basladi 1.");
            p.IslemYap();
            Console.WriteLine("Islem Bitti 1.");

            Console.WriteLine("Islem basladi 2.");
            p.IslemYap();
            Console.WriteLine("Islem Bitti 2.");

            Console.ReadLine();
        }

        class OsenOlsanBari
        {
            public int IslemYap()
            {
                int toplam = 0;
                for (int i = 0; i < 5; i++)
                {
                    System.Threading.Thread.Sleep(1000);
                    toplam++;
                }
                return toplam;
            }
        }

        class OsenOlsanBariProxy
        {
            OsenOlsanBari nesne1 = new OsenOlsanBari();
            public static int? sonuc;
            
            public void IslemYap()
            {
                if (sonuc == null)
                {
                    sonuc = nesne1.IslemYap();
                }
            }
        }

    }
}
