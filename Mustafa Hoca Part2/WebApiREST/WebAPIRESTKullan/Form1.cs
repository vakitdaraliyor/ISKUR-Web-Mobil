using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebAPIRESTKullan
{
    public partial class Form1 : Form
    {
        HttpClient client = new HttpClient();
        int satirno = -1;

        public Form1()
        {
            InitializeComponent();
        }

        /*private void Button1_Click(object sender, EventArgs e)
        {
            //Ben tıkladım baska bir iş yapmaya basladım. Daha sonra gelen veriyi kullanabilirim.
            //Task<HttpResponseMessage> response = client.GetAsync(txtADRES.Text);

            //Bu şekilde göndermezsek default olarak json formatında getirir
            //client.DefaultRequestHeaders.Add("Accept", "application/json");
            //Task<string> icerik = response.Result.Content.ReadAsStringAsync();

            //YONETICI y = JsonConvert.DeserializeObject<YONETICI>(icerik.Result);

            //txtSONUC.Text = icerik.Result;

            //txtYONETICI_REFNO.Text = Convert.ToString(y.YONETICI_REFNO);
            //txtKULLANICI_ADI.Text = y.KULLANICI_ADI;
            //txtSIFRESI.Text = y.SIFRESI;
            //txtDURUMU.Text = Convert.ToString(y.DURUMU);
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            YoneticiGetir();
        }        

        private void DataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                satirno = e.RowIndex;
                string id = dataGridView1.Rows[satirno].Cells["YONETICI_REFNO"].Value.ToString();
                KayitGoster(id);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            /*if (txtKULLANICI_ADI.Text.Trim() == "")
            {
                MessageBox.Show("Kullanıcı adı giriniz");
                return;
            }

            if (txtSIFRESI.Text.Trim() == "")
            {
                MessageBox.Show("Şifre giriniz");
                return;
            }

            if (txtDURUMU.Text.Trim() == "")
            {
                MessageBox.Show("Durumu giriniz");
                return;
            }*/


            // KAYDET
            if (txtYONETICI_REFNO.Text == "") // yeni kayit
            {
                YONETICI y = new YONETICI();
                y.DURUMU = Convert.ToBoolean(txtDURUMU.Text);
                y.KULLANICI_ADI = txtKULLANICI_ADI.Text;
                y.SIFRESI = txtSIFRESI.Text;

                string jsonyonetici = JsonConvert.SerializeObject(y);

                HttpContent icerik = new StringContent(jsonyonetici, Encoding.UTF8, "application/json");
                Task<HttpResponseMessage> response = client.PostAsync("http://localhost:51895/api/YONETICI", icerik);

                Task<string> sonuc = response.Result.Content.ReadAsStringAsync();

                MessageBox.Show(sonuc.Result);
            }
            else // güncelle
            {
                YONETICI y = new YONETICI();
                y.YONETICI_REFNO = Convert.ToInt32(txtYONETICI_REFNO.Text);
                y.DURUMU = Convert.ToBoolean(txtDURUMU.Text);
                y.KULLANICI_ADI = txtKULLANICI_ADI.Text;
                y.SIFRESI = txtSIFRESI.Text;

                string jsonyonetici = JsonConvert.SerializeObject(y);

                HttpContent icerik = new StringContent(jsonyonetici, Encoding.UTF8, "application/json");
                Task<HttpResponseMessage> response = client.PutAsync("http://localhost:51895/api/YONETICI", icerik);

                Task<string> sonuc = response.Result.Content.ReadAsStringAsync();

                MessageBox.Show(sonuc.Result);
            }

            YoneticiGetir();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Yeni
            txtYONETICI_REFNO.Text = "";
            txtDURUMU.Text = "";
            txtKULLANICI_ADI.Text = "";
            txtSIFRESI.Text = "";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // Vazgeç
            string id = dataGridView1.Rows[satirno].Cells["YONETICI_REFNO"].Value.ToString();
            KayitGoster(id);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Silmek istediğinize emin misiniz?", "SİL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return; 

            // Sil
            if (txtYONETICI_REFNO.Text != "")
            {
                string id = dataGridView1.Rows[satirno].Cells["YONETICI_REFNO"].Value.ToString();
                Task<HttpResponseMessage> response = client.DeleteAsync("http://localhost:51895/api/YONETICI/" + id);
                response.Wait();

                Task<string> sonuc = response.Result.Content.ReadAsStringAsync();

                MessageBox.Show(sonuc.Result);
            }
            YoneticiGetir();
        }

        void YoneticiGetir()
        {
            Task<HttpResponseMessage> response = client.GetAsync("http://localhost:51895/api/YONETICI?arama=");

            //Bu şekilde göndermezsek default olarak json formatında getirir
            //client.DefaultRequestHeaders.Add("Accept", "application/json");
            Task<string> icerik = response.Result.Content.ReadAsStringAsync();

            List<YONETICI> liste = JsonConvert.DeserializeObject<List<YONETICI>>(icerik.Result);
            dataGridView1.DataSource = liste;
        }

        void KayitGoster(string id)
        {
            Task<HttpResponseMessage> response = client.GetAsync("http://localhost:51895/api/YONETICI/" + id);
            Task<string> icerik = response.Result.Content.ReadAsStringAsync();
            YONETICI y = JsonConvert.DeserializeObject<YONETICI>(icerik.Result);

            txtDURUMU.Text = Convert.ToString(y.DURUMU);
            txtKULLANICI_ADI.Text = y.KULLANICI_ADI;
            txtSIFRESI.Text = y.SIFRESI;
            txtYONETICI_REFNO.Text = Convert.ToString(y.YONETICI_REFNO);
        }
    }
}
