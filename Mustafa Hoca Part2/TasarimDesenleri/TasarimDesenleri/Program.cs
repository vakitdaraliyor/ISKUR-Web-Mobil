using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TasarimDesenleri
{
    // Singleton sadece bir örnegi olması lazım
    // Bir uygulamada class ın sadece bir örneğini görmek istediğimiz durumlarda kullanılır
    class Program
    {
        static void Main(string[] args)
        {
            DBClass db = DBClass.CreateInstance();            
            Console.WriteLine(db.tarih.ToLocalTime());

            DBClass db2 = DBClass.CreateInstance();
            Console.WriteLine(db2.tarih.ToLocalTime());

            Console.ReadKey();
            
        }

        public class DBClass
        {
            public DateTime tarih = DateTime.Now; 
            static DBClass _db = new DBClass();
            private DBClass()
            {

            }

            public static DBClass CreateInstance()
            {
                return _db;
            }
        }

        public class DBClass2
        {
            static object kilit = new object();
            static DBClass2 _db;

            private DBClass2()
            {

            }

            public static DBClass2 CreateInstance()
            {
                lock (kilit) // multithread uygulamalarında kodun ardısıl olarak çalışmasını saglar
                {
                    if (_db == null)
                    {
                        _db = new DBClass2();
                    }
                }               

                return _db;
            }

        }

    }
}
