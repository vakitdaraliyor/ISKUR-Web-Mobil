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
    public partial class FrmUYE : Form
    {
        KUTUPHANEEntities entities = new KUTUPHANEEntities();
        int satir = -1;

        public FrmUYE()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form yüklenirken datagrid e verileri doldurur
        /// </summary>
        private void FrmUYE_Load(object sender, EventArgs e)
        {
            GridDoldur();

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        /// <summary>
        /// Datagrid te secili satirin bilgilerini ilgili alanlara doldurur
        /// </summary>
        private void DataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            satir = e.RowIndex;
            if (satir > -1)
            {
                txtACIKLAMA.Text = Convert.ToString(dataGridView1.Rows[satir].Cells["ACIKLAMA"].Value);
                txtADI_SOYADI.Text = Convert.ToString(dataGridView1.Rows[satir].Cells["ADI_SOYADI"].Value);
                txtADRES.Text = Convert.ToString(dataGridView1.Rows[satir].Cells["ADRES"].Value);
                txtEMAIL.Text = Convert.ToString(dataGridView1.Rows[satir].Cells["EMAIL"].Value);
                txtTELEFON.Text = Convert.ToString(dataGridView1.Rows[satir].Cells["TELEFON"].Value);
                txtUYE_REFNO.Text = Convert.ToString(dataGridView1.Rows[satir].Cells["UYE_REFNO"].Value);
                dateTimePicker1.Text = Convert.ToString(dataGridView1.Rows[satir].Cells["EKLEME_TARIHI"].Value);
                if(Convert.ToBoolean(dataGridView1.Rows[satir].Cells["DURUMU"].Value) == true)
                {
                    comboDURUMU.SelectedItem = "Aktif";
                }
                else
                {
                    comboDURUMU.SelectedItem = "Pasif";
                }

                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = false;
                button4.Enabled = true;

            }
        }

        /// <summary>
        /// Alanlarin icini bosaltir
        /// </summary>
        private void Button1_Click(object sender, EventArgs e)
        {
            // Yeni
            txtACIKLAMA.Text = "";
            txtADI_SOYADI.Text = "";
            txtADRES.Text = "";
            txtEMAIL.Text = "";
            txtTELEFON.Text = "";
            txtUYE_REFNO.Text = "";
            dateTimePicker1.Text = "";
            comboDURUMU.SelectedIndex = -1;

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
                txtACIKLAMA.Text = dataGridView1.Rows[satir].Cells["ACIKLAMA"].Value.ToString();
                txtADI_SOYADI.Text = dataGridView1.Rows[satir].Cells["ADI_SOYADI"].Value.ToString();
                txtADRES.Text = dataGridView1.Rows[satir].Cells["ADRES"].Value.ToString();
                txtEMAIL.Text = dataGridView1.Rows[satir].Cells["EMAIL"].Value.ToString();
                txtTELEFON.Text = dataGridView1.Rows[satir].Cells["TELEFON"].Value.ToString();
                txtUYE_REFNO.Text = dataGridView1.Rows[satir].Cells["UYE_REFNO"].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[satir].Cells["EKLEME_TARIHI"].Value.ToString();
                if (Convert.ToBoolean(dataGridView1.Rows[satir].Cells["DURUMU"].Value) == true)
                {
                    comboDURUMU.SelectedItem = "Aktif";
                }
                else
                {
                    comboDURUMU.SelectedItem = "Pasif";
                }

                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = false;
                button4.Enabled = true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Kaydet

            int checkNumeric;
            string mesaj = "";
            if (txtADI_SOYADI.Text == "")
            {
                mesaj = "ÜYE ADI SOYADI boş bırakılamaz!\r\n";
            }
            if (txtADRES.Text == "")
            {
                mesaj += "ADRES boş bırakılamaz!\r\n";
            }
            if (txtTELEFON.Text == "" || txtTELEFON.Text.Length != 11 || int.TryParse(txtTELEFON.Text, out checkNumeric))
            {
                mesaj += "TELEFON boş bırakılamaz 11 haneli ve numerik olmalıdır!\r\n";
            }            
            if (txtEMAIL.Text == "")
            {
                mesaj += "EMAIL boş bırakılamaz!\r\n";
            }
            if (comboDURUMU.SelectedIndex == -1)
            {
                mesaj += "DURUMU boş bırakılamaz!";
            }

            if (mesaj != "")
            {
                FrmUYARI uyarı = new FrmUYARI();
                uyarı.textBox1.Text = mesaj;
                uyarı.ShowDialog();
                return;
            }

            UYE u = new UYE();
            if (txtUYE_REFNO.Text != "")
            {
                u = entities.UYEs.Find(Convert.ToInt32(txtUYE_REFNO.Text));
                u.ACIKLAMA = txtACIKLAMA.Text;
                u.ADI_SOYADI = txtADI_SOYADI.Text;
                u.ADRES = txtADRES.Text;
                if (Convert.ToString(comboDURUMU.SelectedItem) == "Aktif")
                {
                    u.DURUMU = true;
                }
                else
                {
                    u.DURUMU = false;
                }
                u.EKLEME_TARIHI = dateTimePicker1.Value;
                u.EMAIL = txtEMAIL.Text;
                u.TELEFON = txtTELEFON.Text;

                entities.SaveChanges();
            }
            else
            {
                u.ACIKLAMA = txtACIKLAMA.Text;
                u.ADI_SOYADI = txtADI_SOYADI.Text;
                u.ADRES = txtADRES.Text;
                if(Convert.ToString(comboDURUMU.SelectedItem) == "Aktif")
                {
                    u.DURUMU = true;
                }
                else
                {
                    u.DURUMU = false;
                }                
                u.EKLEME_TARIHI = dateTimePicker1.Value;
                u.EMAIL = txtEMAIL.Text;
                u.TELEFON = txtTELEFON.Text;

                entities.UYEs.Add(u);
                entities.SaveChanges();
            }

            GridDoldur();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // Sil
            DialogResult dr = MessageBox.Show("Silmek istediğinize emin misiniz?", "SİL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;
            if(txtUYE_REFNO.Text != "")
            {
                UYE u = new UYE();
                u = entities.UYEs.Find(Convert.ToInt32(txtUYE_REFNO.Text));
                entities.UYEs.Remove(u);
                entities.SaveChanges();
            }
            GridDoldur();
        }

        void GridDoldur()
        {
            var list = (from uye in entities.UYEs
                        select new
                        {
                            uye.UYE_REFNO,
                            uye.ADI_SOYADI,
                            uye.ADRES,
                            uye.TELEFON,
                            uye.EMAIL,
                            uye.EKLEME_TARIHI,
                            uye.DURUMU,
                            uye.ACIKLAMA
                        }).ToList();
            dataGridView1.DataSource = list;
        }
    }
}
