using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IndirimliUrun iu = new IndirimliUrun(new Urun() { UrunAdi = "karides", Fiyati = 100});
            Console.WriteLine(iu.Fiyati);
            iu.IndirimYap(10);

            Console.WriteLine(iu.Fiyati);
            Console.ReadLine();
        }

        interface IUrun
        {
            string UrunAdi { set; get; }
            int Fiyati { set; get; }
            void Ekle();
        }

        class Urun : IUrun
        {
            public string UrunAdi { get; set; }
            public int Fiyati { get; set; }

            public void Ekle()
            {
                Console.WriteLine("Urun eklendi");
            }
        }

        class UrunDekorator : IUrun
        {
            public string UrunAdi { get; set; }
            public int Fiyati { get; set; }
            IUrun _urun;

            public UrunDekorator(IUrun urun)
            {
                _urun = urun;
                UrunAdi = _urun.UrunAdi;
                Fiyati = _urun.Fiyati;
            }

            public void Ekle()
            {
                _urun.Ekle();
            }
        }

        class IndirimliUrun : UrunDekorator
        {
            public IndirimliUrun(IUrun urun) : base(urun)
            {

            }

            public void IndirimYap(int indirimyuzde)
            {
                Fiyati = Fiyati - Fiyati * indirimyuzde / 100;
            }

        }


        // Kullanmadik interface in abstract hali
        abstract class UrunBase
        {
            public string UrunAdi { set; get; }
            public int Fiyati { set; get; }
            public abstract void Ekle();
        }

    }
}
