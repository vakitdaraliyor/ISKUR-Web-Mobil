using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility.Klasik
{
    class Kullanici
    {
        public int Id;
        public string Adi;
        public string Soyadi;
        public string KullaniciAdi;
        public string Parola;

        public void Ekle(string adi, string soyadi)
        {
            Adi = adi;
            Soyadi = soyadi;
            Console.WriteLine(adi + " " + soyadi + " eklendi");

        }

        public void Guncelle(int id, string adi, string soyadi)
        {
            KullaniciAdi = adi;
            Soyadi = soyadi;
            Console.WriteLine(id + " refnolu kayit " + adi + " " + soyadi + " olarak guncellendi");
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

        public bool CheckUser(string kullaniciadi, string parola)
        {
            KullaniciAdi = kullaniciadi;
            Parola = parola;

            Console.WriteLine(KullaniciAdi + " " + Parola + " ile giris");
            return true;
        } 

        public void LogOut(int id)
        {
            Console.WriteLine(id + " refnolu kullanici cikis yapti.");
        }

    }
}
