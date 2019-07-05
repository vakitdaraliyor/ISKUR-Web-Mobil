using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Net
{
    class DBClass
    {
        SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS; initial catalog=İŞKUR; user id=sa; password=1234");

        public DataTable TableGetir(string sql, params SqlParameter[] prms)
        {
            // Komut oluşturup connection oluşturuyoruz.
            SqlCommand command = new SqlCommand(sql, connection);

            if (prms != null) command.Parameters.AddRange(prms);

            // Veri taşıma işlemlerini yapan bir adapter oluşturuyoruz.
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            adapter.Fill(dt); // sql cümlesini çalıştırıp dt tablosuna doldur
            return dt;
        }

        public void SqlCalistir(string sql, params SqlParameter[] prms)
        {

            SqlCommand cmd = new SqlCommand(sql, connection);

            if (prms != null) cmd.Parameters.AddRange(prms);
            if (connection.State == ConnectionState.Closed) connection.Open();

            cmd.ExecuteNonQuery(); // INSERT UPDATE DELETE komutlarını çalıştırır                

            connection.Close();
        }


    }
}
