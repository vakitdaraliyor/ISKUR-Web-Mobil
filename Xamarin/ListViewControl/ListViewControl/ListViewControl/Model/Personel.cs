using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewControl.Model
{
    public class Personel
    {
        public string ADI { get; set; }
        public string SOYADI { get; set; }
        public string TELEFON { get; set; }
        public string ADRES { get; set; }
        public string MAIL { get; set; }
        public string ACIKLAMA { get; set; }

    }

    public class PERSONELS : List<Personel>
    {
        List<Personel> liste = new List<Personel>();
        public PERSONELS()
        {
            liste.Add(new Personel { ADI = "Osman", SOYADI = "SAVAS", TELEFON = "5555555555", ADRES = "Ankara", MAIL = "osman@hotmail.com", ACIKLAMA = "osman acikalma"});
            liste.Add(new Personel { ADI = "Ramazan", SOYADI = "MERCAN", TELEFON = "6666666666", ADRES = "Ankara", MAIL = "ramazan@hotmail.com", ACIKLAMA = "ramazan acikalma"});
            liste.Add(new Personel { ADI = "Mustafa", SOYADI = "AKAY", TELEFON = "7777777777", ADRES = "Ankara", MAIL = "mustafa@hotmail.com", ACIKLAMA = "mustafa acikalma"});
            liste.Add(new Personel { ADI = "Soner", SOYADI = "DAG", TELEFON = "8888888888", ADRES = "Hatay", MAIL = "soner@hotmail.com", ACIKLAMA = "soner acikalma"});
            liste.Add(new Personel { ADI = "Mustafa", SOYADI = "CELIKCAN", TELEFON = "9999999999", ADRES = "Ankara", MAIL = "celikcan@hotmail.com", ACIKLAMA = "celikcan acikalma"});
        }

        public List<Personel> ToList()
        {
            return liste;
        }
    }
}
