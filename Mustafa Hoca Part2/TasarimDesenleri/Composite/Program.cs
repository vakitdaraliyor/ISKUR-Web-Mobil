using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan mudur = new Calisan("Ali", "Mudur");

            Calisan yardimci1 = new Calisan("Veli", "Mudur Yardimcisi");
            Calisan yardimci2 = new Calisan("Ramazan", "Mudur Yardimcisi");

            mudur.Ekle(yardimci1);
            mudur.Ekle(yardimci2);

            Calisan eleman1 = new Calisan("Eleman1", "Eleman1");
            Calisan eleman2 = new Calisan("Eleman2", "Eleman2");
            Calisan eleman3 = new Calisan("Eleman3", "Eleman3");
            Calisan eleman4 = new Calisan("Eleman4", "Eleman4");

            yardimci1.Ekle(eleman1);
            yardimci1.Ekle(eleman2);

            yardimci2.Ekle(eleman3);
            yardimci2.Ekle(eleman4);

            mudur.Listele(mudur);

            Console.ReadLine();
        }

        abstract class CalisanBase
        {
            public string AdiSoyadi;
            public string Unvani;
            public CalisanBase(string adisoyadi, string unvani)
            {
                AdiSoyadi = adisoyadi;
                Unvani = unvani;
            }
        }

        class Calisan : CalisanBase
        {
            List<Calisan> altcalisanlar = new List<Calisan>();
            public Calisan(string adisoyadi, string unvani) : base(adisoyadi, unvani)
            {

            }

            public void Ekle(Calisan calisan)
            {
                altcalisanlar.Add(calisan);
            }
            public void Sil(int index)
            {
                altcalisanlar.RemoveAt(index);
            }

            // Test
            public void Goster()
            {
                Listele(this);
            }

            public void Listele(Calisan calisan)
            {
                Console.WriteLine(calisan.AdiSoyadi + " - " + calisan.Unvani);
                for (int i = 0; i < calisan.altcalisanlar.Count; i++)
                {
                    Console.WriteLine("------------------------------------");
                    Listele(calisan.altcalisanlar[i]);
                }
            }

        }

    }
}
