using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy2
{
    class Program
    {
        static void Main(string[] args)
        {
            int kursUcreti = 1000;
            KursManager km1 = new KursManager();
            km1._ucrethesapla = new IkinciDefaKatilanlar();
            Console.WriteLine("Ikinci defa katilan ucret = " + km1.KursUcret(kursUcreti));

            KursManager km2 = new KursManager();
            km2._ucrethesapla = new TopluKatilanlar();
            Console.WriteLine("Toplu katılanlar ucret = " + km2.KursUcret(kursUcreti));
            Console.WriteLine("-------------------------------------------------------------");

            KursManager ikinciKezKatilan = new KursManager();
            ikinciKezKatilan._ucrethesapla = new IkinciDefaKatilanlar();
            int ilkIndirim = ikinciKezKatilan.KursUcret(kursUcreti);

            ikinciKezKatilan._ucrethesapla = new TopluKatilanlar();
            int net = ikinciKezKatilan.KursUcret(ilkIndirim);
            Console.WriteLine("Ikinci kez ve toplu katilan: " + net);

            KursManager topluKatilan = new KursManager();
            topluKatilan._ucrethesapla = new TopluKatilanlar();
            Console.WriteLine("Toplu ilk kez katilan: " + topluKatilan.KursUcret(kursUcreti)); ;
            int toplam = net + 3 * topluKatilan.KursUcret(kursUcreti);
            Console.WriteLine("Toplam ücret: " + toplam);

            Console.ReadLine();
        }

        abstract class KursUcretiBase
        {
            public abstract int NetUcretHesapla(int ucret); 
        }

        class IlkDefaKatilanlar : KursUcretiBase
        {
            public override int NetUcretHesapla(int ucret)
            {
                return ucret;
            }
        }

        class IkinciDefaKatilanlar : KursUcretiBase
        {
            public override int NetUcretHesapla(int ucret)
            {
                return Convert.ToInt32(ucret * 0.9F);
            }
        }

        class TopluKatilanlar : KursUcretiBase
        {
            public override int NetUcretHesapla(int ucret)
            {
                return Convert.ToInt32(ucret * 0.8F);
            }
        }

        class KursManager
        {
            public KursUcretiBase _ucrethesapla;

            public int KursUcret(int ucret)
            {
                return _ucrethesapla.NetUcretHesapla(ucret);
            }

        }

    }
}
