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
                cmd.Parameters.AddWithValue("@P1", comboNereden.SelectedItem);

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
    }
}
