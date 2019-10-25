using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XAMARINWEBAPI
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            GetAll();
        }

        void GetAll()
        {
            HttpClient client = new HttpClient();
            Task<HttpResponseMessage> response = client.GetAsync("http://172.25.3.154/webapiblog/api/Kullanici/");
            Task<string> jsonliste = response.Result.Content.ReadAsStringAsync();

            List<KULLANICI> liste = JsonConvert.DeserializeObject<List<KULLANICI>>(jsonliste.Result);

            listekullanici.ItemsSource = null;
            listekullanici.ItemsSource = liste;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // YENI
            KULLANICI_REFNO.Text = "";
            KULLANICI_ADI.Text = "";
            PAROLA.Text = "";
            DURUMU.Text = "";
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            // KAYDET
            KULLANICI k = new KULLANICI();
            k.DURUMU = Convert.ToBoolean(DURUMU.Text);
            k.KULLANICI_ADI = KULLANICI_ADI.Text;
            k.PAROLA = PAROLA.Text;

            HttpClient client = new HttpClient();

            if (KULLANICI_REFNO.Text == "") // Insert(Post)
            {
                string jkullanici = JsonConvert.SerializeObject(k);

                StringContent jsonkullanici = new StringContent(jkullanici, Encoding.UTF8, "application/json");
                Task<HttpResponseMessage> response = client.PostAsync("http://172.25.3.154/webapiblog/api/Kullanici/", jsonkullanici);

                response.Wait();
            }
            else // Update(Put)
            {
                k.KULLANICI_REFNO = Convert.ToInt32(KULLANICI_REFNO.Text);
                string jkullanici = JsonConvert.SerializeObject(k);

                StringContent jsonkullanici = new StringContent(jkullanici, Encoding.UTF8, "application/json");
                Task<HttpResponseMessage> response = client.PutAsync("http://172.25.3.154/webapiblog/api/Kullanici/" + k.KULLANICI_REFNO, jsonkullanici);

                response.Wait();
            }

            GetAll();

        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            // VAZGEC
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            // SIL
            //Task<bool> sonuc1 = DisplayAlert("DİKKAT", "Silmek istediğinize emin misiniz?", "Evet", "Hayır");
            //sonuc1.Wait();
            bool sonuc1 = true;

            if (sonuc1 == true)
            {
                if (KULLANICI_REFNO.Text != "")
                {
                    HttpClient client = new HttpClient();

                    Task<HttpResponseMessage> response = client.DeleteAsync("http://172.25.3.154/webapiblog/api/Kullanici/" + KULLANICI_REFNO.Text);
                    response.Wait();
                    GetAll();
                }                
            }
        }

        private void listekullanici_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            KULLANICI k = e.SelectedItem as KULLANICI;
            int kullanici_refno = Convert.ToInt32(k.KULLANICI_REFNO);
            KayitGoster(kullanici_refno);
        }

        void KayitGoster(int kullanici_refno)
        {
            HttpClient client = new HttpClient();

            Task<HttpResponseMessage> response = client.GetAsync("http://172.25.3.154/webapiblog/api/Kullanici/" + kullanici_refno);
            Task<string> jsonkullanici = response.Result.Content.ReadAsStringAsync();

            KULLANICI kullanici = JsonConvert.DeserializeObject<KULLANICI>(jsonkullanici.Result);

            KULLANICI_REFNO.Text = Convert.ToString(kullanici.KULLANICI_REFNO);
            KULLANICI_ADI.Text = kullanici.KULLANICI_ADI;
            PAROLA.Text = kullanici.PAROLA;
            DURUMU.Text = Convert.ToString(kullanici.DURUMU);

        }

    }
}
