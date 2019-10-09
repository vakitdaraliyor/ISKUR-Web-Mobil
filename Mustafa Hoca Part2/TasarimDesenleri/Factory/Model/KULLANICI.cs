using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Model
{
    class KULLANICI
    {
        public static DataTable GetKullanicilar()
        {
            DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn("Adi", typeof(string));
            DataColumn dc2 = new DataColumn("Soyadi", typeof(string));

            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);

            DataRow dr1 = dt.NewRow();
            dr1["Adi"] = "Mustafa";
            dr1["Soyadi"] = "Celikcan";

            DataRow dr2 = dt.NewRow();
            dr2["Adi"] = "Osman";
            dr2["Soyadi"] = "SAVAS";

            DataRow dr3 = dt.NewRow();
            dr3["Adi"] = "Ramazan";
            dr3["Soyadi"] = "MERCAN";

            dt.Rows.Add(dr1);
            dt.Rows.Add(dr2);
            dt.Rows.Add(dr3);

            return dt;
        }
    }
}
