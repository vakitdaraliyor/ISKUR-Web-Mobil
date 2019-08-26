using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfLoginApp
{
    /// <summary>
    /// Register.xaml etkileşim mantığı
    /// </summary>
    public partial class Register : Window
    {
        List<Resim> resimler = new List<Resim>();
        Random r = new Random();
        BitmapImage bi3 = new BitmapImage();

        public Register()
        {
            InitializeComponent();
            resimler.Add(new Resim(){ path = "resimler/verify.jpg", value = "123sad" });
            resimler.Add(new Resim(){ path = "resimler/verify2.jpg", value = "qwe567" });

            LoadImage();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {           

            lblUsername.Content = "";
            lblName.Content = "";
            lblPassword.Content = "";
            lblPasswordAgain.Content = "";

            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True");
            bool isEmpty = true;
            bool isEqual = true;
            bool isVerify = false;

            try
            {

                // ---------------- Connection olustur ----------------
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                // ---------------- Alanlar bos mu dolu mu kontrol et ----------------
                if (txtRegisterUsername.Text == "")
                {
                    lblUsername.Content = "Must be field";
                    isEmpty = false;
                }
                if (txtRegisterName.Text == "")
                {
                    lblName.Content = "Must be field";
                    isEmpty = false;
                }
                else if (Regex.IsMatch(txtRegisterName.Text, @"^[a-zA-Z]+$") == false)
                {
                    lblName.Content = "Must only letter";
                    isEmpty = false;
                }
                if (txtRegisterPassword.Password == "")
                {                    
                    lblPassword.Content = "Must be field";
                    isEmpty = false;
                }
                if (txtRegisterPasswordAgain.Password == "")
                {                    
                    lblPasswordAgain.Content = "Must be field";
                    isEmpty = false;
                }
                if (txtRegisterPassword.Password != txtRegisterPasswordAgain.Password && txtRegisterPasswordAgain.Password != "")
                {                    
                    lblPasswordAgain.Content = "Password not same!";
                    isEqual = false;
                }
                

                // ---------------- Her şey okey se kulliniciyi ekle ---------------- 
                if (isEqual == true && isEmpty == true)
                {
                    string query = "EXEC dbo.AddUser @P1, @P2, @P3";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@P1", txtRegisterUsername.Text);
                    cmd.Parameters.AddWithValue("@P2", txtRegisterUsername.Text);
                    cmd.Parameters.AddWithValue("@P3", txtRegisterPassword.Password);

                    int result = Convert.ToInt32(cmd.ExecuteNonQuery());
                    if (result > 0)
                    {
                        MessageBox.Show("Tebrikler Kaydoldunuz.", "Durum", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ayni Username Mevcut!", "Durum", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }                

            }
            catch (Exception ex)
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
            LoadImage();
        }

        void LoadImage()
        {
            bi3.BeginInit();
            bi3.UriSource = new Uri(resimler[r.Next(0, 2)].path, UriKind.Relative);
            bi3.EndInit();
            imgResim.Source = bi3;
        }
    }
}
