using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            KitapBuilder1 kb1 = new KitapBuilder1();
            KitapDirector dk = new KitapDirector(kb1);

            dk.KitapOlustur();

            Console.WriteLine(kb1.GetKitap().KitapAdi);
            Console.WriteLine(kb1.GetKitap().Fiyati);
            Console.WriteLine(kb1.GetKitap().Yazari);
            Console.WriteLine(kb1.GetKitap().SayfaSayisi);

            Console.ReadKey();
        }

        public class Kitap
        {
            public int SayfaSayisi;
            public string KitapAdi;
            public string Yazari;
            public int Fiyati;
        } 

        public abstract class KitapBuilder : Kitap
        {
            protected Kitap kitap = new Kitap(); // Burasi devralinmasi gerek, yoksa olusan kitabi kaybederiz
            public KitapBuilder()
            {
                kitap.Fiyati = 100;
            }

            public Kitap GetKitap()
            {
                return kitap;
            }

            public abstract void KagidaBas();
            public abstract void SayfalariKes();
            public abstract void SayfalariSirala();
            public abstract void KapakEkle();
            public abstract void Ciltle();
        }

        public class KitapBuilder1 : KitapBuilder
        {
            public KitapBuilder1()
            {
                kitap.KitapAdi = "Harry Potter";
                kitap.Yazari = "J. K. Rowling";
            }
            
            public override void Ciltle()
            {
                Console.WriteLine("5.Ciltle");
            }

            public override void KagidaBas()
            {
                Console.WriteLine("1.Kagida bas");
            }

            public override void KapakEkle()
            {
                Console.WriteLine("4.Kapak Ekle");
            }

            public override void SayfalariKes()
            {
                kitap.SayfaSayisi = 1000;
                kitap.Fiyati = Convert.ToInt32(kitap.SayfaSayisi*0.5);
                Console.WriteLine("2.Sayfalari kes");
            }

            public override void SayfalariSirala()
            {
                Console.WriteLine("3.Sayfalari sirala");
            }
        }

        public class KitapDirector
        {
            KitapBuilder _kb;
            public KitapDirector(KitapBuilder kb)
            {
                _kb = kb;
            }
            public void KitapOlustur()
            {
                _kb.KagidaBas();
                _kb.SayfalariKes();
                _kb.SayfalariSirala();
                _kb.KapakEkle();
                _kb.Ciltle();
            }            
        }

    }
}
