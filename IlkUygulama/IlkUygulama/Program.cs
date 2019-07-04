using System;

namespace IlkUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = "Ramazan";
            String s = "MERCAN";
            Console.WriteLine("Benim adım {0} soyadım {1}", a, s);
            Console.WriteLine("Toplam: {0}", toplam(1,6));
            Console.WriteLine("Toplam: {0}", toplam(5, 6));
            Console.WriteLine("Fark: {0}", cikarma(7, 3));
        }

         public static int toplam(int a, int b)
        {
            return a+b;
        }

        public static int cikarma(int a, int b)
        {
            return a - b;
        }

    }
}
