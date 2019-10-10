using Factory.Model;
using Factory.Rapor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            //CacheFactory cf = new CacheFactory();
            //ICacher win = cf.GetCacher(ECacheType.WinCache);
            //win.CacheAl();

            //ICacher mem = cf.GetCacher(ECacheType.MemCache);
            //mem.CacheAl();

            //Rapor.RaportFactory r = new Rapor.RaportFactory();
            //IRapor rapor = r.GetRapor(ERaportType.PDF);
            //rapor.RaporAdi = "Test.text";
            //rapor.RaporYolu = "c:/RAPOR";
            //rapor.Veri = KULLANICI.GetKullanicilar();
            //rapor.Olustur();

            TamCache t = new TamCache();
            t.PutCache("key1", 10);
            t.PutCache("key2", "Amaç Yazılım");
            t.RemoveCache("key1");

            Dictionary<string, object> liste = t.GetAllCachedItem();

            foreach (var item in liste)
            {
                Console.WriteLine(item.Key + " : " + item.Value.ToString());
            }

            Console.ReadLine();
        }

        interface ICacher
        {
            void CacheAl();
        }

        class WinCache : ICacher
        {
            public void CacheAl()
            {
                Console.WriteLine("WinCache ile hafızalandı");
            }
            public void deneme()
            {
                Console.WriteLine("deneme");
            }
        }

        class MemCache : ICacher
        {
            public void CacheAl()
            {
                Console.WriteLine("MemCache ile hafızalandı");
            }
        }

        enum ECacheType
        {
            MemCache, WinCache
        }
        class CacheFactory
        {
            public ICacher GetCacher(ECacheType cacheType)
            {
                switch (cacheType)
                {
                    case ECacheType.MemCache:
                        return new MemCache();
                    case ECacheType.WinCache:
                        return new MemCache();
                    default:
                        return null;
                }
            }
        }

    }
}
