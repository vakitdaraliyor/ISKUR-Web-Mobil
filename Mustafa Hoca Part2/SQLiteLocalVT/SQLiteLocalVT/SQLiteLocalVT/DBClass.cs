using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SQLite;
using SQLiteLocalVT.Model;

namespace SQLiteLocalVT
{
    public class DBClass
    {
        private static SQLiteConnection con;

        public static SQLiteConnection GetConnection(string dbname="common.db")
        {
            if (con == null)
            {
                string connectionstring = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), dbname);
                con = new SQLiteConnection(connectionstring);
            }
            return con;
        }

        public void CreateTable()
        {
            DBClass.con.CreateTable<Kisi>();
        }

        public void DropTable()
        {
            DBClass.con.DropTable<Kisi>();
        }

        public void Insert(Kisi k)
        {
            DBClass.con.Insert(k); 
        }

        public void Update(Kisi k)
        {
            DBClass.con.Update(k);
        }

        public void Delete(Kisi k)
        {
            DBClass.con.Delete(k);
        }

        public List<Kisi> GetTable()
        {
            return DBClass.con.Table<Kisi>().ToList();
        }

    }
}
