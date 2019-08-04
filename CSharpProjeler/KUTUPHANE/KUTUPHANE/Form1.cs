using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KUTUPHANE
{
    public partial class Form1 : Form
    {
        KUTUPHANEEntities entities = new KUTUPHANEEntities();
        int satir = -1;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form yüklenirken datagrid e verileri doldurur
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            GridDoldur();
            
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = false;
            timer1.Enabled = true;
        }

        /// <summary>
        /// Datagrid te secili satirin bilgilerini textbox lara doldurur
        /// </summary>
        private void DataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            satir = e.RowIndex;
            if (satir > -1)
            {
                txtADI.Text = dataGridView1.Rows[satir].Cells["ADI"].Value.ToString();
                txtISBN.Text = dataGridView1.Rows[satir].Cells["ISBN"].Value.ToString();
                txtKITAP_REFNO.Text = dataGridView1.Rows[satir].Cells["KITAP_REFNO"].Value.ToString();                
                txtOZET.Text = Convert.ToString(dataGridView1.Rows[satir].Cells["OZET"].Value);
                txtYAYIN_EVI.Text = dataGridView1.Rows[satir].Cells["YAYIN_EVI"].Value.ToString();
                txtYAZARI.Text = dataGridView1.Rows[satir].Cells["YAZARI"].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[satir].Cells["BASIM_TARIHI"].Value.ToString();
            }

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = true;
        }

        /// <summary>
        /// Textboxlarin icini bosaltir
        /// </summary>
        private void Button1_Click(object sender, EventArgs e)
        {
            // Yeni
            txtADI.Text = "";
            txtISBN.Text = "";
            txtKITAP_REFNO.Text = "";
            txtOZET.Text = "";
            txtYAYIN_EVI.Text = "";
            txtYAZARI.Text = "";
            dateTimePicker1.Text = "";

            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
        }

        /// <summary>
        /// Bir onceki secili satirin bilgilerini ilgili alanlara doldurur
        /// </summary>
        private void Button3_Click(object sender, EventArgs e)
        {
            // Vazgeç
            if (satir > -1)
            {
                txtADI.Text = dataGridView1.Rows[satir].Cells["ADI"].Value.ToString();
                txtISBN.Text = dataGridView1.Rows[satir].Cells["ISBN"].Value.ToString();
                txtKITAP_REFNO.Text = dataGridView1.Rows[satir].Cells["KITAP_REFNO"].Value.ToString();
                txtOZET.Text = Convert.ToString(dataGridView1.Rows[satir].Cells["OZET"].Value);
                txtYAYIN_EVI.Text = dataGridView1.Rows[satir].Cells["YAYIN_EVI"].Value.ToString();
                txtYAZARI.Text = dataGridView1.Rows[satir].Cells["YAZARI"].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[satir].Cells["BASIM_TARIHI"].Value.ToString();
            }

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = true;
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            // Kaydet
            int checkNumeric;
            string mesaj = "";
            if(txtADI.Text == "")
            {
                mesaj = "KİTAP ADI boş bırakılamaz!\r\n";
            }
            if (txtISBN.Text == "" || txtISBN.Text.Length != 13 || int.TryParse(txtISBN.Text, out checkNumeric))
            {
                mesaj += "ISBN boş bırakılamaz 13 haneli ve numerik olmalıdır!\r\n";
            }
            if (txtYAYIN_EVI.Text == "")
            {
                mesaj += "YAYIN EVİ boş bırakılamaz!\r\n";
            }
            if (txtYAZARI.Text == "")
            {
                mesaj += "KİTAP YAZARI boş bırakılamaz!\r\n";
            }

            if(mesaj != "")
            {
                FrmUYARI uyarı = new FrmUYARI();
                uyarı.textBox1.Text = mesaj;
                uyarı.ShowDialog();
                return;
            }
            
            KITAP k = new KITAP();
            if(txtKITAP_REFNO.Text != "")
            {
                k = entities.KITAPs.Find(Convert.ToInt32(txtKITAP_REFNO.Text));
                k.ADI = txtADI.Text;
                k.BASIM_TARIHI = dateTimePicker1.Value;
                k.ISBN = txtISBN.Text;
                k.OZET = txtOZET.Text;
                k.YAYIN_EVI = txtYAYIN_EVI.Text;
                k.YAZARI = txtYAZARI.Text;
                int returnValue = entities.SaveChanges();
                if (returnValue > 0)
                {
                    MessageBox.Show("Başarıyla güncellendi.");
                }
                else
                {
                    MessageBox.Show("Hata!Güncelleme yapılamadı.");
                }
            }
            else
            {
                k.ADI = txtADI.Text;
                k.BASIM_TARIHI = dateTimePicker1.Value;
                k.ISBN = txtISBN.Text;
                k.OZET = txtOZET.Text;
                k.YAYIN_EVI = txtYAYIN_EVI.Text;
                k.YAZARI = txtYAZARI.Text;
                entities.KITAPs.Add(k);
                int returnValue = entities.SaveChanges();
                if (returnValue > 0)
                {
                    MessageBox.Show("Başarıyla eklendi.");
                }
                else
                {
                    MessageBox.Show("Hata!Ekleme yapılamadı.");
                }
            }

            GridDoldur();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // Sil
            DialogResult dr = MessageBox.Show("Silmek istediğinize emin misiniz?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;
            if (txtKITAP_REFNO.Text != "")
            {                
                KITAP k = new KITAP();
                k = entities.KITAPs.Find(Convert.ToInt32(txtKITAP_REFNO.Text));
                entities.KITAPs.Remove(k);
                entities.SaveChanges();
            }
            GridDoldur();
        }

        void GridDoldur()
        {
            var list = (from kitap in entities.KITAPs
                        select new
                        {
                            kitap.KITAP_REFNO,
                            kitap.ADI,
                            kitap.YAZARI,
                            kitap.ISBN,
                            kitap.BASIM_TARIHI,
                            kitap.YAYIN_EVI,
                            kitap.OZET
                        }).ToList();
            dataGridView1.DataSource = list;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity + 0.1;
        }

        private void KitapİşlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kitap Islemleri
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void ÜyeİşlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUYE uye = new FrmUYE();
            uye.ShowDialog();
        }

        private void ÖdünçKitapİşlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmODUNCKITAP oduncKitap = new FrmODUNCKITAP();
            oduncKitap.ShowDialog();
        }

        private void KitapListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKITAPLAR kitaplar = new FrmKITAPLAR();
            kitaplar.ShowDialog();
        }

        private void ÜyeListesiRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUYELER uyeler = new FrmUYELER();
            uyeler.ShowDialog();
        }
    }
}
