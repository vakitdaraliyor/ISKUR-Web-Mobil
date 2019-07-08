using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenci
{
    class DBClass
    {

        SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS; initial catalog=OGRENCI; user id=sa; password=1234");

        public DataTable TabloGetir(string sql, params SqlParameter[] prms)
        {
            SqlCommand command = new SqlCommand(sql, connection);

            if (prms != null) command.Parameters.AddRange(prms);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public void SqlCalistir(string sql, params SqlParameter[] prms)
        {
            SqlCommand cmd = new SqlCommand(sql, connection);

            if (prms != null) cmd.Parameters.AddRange(prms);
            if (connection.State == ConnectionState.Closed) connection.Open();

            cmd.ExecuteNonQuery();

            connection.Close();
        }
    }
}
