using System;

namespace Inheritance
{
    class Program
    {

        // Inheritance(Kalitim)
        // Kod tekrarinin onune gecmek adina olusturulan siniflarin
        // ortak ozelliklerinin tek bir sinifta toplanip diger siniflarin, ortak olan
        // siniftaki kodlari tekrar yazmamasini saglayan yapidir

        // C#'ta butun siniflar 'object' sinifindan turetilmistir

        public class BaseClass
        {
            public string field1 = "Ortak sinifin degiskeni";
            public void Function()
            {
                Console.WriteLine("Ortak sinifin fonksiyonu");
            }
        }

        public class DriveClass : BaseClass
        {
            public string field2 = "Turetilmis sinifin degiskeni";
            public void Function2()
            {
                Console.WriteLine("Turetilmis sinifin fonksiyonu");
            }
        }

        public class NewClass : DriveClass
        {
            // Base + Drive class in butun ozelliklerini almis olur
            // Turetilmis sinif Base class in daki degiskenleri ya da fonksiyonlari silmez

            // new anahtar kelimesinin aslinda bir etkisi yoktur.
            // Sadece bu degiskenin baseden gelip degistirldigini gostermek ve 
            // kodun anlasilirligini artirmak icin eklenmistir. 
            new public string field2 = "New class field2";

            public void PrintField2()
            {
                Console.WriteLine(field2);      // New class field2
                Console.WriteLine(base.field2); // Turetilmis sinifin degiskeni
            }
        }

        class A
        {
            private int myInt = 5;
            virtual public int getMyInt()
            {
                return myInt;
            }

        }

        class B : A
        {
            private int myInt2 = 10;
            public override int getMyInt()
            {
                return myInt2;
            }
        }

        // Constructor larin calisma sirasi
        class Birinci
        {
            private int number;
            public Birinci() // 2. Olarak temel sinifin constructor ı calisir
            {
                Console.WriteLine("Birinci sinifin constructor ı calisti");
            }

            public Birinci(int a)
            {
                number = a;
            }
        }

        class Ikinci:Birinci
        {
            private int number = 1; // 1. Olarak ikinci calss in degisken tanimlamalari yapilir
            public Ikinci() // 3. Olarak ikinci sinifin constructor ı calisir
            {
                Console.WriteLine("Ikinci sinifin constructor ı calisti");
            }

            public Ikinci(int a, int b):base(a)
            {
                number = b;
            }
        }

        // Class accessibility(erişilebilirlik)
        // 2 cesit erisilebilirlik var
        // 1.public -> her yerden erisilebilir
        // 2.internal -> default olarak belirli class turu
        // Class in sadece ayni proje yada DLL dosyasi icerisinden erisilebilirlik saglar
        // using ifadesi kullanilarak import edilebilir

        // Class Member Accesibility:
        // private -> class uyesinin sadece class icerisinden erisilebilecegini soyler
        // protected -> class uyesinin sadece kendisi ve kendisini tureten siniflar tarafindan kullanilabilecegini soyler
        // public -> class uyesinin herhangi bir class tarafindan erisilebilecegini soylemis oluruz

        // Abstract Class Member
        // Bu class uyeleri override edilmek uzere olusuturulan uyelerdir
        // Degıskense baslangic degerleri olamaz
        // Fonksiyonsa da icerikleri olamaz
        // abstract bir uyeyi tanimlarken uyenin basina abstract on eki getirilir
        // abstract olan bir uye turetilen siniflarda override ediilmek zorundadir

        public abstract class Sekiller
        {
            protected int kenar1;
            protected int kenar2;
            public Sekiller(int kenar1, int kenar2)
            {
                this.kenar1 = kenar1;
                this.kenar2 = kenar2;
            }
            public abstract double AlanHesapla();
        }

        public class DikUcgen : Sekiller
        {
            public DikUcgen(int a, int b) : base(a,b)
            {

            }
            public override double AlanHesapla()
            {
                return (kenar1 * kenar2) / 2;
            }
        }

        public class Dikdortgen : Sekiller
        {
            public Dikdortgen(int a, int b) : base(a, b)
            {

            }
            public override double AlanHesapla()
            {
                return kenar1* kenar2;
            }
        }

        static void Main(string[] args)
        {
            DriveClass dc = new DriveClass();
            Console.WriteLine("field1: " + dc.field1); // Ortak sinifin degiskeni
            Console.WriteLine("field2: " + dc.field2); // Turetilmis sinifin degiskeni
            dc.Function();                             // Ortak sinifin fonksiyonu
            dc.Function2();                            // Turetilmis sinifin fonksiyonu
            dc.field1 = "Yeni deger";                  
            Console.WriteLine("field1: " + dc.field1); // Yeni deger
            NewClass nc = new NewClass();              
            nc.PrintField2();                          // New class field2
                                                       // Turetilmis sinifin degiskeni

            B objB = new B();
            Console.WriteLine(objB.getMyInt());

            A objA = (A)objB;
            Console.WriteLine(objA.getMyInt());

            Ikinci ikinci = new Ikinci();
            Ikinci ikinci2 = new Ikinci(3,5);

            Sekiller ucgen = new DikUcgen(2,2);
            Sekiller dikdortgen = new Dikdortgen(2,2);
            Console.WriteLine("Ucgen alani: " + ucgen.AlanHesapla());
            Console.WriteLine("Dikdortgen alani: " + dikdortgen.AlanHesapla());

        }
    }
}
