using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfLoginApp
{
    /// <summary>
    /// BiletAl.xaml etkileşim mantığı
    /// </summary>
    public partial class BiletAl : UserControl
    {
        public BiletAl()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True");
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string query = "SELECT DISTINCT NEREDEN FROM dbo.SEFERLER";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    comboNereden.Items.Add(dr["NEREDEN"]);
                }
            }
            catch
            {
                MessageBox.Show("Basarisiz");
            }
        }

        private void NeredenComboChanged(object sender, SelectionChangedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True");
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string query = "SELECT DISTINCT NEREYE FROM dbo.SEFERLER WHERE NEREDEN=@P1";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@P1", comboNereden.SelectedItem.ToString());

                SqlDataReader dr = cmd.ExecuteReader();
                comboNereye.Items.Clear();

                while (dr.Read())
                {
                    comboNereye.Items.Add(dr["NEREYE"]);
                }
            }
            catch
            {
                MessageBox.Show("Basarisiz");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS; Initial Catalog=UserDB; Integrated Security=True");
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string query = "SELECT SEFER_REFNO, NEREDEN, NEREYE, CONVERT(varchar(10), TARIH) AS TARIH, SAAT, FIYAT" +
                               " FROM SEFERLER" +
                               " WHERE NEREDEN=@P1 AND NEREYE=@P2 AND TARIH=@P3 AND KONTENJAN<11" +
                               " ORDER BY SAAT";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@P1", comboNereden.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@P2", comboNereye.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@P3", datePicker.SelectedDate.Value.ToString("MM.dd.yyyy"));

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        SeferCard sc = new SeferCard();
                        foreach (DataColumn column in dt.Columns)
                        {
                            sc.Sefer_refno = row["SEFER_REFNO"].ToString();
                            sc.Saat = row["SAAT"].ToString();
                            sc.Istikamet = row["NEREDEN"].ToString() + " - " + row["NEREYE"].ToString();
                            sc.Fiyat = row["FIYAT"].ToString().Substring(0,5) + " TL";
                        }
                        UygulamaKontrol.SeferEkle(spSEFERLER, sc);
                    }              
                }
                else
                {
                    MessageBox.Show("Aradığınız kriterde sefer yok.", "UYARI", MessageBoxButton.OK, MessageBoxImage.Information);
                }

                cmd.Dispose();
                adapter.Dispose();
                con.Close();
                //dtGridSeferler.ItemsSource = dt.DefaultView;
            }
            catch
            {

                MessageBox.Show("Basarisiz");
            }
        }
        
    }
}
