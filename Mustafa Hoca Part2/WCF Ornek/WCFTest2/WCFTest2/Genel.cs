using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WCFTest2
{
    class Genel
    {
        private string _dosyaadi;

        public string DosyaAdi
        {
            get { return _dosyaadi; }
            set { _dosyaadi = value; }
        }

        public Genel(string dosyaadi)
        {
            _dosyaadi = dosyaadi;
        }

        public void LogOlustur(string mesaj)
        {
            string path = Application.StartupPath + "\\" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + DosyaAdi;
            StreamWriter sw = new StreamWriter(path, true, Encoding.UTF8); // ikinci parametre(true) dosyanın üzerine ekler. yoksa yeni oluşturur

            mesaj = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + " " + mesaj;

            sw.WriteLine(mesaj);
            sw.Close();
        }
    }
}
