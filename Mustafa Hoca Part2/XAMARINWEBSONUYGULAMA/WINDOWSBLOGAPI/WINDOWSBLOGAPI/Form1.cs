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

namespace WINDOWSBLOGAPI
{
    public partial class Form1 : Form
    {
        int satir = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        void GetAll()
        {
            HttpClient client = new HttpClient();
            Task<HttpResponseMessage> response = client.GetAsync("http://localhost:56782/api/Kullanici/");
            Task<string> jsonliste = response.Result.Content.ReadAsStringAsync();

            List<KULLANICI> liste = JsonConvert.DeserializeObject<List<KULLANICI>>(jsonliste.Result);
            dataGridView1.DataSource = liste;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            satir = e.RowIndex;
            if (satir > -1)
            {
                KayitGoster();
            }
        }

        void KayitGoster()
        {
            HttpClient client = new HttpClient();

            string kullanici_refno = dataGridView1.Rows[satir].Cells["KULLANICI_REFNO"].Value.ToString();
            Task<HttpResponseMessage> response = client.GetAsync("http://localhost:56782/api/Kullanici/" + kullanici_refno);
            Task<string> jsonkullanici = response.Result.Content.ReadAsStringAsync();

            KULLANICI kullanici = JsonConvert.DeserializeObject<KULLANICI>(jsonkullanici.Result);

            txtKULLANICI_REFNO.Text = Convert.ToString(kullanici.KULLANICI_REFNO);
            txtKULLANICI_ADI.Text = kullanici.KULLANICI_ADI;
            txtPAROLA.Text = kullanici.PAROLA;
            txtDURUMU.Text = Convert.ToString(kullanici.DURUMU);
        
        }

        private void Yeni_Click(object sender, EventArgs e)
        {
            // Yeni
            txtKULLANICI_REFNO.Text = "";
            txtKULLANICI_ADI.Text = "";
            txtPAROLA.Text = "";
            txtDURUMU.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Sil
            HttpClient client = new HttpClient();

            string kullanici_refno = dataGridView1.Rows[satir].Cells["KULLANICI_REFNO"].Value.ToString();
            Task<HttpResponseMessage> response = client.DeleteAsync("http://localhost:56782/api/Kullanici/" + kullanici_refno);
            response.Wait();
            GetAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kaydet
            KULLANICI k = new KULLANICI();
            k.DURUMU = Convert.ToBoolean(txtDURUMU.Text);
            k.KULLANICI_ADI = txtKULLANICI_ADI.Text;
            k.PAROLA = txtPAROLA.Text;

            HttpClient client = new HttpClient();

            if (txtKULLANICI_REFNO.Text == "") // Insert(Post)
            {                
                string jkullanici = JsonConvert.SerializeObject(k);

                StringContent jsonkullanici = new StringContent(jkullanici, Encoding.UTF8, "application/json");
                Task<HttpResponseMessage> response = client.PostAsync("http://localhost:56782/api/Kullanici/", jsonkullanici);

                response.Wait();
            }
            else // Update(Put)
            {
                k.KULLANICI_REFNO = Convert.ToInt32(txtKULLANICI_REFNO.Text);
                string jkullanici = JsonConvert.SerializeObject(k);

                StringContent jsonkullanici = new StringContent(jkullanici, Encoding.UTF8, "application/json");
                Task<HttpResponseMessage> response = client.PutAsync("http://localhost:56782/api/Kullanici/" + k.KULLANICI_REFNO, jsonkullanici);

                response.Wait();
            }

            GetAll();
        }
    }
}
