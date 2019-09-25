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

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Ben tıkladım baska bir iş yapmaya basladım. Daha sonra gelen veriyi kullanabilirim.
            Task<HttpResponseMessage> response = client.GetAsync(txtADRES.Text);

            // Bu şekilde göndermezsek default olarak json formatında getirir
            // client.DefaultRequestHeaders.Add("Accept", "application/json");
            Task<string> icerik = response.Result.Content.ReadAsStringAsync();

            YONETICI y = JsonConvert.DeserializeObject<YONETICI>(icerik.Result);

            txtSONUC.Text = icerik.Result;

            txtYONETICI_REFNO.Text = Convert.ToString(y.YONETICI_REFNO);
            txtKULLANICI_ADI.Text = y.KULLANICI_ADI;
            txtSIFRESI.Text = y.SIFRESI;
            txtDURUMU.Text = Convert.ToString(y.DURUMU);
        }
    }
}
