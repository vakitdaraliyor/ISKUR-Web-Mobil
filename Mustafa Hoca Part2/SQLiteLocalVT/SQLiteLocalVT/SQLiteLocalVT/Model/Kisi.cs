using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SQLiteLocalVT.Model
{
    public class Kisi
    {
        [PrimaryKey, AutoIncrement]
        public int KisiId { get; set; }
        public string AdiSoyadi { get; set; }
        public string Resim { get; set; }
    }
}
