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
        SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS; initial catalog=PRATIK; user id=sa; password=1234; MultipleActiveResultSets=true"); //  MultipleActiveResultSets=true connection kapatmadan sorgu yapmayı sağlar

        public DataTable TableGetir(string sql, bool WithSchema = false, params SqlParameter[] prms)
        {
            // Komut oluşturup connection oluşturuyoruz.
            SqlCommand command = new SqlCommand(sql, connection);

            if (prms != null) command.Parameters.AddRange(prms);

            // Veri taşıma işlemlerini yapan bir adapter oluşturuyoruz.
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            adapter.Fill(dt); // sql cümlesini çalıştırıp dt tablosuna doldur. Satirlari dt ye ekler
            if(WithSchema == true)
            {
                adapter.FillSchema(dt, SchemaType.Source); // table yapisini PK vb dt ye ekler
            }
            command.Parameters.Clear();
            return dt;
        }

        public void UpdateTable(string sql, DataTable dt, params SqlParameter[] prms)
        {
            // Komut oluşturup connection oluşturuyoruz.
            SqlCommand command = new SqlCommand(sql, connection);

            if (prms != null) command.Parameters.AddRange(prms);

            // Veri taşıma işlemlerini yapan bir adapter oluşturuyoruz.
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            // INSERT UPDATE DELETE Commandlerini SELECT Commandıne bakarak otamatik build eder.
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            adapter.InsertCommand = commandBuilder.GetInsertCommand();
            adapter.DeleteCommand = commandBuilder.GetDeleteCommand();
            adapter.UpdateCommand = commandBuilder.GetUpdateCommand();

            // Data table daki değişiklikleri veri tabanına kaydediyoruz.
            adapter.Update(dt);
        }    

        public void SqlCalistir(string sql, params SqlParameter[] prms)
        {
            SqlCommand cmd = new SqlCommand(sql, connection);

            if (prms != null) cmd.Parameters.AddRange(prms);
            if (connection.State == ConnectionState.Closed) connection.Open();

            cmd.ExecuteNonQuery(); // INSERT UPDATE DELETE komutlarını çalıştırır                

            connection.Close();
        }

        public object TekDegerGetir(string sql, params SqlParameter[] prms)
        {
            object sonuc = null; SqlCommand cmd = new SqlCommand(sql, connection);

            if (prms != null) cmd.Parameters.AddRange(prms);
            if (connection.State == ConnectionState.Closed) connection.Open();

            sonuc = cmd.ExecuteScalar();
            connection.Close();

            return sonuc;
        }

        public SqlDataReader VeriOkuyucu(string sql, params SqlParameter[] prms)
        {
            SqlDataReader okuyucu = null;
            SqlCommand command = new SqlCommand(sql, connection);

            if (prms != null) command.Parameters.AddRange(prms);

            if (connection.State == ConnectionState.Closed) connection.Open();

            okuyucu = command.ExecuteReader();// connection ı kapatmazsan => Öncelikle kapatılması gereken açık bir DataReader zaten var.
            return okuyucu;
        }
    }
}
