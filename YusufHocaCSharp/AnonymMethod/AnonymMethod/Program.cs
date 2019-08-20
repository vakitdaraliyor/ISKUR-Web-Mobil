using System;

namespace AnonymMethod
{
    delegate int MyDelegate(int x);
    class NamedMethod
    {
        public int Add20(int x)
        {
            return x + 20;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NamedMethod nm = new NamedMethod();
            MyDelegate del1 = nm.Add20;

            // Anonym method(bilinmeyen method)
            MyDelegate del2 = delegate (int number){ return number + 20; };

            // Lambda Expression
            MyDelegate del3 = (int num) => { return num + 20; };
            MyDelegate del4 = (num) => { return num + 20; };
            MyDelegate del5 = num => { return num + 20; };
            MyDelegate del6 = num => num + 20;

            Console.WriteLine(del1(15));
            Console.WriteLine(del2(15));
            Console.WriteLine(del3(15));
            Console.WriteLine(del4(15));
            Console.WriteLine(del5(15));
            Console.WriteLine(del6(15));

        }
    }
}
