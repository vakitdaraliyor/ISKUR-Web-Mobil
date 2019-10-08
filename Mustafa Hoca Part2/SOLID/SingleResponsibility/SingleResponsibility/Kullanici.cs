using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    partial class Kullanici
    {
        public int Id;
        public string Adi;
        public string Soyadi;
        public string KullaniciAdi;
        public string Parola;
    }

    partial class Kullanici
    {
        public DateTime DoğumTarihi;
    }

    class KullaniciCRUD
    {
        public void Ekle(Kullanici k)
        {
            Console.WriteLine(k.Adi + " " + k.Soyadi + " eklendi");
        }  

    
        public void Guncelle(Kullanici k)
        {
            Console.WriteLine(k.Adi + " " + k.Soyadi + " olarak guncellendi");
        }

        public void Sil(int id)
        {
            Console.WriteLine(id + " refnolu kullanici silindi");
        }

        public Kullanici Getir(int id)
        {
            Kullanici k = new Kullanici()
            {
                Id = id,
                KullaniciAdi = "Osman",
                Parola = "123",
                Adi = "Osman",
                Soyadi = "SAVAS"
            };
            Console.WriteLine(k.KullaniciAdi + " " + k.Parola + " kullanici bulundu");
            return k;
        }

    }

    class KullaniciAuthentication
    {
        public bool CheckUser(string kullaniciadi, string parola)
        {
            Console.WriteLine(kullaniciadi + " " + parola + " ile giris");
            return true;
        }

        public void LogOut(int id)
        {
            Console.WriteLine(id + " refnolu kullanici cikis yapti.");
        }
    }

}
