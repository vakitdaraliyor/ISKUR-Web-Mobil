using System;

namespace NesneTabanliProgramlama
{

    class Ad
    {
        // Class'a ait member (degisken, property...)
        public int Mem1;
        // Objeler arasinda paylasilan global degisken gibi dusunulebilir
        public static int Mem2;
        // const degiskenler de ayni static gibi davranir
        // public const int Mem3 = 5;

        // Class'ın constructor
        // Her Class'ın en az bir constructor u olmak zorundadir
        // Herhangi bir constructor yazmazsak burada
        // default constructor tanimlanir
        /* Default constructor
            public Ad(){ }
        */
        // Eger biz herhangi bir constructor yazdiysak default constructor
        // otomatik olarak eklenmez

        // Class'a ait fonksiyonlar 
        public void Increment()
        {
            Mem2++;
        } 
        public int GetMem2()
        {
            return Mem2;
        }

        // static olmayan degisken veya fonksiyonlar
        // static fonksiyon icerisinde kullanilamaz
        public static void PrintMem2()
        {
            Console.WriteLine("Mem2: " + Mem2);
        }
    }

    class Point
    {
        public int p1;
        public int p2;

        public void SetP1(int x)
        {
            this.p1 = x;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // herhangi bir obje olusturulmadan static elemanlara deger verilebilir
            Ad.Mem2 = 10;

            Ad obj1 = new Ad();
            obj1.Mem1 = 2;
            Ad obj2 = new Ad();
            obj2.Mem1 = 5;

            Console.WriteLine("Obj 1");
            Console.WriteLine("Mem1: {0} Mem2: {1}", obj1.Mem1, obj1.GetMem2());

            Console.WriteLine("Obj 2");
            Console.WriteLine("Mem1: {0} Mem2: {1}", obj2.Mem1, obj2.GetMem2());

            Console.WriteLine("---------------------------------------------------------------------");
            obj1.Increment();
            Console.WriteLine("static degisken obj1 uzerinden Increment fonksiyonu ile degistirildi");

            Console.WriteLine("Obj 1");
            Console.WriteLine("Mem1: {0} Mem2: {1}", obj1.Mem1, obj1.GetMem2());

            Console.WriteLine("Obj 2");
            Console.WriteLine("Mem1: {0} Mem2: {1}", obj2.Mem1, obj2.GetMem2());

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("static fonksiyon");
            Ad.PrintMem2();

            // -----------------------------------------------------------------------------------------

            Point pObj1 = new Point();
            Point pObj2 = new Point { p1 = 3, p2 = 4 };

            Console.WriteLine("pObj1: " + pObj1.p1 + " " + pObj1.p2); // default const.
            Console.WriteLine("pObj2: " + pObj2.p1 + " " + pObj2.p2);

            Console.ReadKey();

            
        }
    }
}
