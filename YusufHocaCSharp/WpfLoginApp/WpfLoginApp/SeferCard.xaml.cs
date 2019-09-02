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
    /// SeferCard.xaml etkileşim mantığı
    /// </summary>
    public partial class SeferCard : UserControl
    {
        
        public SeferCard()
        {
            InitializeComponent();
            DoluKoltukBoya(Sefer_refno);
        }
        public string Sefer_refno { get; set; }
        public string Saat { get; set; }
        public string Istikamet { get; set; }
        public string Fiyat { get; set; }

        /// <summary>
        /// Bilet alma işlemi
        /// </summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            if (b.Background == Brushes.Green)
            {

                MessageBoxResult mbr = MessageBox.Show("Bu koltuğu almak istediğinize emin misiniz", "Bilet Al", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (mbr == MessageBoxResult.Yes)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True");

                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }

                        string query = "EXEC dbo.BiletAl @P1, @P2, @P3";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.CommandType = CommandType.Text;
                        MessageBox.Show(LoginUser.Username);
                        cmd.Parameters.AddWithValue("@P1", LoginUser.Username);
                        cmd.Parameters.AddWithValue("@P2", Convert.ToInt32(Sefer_refno));
                        cmd.Parameters.AddWithValue("@P3", Convert.ToInt32(b.Content));

                        int result = Convert.ToInt32(cmd.ExecuteNonQuery());
                        if (result > 0)
                        {
                            b.Background = Brushes.Red;
                            MessageBox.Show("İşleminiz başarı ile tamamlanmıştır. Hayırlı yolculuklar.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        else
                        {
                            MessageBox.Show("Bir hata oluştu!", "", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            else
            {
                MessageBox.Show("Bu koltuk zaten dolu. Lütfen boş olan(yeşil) koltuk seçiniz.", "", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        /// <summary>
        /// Satin alinmis koltuklari kirmiziya boyar
        /// </summary>
        void DoluKoltukBoya(string Sefer_refno)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True");

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            try
            {
                string query = "SELECT KOLTUK_NO FROM BILET WHERE SEFER_REFNO=@P1";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@P1", Convert.ToInt32(Sefer_refno));

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                MessageBox.Show(dt.Rows.Count.ToString());
                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn column in dt.Columns)
                    {
                        MessageBox.Show(row["KOLTUK_NO"].ToString());
                        object o = spKOLTUKLAR.FindName("k"+Convert.ToString(row["KOLTUK_NO"]));
                        if (o is Button)
                        {
                            Button btn = o as Button;
                            btn.Background = Brushes.Red;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Message()
        {
            MessageBox.Show(Sefer_refno);
        }
    }
}
