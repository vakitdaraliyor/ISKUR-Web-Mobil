using System;

namespace StaticClass
{
    // static class 
    // Tum uyeleri ve fonksiyonlari static olmalidir
    // static siniflar ozellikleri objelerini etkilemeyecek verileri ve fonksiyonlari gruplamis oldugumuz sinif turleridir
    // Matematik kutuphanelerinin olusturuldugu bir sinifi static sinifa ornek olarak gosterilebilir

    static class MyMathLibrary
    {
        public static float PI = 3.14F;
        public static bool isOdd(int number)
        {
            if (number %2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static double CemberAlaniHesapla(int r)
        {
            return PI * r * r;
        }
    }

    // Extension Method
    // Bir class in icerigine mudahale edilemedigi durumlarda
    // o class a disaridan baska bir method ekleme islemini
    // extansion metodlar saglar

    class MyData
    {
        private double d1;
        private double d2;
        private double d3;

        public MyData(double d1, double d2, double d3)
        {
            this.d1 = d1;
            this.d2 = d2;
            this.d3 = d3;
        }

        public double Sum()
        {
            return d1 + d2 + d3;
        }
    }

    // Baska bir class a kendine aitmis gibi bir fonksiyonu disaridan eklemek icin
    // static bir class tanilamamiz gerekir. Disaridan ekleyecegimiz fonksiyonun da
    // static olmasi gerekir. Parametresinin basinda this anahtar kelimesi olmasi gerekir.
    static class ExtensionClass
    {
        public static double Average(this MyData obj)
        {
            return obj.Sum() / 3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyMathLibrary.CemberAlaniHesapla(4));
            Console.WriteLine(MyMathLibrary.isOdd(6));

            MyData md = new MyData(2, 3, 4);

            Console.WriteLine("Avarage: " + md.Average());
        }    
    }
}
