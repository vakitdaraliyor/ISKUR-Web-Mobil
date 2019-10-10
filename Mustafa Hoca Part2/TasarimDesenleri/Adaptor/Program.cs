using Adaptor.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamCache;

namespace Adaptor
{
    class Program
    {
        static void Main(string[] args)
        {
            Model1 db = new Model1();
            CacheManagerProxy cmp = new CacheManagerProxy(new CacheManager(new TamCacheAdapter()));
            Console.WriteLine("1. ISLEM");            
            List<Model.KATEGORI> liste = cmp.GetCache("kategori", db.KATEGORIs) as List<Model.KATEGORI>;

            Console.WriteLine("2. ISLEM");
            List<Model.KATEGORI> liste2 = cmp.GetCache("kategori", db.KATEGORIs) as List<Model.KATEGORI>;

            foreach (var item in liste2)
            {
                Console.WriteLine(item.KATEGORI_ADI);
            }

            //CacheManager cm = new CacheManager(new TamCacheAdapter());
            //cm.Hafizala("key1", "değeri");
            //cm.HafizadanSil("key1");
            //cm.HafizadanAl("key1");

            Console.ReadKey();
        }

        interface ICacher
        {
            void Hafizala(string name, object value);
            object HafizadanAl(string name);
            void HafizadanSil(string name);
        }

        class MemCache : ICacher
        {
            public object HafizadanAl(string name)
            {
                Console.WriteLine("Hafizadan Alindi");
                return "Test";
            }

            public void HafizadanSil(string name)
            {
                Console.WriteLine("Hafizadan Silindi"); 
            }

            public void Hafizala(string name, object value)
            {
                Console.WriteLine("Hafizalandi");
            }
        }

        class TamCacheAdapter : ICacher
        {
            TamCache.TamCache tc = new TamCache.TamCache();
            public object HafizadanAl(string name)
            {
                return tc.GetCache(name);
            }

            public void HafizadanSil(string name)
            {                
                tc.RemoveCache(name);
            }

            public void Hafizala(string name, object value)
            {
                tc.PutCache(name, value);
            }
        }

        class CacheManager
        {
            ICacher _cacher;
            public CacheManager(ICacher cacher)
            {
                _cacher = cacher;
            }

            public object HafizadanAl(string name)
            {
                return _cacher.HafizadanAl(name);
            }

            public void HafizadanSil(string name)
            {
                _cacher.HafizadanSil(name);
            }

            public void Hafizala(string name, object value)
            {
                _cacher.Hafizala(name, value);
            }
        }

        class CacheManagerProxy
        {
            CacheManager _cm;
            public CacheManagerProxy(CacheManager cm)
            {
                _cm = cm;
            }

            public object GetCache(string name, DbSet<KATEGORI> nesne1)
            {
                if ( _cm.HafizadanAl(name) == null)
                {
                    // Zaman alıcı islem, diskten okunacak burasi
                    var liste = nesne1.ToList();
                    _cm.Hafizala(name, liste);
                }
                return _cm.HafizadanAl(name);
            }
        }

    }
}
