using System;

namespace Generics
{

    // Generics: Bir fonksiyon ya da bir class ayni ozellikleri farklı veri turundeki
    // elemanlar icin gerceklestirecekse su ana kadar gordugumuz kısımda her veri turu 
    // ıcın yeniden bir fonksiyon ya da class yazmamıiz gerekiyordu.

    // ortalamaBul(int[] bul)
    // ortalamaBul(double[] arr)

    // Ayni ozellikleri tasiyan ve farkli veri turu kullanan fonksiyon, class,
    // struct ya da delegate yapilari icin tek bir taslak olusturup tum veri
    // turleri icin bu taslagi kullanabilmeyi saglar

    // ortalamaBul<T>(T []arr)

    // T(Type-parametresi): C# bir veri turu degildir. Sadece gecici olarak bizim
    // belirledigimiz bir degisken turudur.

    /* Generic'ler
     * 1- Class
     * 2- Struct
     * 3- Interface
     * 4- Delegate
     * 5- Function
     * yapilarinda kullanilabilir
     */

    /* Generic 
     * Kod Boyutu: Kısa
     * Kolaylik: Daha soyut olduklari icin yazmasi daha karmasikdir
     * Bakim: Degisiklik yapmak istedigimizde sadece generic class uzerinde degisiklik yapmamiz yeterlidir. Bakimi kolaydir.
     * 
     * Non-Generic
     * Kod Boyutu: Uzun
     * Kolaylik: Yazmasi daha kolay
     * Bakim: Bir degiisiklik yapmak istedigimizde kac farkli versiyonumuz varsa o kadar degisiklik yapmamiz gerekir. Bakimi zordur.
     */

    class SomeClass<T1, T2>
    {
        public T1 var1;
        public T2 var2;
    }

    class MyData
    {
        public int number;
    }

    class Simple<T> where T: MyData
    {
        public static bool LessThan(T i1, T i2)
        {
            return false;
        }
    }

    struct PieceOfData<T>
    {
        public T data;
        public PieceOfData(T value)
        {
            data = value;
        }
    }

    // Eger clas generic degilse ama bir fonksiyonu generic yapmak istiyorsak =>
    class Test
    {
        public static void ReverseAndPrint<T>(T[] arr)
        {
            Array.Reverse(arr);
            foreach(T item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
        
    class Program
    {
        static void Main(string[] args)
        {

            SomeClass<int, string> myObj = new SomeClass<int, string>();
            var myObj2 = new SomeClass<double, int>();

            myObj.var1 = 1;       // int
            myObj.var2 = "Osman"; // string

            myObj2.var1 = 2.5;    // double
            myObj2.var2 = 3;      // int

            var intData = new PieceOfData<int>(10);
            var stringData = new PieceOfData<string>("Osman");

            Console.WriteLine(intData.data);
            Console.WriteLine(stringData.data);

            var intArr = new int[] { 3, 6, 1, 6, 9, 4 };
            var stringArr = new string[] { "osman", "ramazan", "ali", "burak", "falcao" };
            var doubleArr = new double[] { 2.5, 1.4, 5.5 };
            
            Test.ReverseAndPrint(intArr);
            Test.ReverseAndPrint(stringArr);
            Test.ReverseAndPrint(doubleArr);
            

            Console.ReadKey();
        }
    }
}
