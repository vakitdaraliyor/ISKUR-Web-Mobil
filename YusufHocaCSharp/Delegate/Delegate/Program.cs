using System;

namespace Delegate
{
    // Delegate: Bu yapiyi bir ya da birden fazla fonksiyonu tutan obje olarak dusunebiliriz
    // Delegate yapisi birden fazla fonk. sakladigindan bu fonksiyonlarin ayni yapida olmasi gerekir.
    // Class uyesi degildir disarida tanimlanir

    delegate void MyDelegate(int x);


    class Program
    {
        void PrintLow(int x)
        {
            Console.WriteLine(x + " is a Low value");
        }

        void PrintHigh(int x)
        {
            Console.WriteLine(x + " is a High value");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            MyDelegate delegateName;

            Random rand = new Random();
            int randomValue = rand.Next(100);

            delegateName = randomValue < 50 ? new MyDelegate(p.PrintLow) : new MyDelegate(p.PrintHigh);
            delegateName(randomValue);

            Console.ReadKey();
        }
    }
}
