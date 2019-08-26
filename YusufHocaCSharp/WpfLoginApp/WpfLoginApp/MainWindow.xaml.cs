using System;
using System.Collections.Generic;
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
using System.Data;
using System.Data.SqlClient;

namespace WpfLoginApp
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True");

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string query = "SELECT COUNT(*) FROM dbo.USERS WHERE USERNAME=@P1 AND PASSWORD=@P2";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@P1", txtUsername.Text);
                cmd.Parameters.AddWithValue("@P2", txtPassword.Password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 1)
                {
                    string selectName = "SELECT NAME FROM dbo.USERS WHERE USERNAME=@P1";
                    SqlCommand cmdName = new SqlCommand(selectName, con);
                    cmdName.CommandType = CommandType.Text;
                    cmdName.Parameters.AddWithValue("@P1", txtUsername.Text);

                    SqlDataReader dr = cmdName.ExecuteReader();
                    while (dr.Read())
                    {
                        LoginUser.Name = Convert.ToString(dr["NAME"]);
                    }

                    MyAccount ma = new MyAccount();
                    ma.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username veya sifre yanliş", "HATA", MessageBoxButton.OK, MessageBoxImage.Warning);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Register r = new Register();
            r.Show();
            this.Close();
        }
    }
}
