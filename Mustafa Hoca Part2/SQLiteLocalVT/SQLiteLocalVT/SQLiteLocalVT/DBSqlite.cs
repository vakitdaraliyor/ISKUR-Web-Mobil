using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace SQLiteLocalVT
{
    class DBSqlite
    {
        private static SQLiteAsyncConnection con;

        private DBSqlite()
        {

        }

        public static SQLiteAsyncConnection GetConnection(string dbname = "common.db")
        {
            if (con == null)
            {
                string connectionstring = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), dbname);
                con = new SQLiteAsyncConnection(connectionstring);
            }
            return con;
        }
    }

    public class TableProcess<T> where T : new()
    {
        SQLiteAsyncConnection db;
        public TableProcess(SQLiteAsyncConnection _db)
        {
            db = _db;
        }

        public async void CreateAsyncTable()
        {
            await db.CreateTableAsync<T>();
        }

        public async void DropAsyncTable()
        {
            await db.DropTableAsync<T>();
        }
    }

    public class SQLiteRepository<T> where T : new()
    {
        SQLiteAsyncConnection db;
        public SQLiteRepository(SQLiteAsyncConnection _db)
        {
            db = _db;
        }

        public void InsertAsync(T kayit)
        {
            db.InsertAsync(kayit);
        }

        public void UpdateAsync(T kayit)
        {
            db.UpdateAsync(kayit);
        }

        public void DeleteAsync(T kayit)
        {
            db.DeleteAsync(kayit);
        }
        public Task<List<T>> GetTableAsync()
        {
            return db.Table<T>().ToListAsync();
        }
    }

}
