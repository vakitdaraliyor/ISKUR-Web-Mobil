using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            LCFactory lc = new LCFactory(new SistemFactory1());
            lc.IslemYap();

            Console.ReadLine();
        } 

        #region Logger Kodlari
        public abstract class Logger
        {
            public abstract void LogYaz();
        }

        public class SQLLoger : Logger
        {
            public override void LogYaz()
            {
                Console.WriteLine("SQL'e loglandi");
            }
        }

        public class OracleLoger : Logger
        {
            public override void LogYaz()
            {
                Console.WriteLine("Oracle'a loglandi");
            }
        }
        #endregion

        #region Cacher Kodlari
        public abstract class Cacher
        {
            public abstract void CacheYap();
        }

        public class MemCacher : Cacher
        {
            public override void CacheYap()
            {
                Console.WriteLine("MemCache yapildi");
            }
        }

        public class WinCacher : Cacher
        {
            public override void CacheYap()
            {
                Console.WriteLine("Wincache yapildi");
            }
        }
        #endregion

        #region Sistem Factory
        public abstract class SistemFactory
        {
            public abstract Logger CreateLogger();
            public abstract Cacher CreateCacher();
        }

        public class SistemFactory1 : SistemFactory
        {
            public override Cacher CreateCacher()
            {
                return new WinCacher();
            }

            public override Logger CreateLogger()
            {
                return new SQLLoger();
            }
        }

        public class SistemFactory2 : SistemFactory
        {
            public override Cacher CreateCacher()
            {
                return new MemCacher();
            }

            public override Logger CreateLogger()
            {
                return new OracleLoger();
            }
        }
        #endregion

        public class LCFactory
        {
            Logger _log;
            Cacher _cache;
            public LCFactory(SistemFactory sistemFactory)
            {
                _log = sistemFactory.CreateLogger();
                _cache = sistemFactory.CreateCacher();
            }

            public void IslemYap()
            {
                _log.LogYaz();
                _cache.CacheYap();
            }
        }
    }
}
