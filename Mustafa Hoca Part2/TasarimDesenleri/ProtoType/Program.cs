using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    class Program
    {
        static void Main(string[] args)
        {
            Kullanici k = new Kullanici();
            k.Adi = "Osman";
            k.Soyadi = "SAVAS";

            Kullanici kopya = k.Clone() as Kullanici;
            kopya.Adi = "kopya bu yaa";

            Console.WriteLine(k.Adi);
            Console.WriteLine(kopya.Adi);

            Console.ReadLine();

        }

        public abstract class Kisi
        {
            public string Adi { set; get; }
            public string Soyadi { get; set; }
            public abstract Kisi Clone();
        }

        class Kullanici : Kisi
        {
            public override Kisi Clone()
            {
                return MemberwiseClone() as Kisi;
            }
        }

    }
}
