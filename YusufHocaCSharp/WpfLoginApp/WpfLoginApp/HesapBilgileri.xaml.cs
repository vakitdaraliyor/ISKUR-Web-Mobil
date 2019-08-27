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
    /// HesapBilgileri.xaml etkileşim mantığı
    /// </summary>
    public partial class HesapBilgileri : UserControl
    {
        public HesapBilgileri()
        {            
            InitializeComponent();
            txtINFO_USERNAME.Text = LoginUser.Username;
            txtINFO_NAME.Text = LoginUser.Name;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool isChange = false;
            bool executeQuery = true;
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True");

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string updateQuery = "UPDATE dbo.USERS SET USERNAME=@P1, NAME=@P2, PASSWORD=@P3 WHERE USERNAME=@P1";
                SqlCommand cmd = new SqlCommand(updateQuery, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@P1", txtINFO_USERNAME.Text);
                cmd.Parameters.AddWithValue("@P2", txtINFO_NAME.Text);

                if (txtINFO_OLDPASSWORD.Password != "")
                {
                    if (txtINFO_OLDPASSWORD.Password == LoginUser.Password && txtINFO_NEWPASSWORD.Password == txtINFO_AGAINPASSWORD.Password)
                    {
                        cmd.Parameters.AddWithValue("@P3", txtINFO_NEWPASSWORD.Password);
                    }
                    else
                    {
                        executeQuery = false;
                    }
                }
                else
                {
                    cmd.Parameters.AddWithValue("@P3", LoginUser.Password);
                }

                if (executeQuery)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Basariyla güncellendi!");
                    LoginUser.Password = txtINFO_NEWPASSWORD.Password;
                }
                else
                {
                    MessageBox.Show("Şifre yanlis girilmiştir");
                }

            }
            catch
            {
                MessageBox.Show("Veri Tabanina Baglanilamadi!", "HATA", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

    }
}
