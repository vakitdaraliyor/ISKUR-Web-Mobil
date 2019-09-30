using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFTest2.ServiceReference1;

namespace WCFTest2
{
    public partial class Form1 : Form
    {
        WSKategoriClient client = new WSKategoriClient();
        int satirno = -1;
        Genel genel = new Genel("LOG.txt");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            genel.LogOlustur("Load: Uygulama Başlatıldı.");
            GridDoldur();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Seç
            satirno = e.RowIndex;
            if (satirno > -1)
            {
                KategoriGetir(satirno);
            }            
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            // Yeni
            txtKATEGORI_REFNO.Text = "";
            txtKATEGORI_ADI.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kaydet
            try
            {
                if (txtKATEGORI_REFNO.Text != "") // güncelle
                {
                    Kategori k = client.GetKATEGORI(Convert.ToInt32(txtKATEGORI_REFNO.Text));
                    k.KATEGORI_ADI = txtKATEGORI_ADI.Text;
                    client.Update(k);
                }
                else // Yeni kayıt
                {
                    Kategori k = new Kategori();
                    k.KATEGORI_ADI = txtKATEGORI_ADI.Text;
                    client.Save(k);
                }
                GridDoldur();
            }
            catch (Exception hata)
            {
                genel.LogOlustur("Kaydet: " + hata.Message);
                MessageBox.Show("Kayıt yaparken hata oluştu!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Vazgeç
            KategoriGetir(satirno);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Sil
            DialogResult dr = MessageBox.Show("Silmek istediğinize emin misiniz?", "SİL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;

            if (txtKATEGORI_REFNO.Text != "")
            {
                int id = Convert.ToInt32(txtKATEGORI_REFNO.Text);
                try
                {
                    client.Delete(id);
                }
                catch (Exception hata)
                {
                    genel.LogOlustur("Sil: " + hata.Message);
                    MessageBox.Show("Hata" + hata.Message);
                }
                GridDoldur();
            }
        }

        void GridDoldur()
        {
            dataGridView1.DataSource = client.GetAllKATEGORI();
        }

        void KategoriGetir(int satirno)
        {
            txtKATEGORI_REFNO.Text = Convert.ToString(dataGridView1.Rows[satirno].Cells["KATEGORI_REFNO"].Value);
            txtKATEGORI_ADI.Text = Convert.ToString(dataGridView1.Rows[satirno].Cells["KATEGORI_ADI"].Value);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            genel.LogOlustur("Closed: Uygulama Kapatıldı.");
        }
    }
}
