using System;

namespace CSharpYusuf
{
    class Program
    {

        // Enumaration degisken isimlerimizle belirledigimiz bir 
        // veri turundeki belirledigimiz degerleri birlestirmeye yarar
        enum  yonler : int
        {
            kuzey = 1,
            guney = 2,
            dogu = 3,
            bati = 4
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Bir deger giriniz: ");
            int input = Convert.ToInt32(Console.ReadLine());

            // Ternary Operator
            // durum ? dogruysa yapilacaklar : yanlissa yapilacaklar
            Console.WriteLine(input > 60 ? "geçti" : "kaldı");

            int yon;
            string yonString;

            yonler benimYonum = yonler.kuzey;
            // $ isareti {degiskenin degerini} yazdirmaya yarar
            Console.WriteLine($"Benim yonum: { benimYonum}");

            yon = (int)benimYonum;
            Console.WriteLine($"Benim yonum: { yon}");

            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            foreach(int item in myArray)
            {
                Console.WriteLine($"{item}");
                // Console.WriteLine(item);
            }

            int total = SumValues(myArray);
            Console.WriteLine("Toplam: " + total);
            int total2 = SumValues(1, 2, 3);
            Console.WriteLine("Toplam2: " + total2);

            // Gonderilecek degerin baslangic degeri olmak zorundadir.
            // int number;
            // ShowDouble(number) calismaz.
            int number = 5;
            Console.WriteLine("Fonksiyondan once: " + number);  // Sonuc = 5
            ShowDouble(number);                                 // Sonuc = 10
            Console.WriteLine("Fonskiyondan sonra: " + number); // Sonuc = 5

            Console.WriteLine("Fonksiyondan once: " + number);  // Sonuc = 5
            ShowDouble(ref number);                             // Sonuc = 10
            Console.WriteLine("Fonskiyondan sonra: " + number); // Sonuc = 10 ref kullanirsak fonksiyondan main e gelince yapilan degisiklik kalici olur.

            // out parametreli fonksiyon
            int sum = 0;
            SumValues(myArray, out sum);
            Console.WriteLine("out parametresi: " + sum);


            Console.ReadKey();

        }

        // ---------------------------------------------------------------------
        // Fonksiyonlar
        // ---------------------------------------------------------------------

        // -- Parametre Arrayi -- 
        // Disaridan array gelmeyebilir.
        // Birden cok deger ayri ayri gelebilir.
        // Sen bunlari array a cevir ondan sonra islem yap.
        static int SumValues(params int[] arr) 
        {
            int sum = 0;
            foreach(int item in arr)
            {
                sum += item;
            }
            return sum;
        }

        static void ShowDouble(int a)
        {
            a *= 2;
            Console.WriteLine(a);
        }

        // const(constant) bir deger parametre olarak gonderilemez!
        // *-*baslangic parametresi olamdan gonderilemez.*-*
        static void ShowDouble(ref int a)
        {
            a *= 2;
            Console.WriteLine(a);
        }

        // Fonksiyon disindan out parametresine gelen degisken degeri
        // mainde de gecerli olur. return etmis gibi dusunulebilir.
        // *-*out parametreleri baslangic degeri olmadan gonderilebilir.*-*
        // Bir fonksiyonda birden fazla deger return etmek istedigimizde
        // ref ve out parametrelerini kullanabiliriz
        static void SumValues(int[] arr, out int sum)
        {
            sum = 0;
            foreach (int item in arr)
            {
                sum += item;
            }
        }

    }
}
