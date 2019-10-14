using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun u = new Urun() { Adi = "Centro", Fiyati = 10 };
            Memento m = u.CreateCopy();

            u.Goster();
            u.Adi = "DEGISTI";
            u.Goster();
            u.Restore(m);
            u.Goster();
            Console.ReadLine();
        }

        class Urun
        {
            public string Adi;
            public int Fiyati;

            public Memento CreateCopy()
            {
                return new Memento(this);
            }

            public void Restore(Memento memento)
            {
                Adi = memento.Adi;
                Fiyati = memento.Fiyati;
            }

            public void Goster()
            {
                Console.WriteLine(Adi + " " + Fiyati);
            }

        }

        class Memento
        {
            public string Adi;
            public int Fiyati;

            public Memento(Urun u)
            {
                Adi = u.Adi;
                Fiyati = u.Fiyati;
            }
        }

    }
}
