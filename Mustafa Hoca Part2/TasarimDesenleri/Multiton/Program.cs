using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiton
{
    class Program
    {
        static void Main(string[] args)
        {
            DBClass db1 = DBClass.CreateInstance("sql");
            System.Threading.Thread.Sleep(1000);
            DBClass db2 = DBClass.CreateInstance("sql");
            System.Threading.Thread.Sleep(1000);
            DBClass db3 = DBClass.CreateInstance("oracle");
            System.Threading.Thread.Sleep(1000);
            DBClass db4 = DBClass.CreateInstance("oracle");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(db1.id);
            Console.WriteLine(db2.id);
            Console.WriteLine(db3.id);
            Console.WriteLine(db4.id);

            Console.ReadLine();
        }

        public class DBClass
        {
            public Guid id;
            static Dictionary<string, DBClass> liste = new Dictionary<string, DBClass>();

            static object kilit = new object();
            private DBClass()
            {
                id = new Guid();
            }

            public static DBClass CreateInstance(string dbtype)
            {
                lock (kilit)
                {
                    if (liste.ContainsKey(dbtype) == false)
                    {
                        liste.Add(dbtype, new DBClass());
                    }
                }
                return liste[dbtype];
            }
        }        

    }
}
