using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombineClass
{
    class Program
    {
        static void Main(string[] args)
        {
            AB ab = new AB(new A(), new B());
            ab.f1();
            ab.f2();
            ab.f3();
            ab.f4();

            Console.ReadLine();
        }

        class A
        {
            public void f1()
            {
                Console.WriteLine("f1");
            }

            public void f2()
            {
                Console.WriteLine("f2");
            }

        }
        class B
        {
            public void f3()
            {
                Console.WriteLine("f3");
            }

            public void f4()
            {
                Console.WriteLine("f4");
            }

        }

        class AB
        {
            A _a;
            B _b;

            public AB(A a, B b)
            {
                _a = a;
                _b = b;
            }

            public void f1()
            {
                _a.f1();
            }

            public void f2()
            {
                _a.f2();
            }

            public void f3()
            {
                _b.f3();
            }

            public void f4()
            {
                _b.f4();
            }
        }

    }
}
