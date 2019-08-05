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
    public partial class FrmODUNCKITAP : Form
    {
        KUTUPHANEEntities entities = new KUTUPHANEEntities();
        int satir = -1;

        public FrmODUNCKITAP()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form yüklenirken datagrid e verileri doldurur
        /// </summary>
        private void FrmODUNCKITAP_Load(object sender, EventArgs e)
        {
            var uye = entities.UYEs.ToList();
            Genel.ListeDoldur<UYE>(comboUYE_REFNO, uye, "ADI_SOYADI", "UYE_REFNO");

            var kitap = entities.KITAPs.ToList();
            Genel.ListeDoldur<KITAP>(comboKITAP_REFNO, kitap, "ADI", "KITAP_REFNO");

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
                txtODUNC_KITAP_REFNO.Text = Convert.ToString(dataGridView1.Rows[satir].Cells["ODUNC_KITAP_REFNO"].Value);
                txtACIKLAMA.Text = Convert.ToString(dataGridView1.Rows[satir].Cells["ACIKLAMA"].Value);
                txtALINIS_TARIHI.Text = Convert.ToString(dataGridView1.Rows[satir].Cells["ALINIS_TARIHI"].Value);
                txtVERILIS_TARIHI.Text = Convert.ToString(dataGridView1.Rows[satir].Cells["VERILIS_TARIHI"].Value);
                comboDURUMU.SelectedItem = Convert.ToString(dataGridView1.Rows[satir].Cells["DURUMU"].Value);
                comboUYE_REFNO.Text = Convert.ToString(dataGridView1.Rows[satir].Cells["ADI_SOYADI"].Value);
                comboKITAP_REFNO.Text = Convert.ToString(dataGridView1.Rows[satir].Cells["ADI"].Value);

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
            txtODUNC_KITAP_REFNO.Text = "";
            txtALINIS_TARIHI.Text = "";
            txtVERILIS_TARIHI.Text = "";
            comboDURUMU.SelectedIndex = -1;
            comboKITAP_REFNO.SelectedIndex = -1;
            comboUYE_REFNO.SelectedIndex = -1;

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
                txtODUNC_KITAP_REFNO.Text = dataGridView1.Rows[satir].Cells["ODUNC_KITAP_REFNO"].Value.ToString();
                txtACIKLAMA.Text = Convert.ToString(dataGridView1.Rows[satir].Cells["ACIKLAMA"].Value);
                txtALINIS_TARIHI.Text = Convert.ToString(dataGridView1.Rows[satir].Cells["ALINIS_TARIHI"].Value);
                txtVERILIS_TARIHI.Text = Convert.ToString(dataGridView1.Rows[satir].Cells["VERILIS_TARIHI"].Value);
                comboDURUMU.SelectedItem = Convert.ToString(dataGridView1.Rows[satir].Cells["DURUMU"].Value);
                comboUYE_REFNO.Text = Convert.ToString(dataGridView1.Rows[satir].Cells["ADI_SOYADI"].Value);
                comboKITAP_REFNO.Text = Convert.ToString(dataGridView1.Rows[satir].Cells["ADI"].Value);

                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = false;
                button4.Enabled = true;
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Kaydet

            string mesaj = "";
            if (comboUYE_REFNO.SelectedIndex == -1)
            {
                mesaj = "ÜYE ADI SOYADI boş bırakılamaz!\r\n";
            }
            if (comboKITAP_REFNO.SelectedIndex == -1)
            {
                mesaj += "KİTAP ADI boş bırakılamaz!\r\n";
            }
            if (txtVERILIS_TARIHI.Text == "")
            {
                mesaj += "VERİLİŞ TARİHİ boş bırakılamaz!\r\n";
            }
            if (comboDURUMU.SelectedIndex == -1)
            {
                mesaj += "DURUMU boş bırakılamaz!";
            }
            if (Convert.ToString(comboDURUMU.SelectedItem) == "Alındı" && txtALINIS_TARIHI.Text == "")
            {
                mesaj += "ALIŞ TARIHI boş bırakılamaz!";
            }
            if (mesaj != "")
            {
                FrmUYARI uyarı = new FrmUYARI();
                uyarı.textBox1.Text = mesaj;
                uyarı.ShowDialog();
                return;
            }

            ODUNC_KITAP ok = new ODUNC_KITAP();
            if (txtODUNC_KITAP_REFNO.Text != "")
            {
                ok = entities.ODUNC_KITAP.Find(Convert.ToInt32(txtODUNC_KITAP_REFNO.Text));
                ok.UYE_REFNO = Convert.ToInt32(comboUYE_REFNO.SelectedValue);
                ok.KITAP_REFNO = Convert.ToInt32(comboKITAP_REFNO.SelectedValue);
                ok.VERILIS_TARIHI = Convert.ToDateTime(txtVERILIS_TARIHI.Text);

                // DURUMU Verildi ise ALINIS TARIHI alma
                if (Convert.ToString(comboDURUMU.SelectedItem) == "Verildi")
                {
                    ok.DURUMU = true;
                }
                // Durumu Alindi ise alinis tarihini de al
                else
                {
                    ok.DURUMU = false;
                    ok.ALINIS_TARIHI = Convert.ToDateTime(txtALINIS_TARIHI.Text);
                }

                ok.ACIKLAMA = txtACIKLAMA.Text;
                entities.SaveChanges();
            }
            else
            {
                ok.UYE_REFNO = Convert.ToInt32(comboUYE_REFNO.SelectedValue);
                ok.KITAP_REFNO = Convert.ToInt32(comboKITAP_REFNO.SelectedValue);
                ok.VERILIS_TARIHI = Convert.ToDateTime(txtVERILIS_TARIHI.Text);                

                // Durumu Verildi ise alınıs tarihini alma
                if (Convert.ToString(comboDURUMU.SelectedItem) == "Verildi")
                {
                    ok.DURUMU = true;
                }
                // Durumu Alindi ise alinis tarihini de al
                else
                {
                    ok.DURUMU = false;
                    if (Convert.ToDateTime(txtALINIS_TARIHI.Text) > Convert.ToDateTime(txtVERILIS_TARIHI.Text))
                    {
                        ok.ALINIS_TARIHI = Convert.ToDateTime(txtALINIS_TARIHI.Text);
                    }
                    else
                    {
                        errorProvider1.SetError(txtALINIS_TARIHI, "Uygun Tarih Giriniz!");
                        return;
                    }                    
                }

                ok.ACIKLAMA = txtACIKLAMA.Text;
                entities.ODUNC_KITAP.Add(ok);
                entities.SaveChanges();
            }

            GridDoldur();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // Sil
            DialogResult dr = MessageBox.Show("Silmek istediğinize emin misiniz?", "SİL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;

            if (txtODUNC_KITAP_REFNO.Text != "")
            {
                ODUNC_KITAP ok = new ODUNC_KITAP();
                ok = entities.ODUNC_KITAP.Find(Convert.ToInt32(txtODUNC_KITAP_REFNO.Text));
                entities.ODUNC_KITAP.Remove(ok);
                entities.SaveChanges();
            }

            GridDoldur();

        }

        /// <summary>
        /// UYE, KITAP ve ODUNC_KITAP tablolarini birlestirerek gerekli kolonlarin verilerini ceker
        /// </summary>
        void GridDoldur()
        {
            var liste = (from uyee in entities.UYEs
                         from kitapp in entities.KITAPs
                         from o_kitap in entities.ODUNC_KITAP
                         where uyee.UYE_REFNO == o_kitap.UYE_REFNO
                         where kitapp.KITAP_REFNO == o_kitap.KITAP_REFNO
                         select new
                         {
                             o_kitap.ODUNC_KITAP_REFNO,
                             uyee.ADI_SOYADI,
                             kitapp.ADI,
                             o_kitap.VERILIS_TARIHI,
                             o_kitap.ALINIS_TARIHI,
                             DURUMU = o_kitap.DURUMU == true ? "Verildi":"Alındı",
                             o_kitap.ACIKLAMA
                         }).ToList();

            dataGridView1.DataSource = liste;
        }

        /// <summary>
        /// DURUMU Alındı Olarak Değiştirildiği Zaman
        /// ALINIS TARIHI Doldurulabilir Hale Gelir
        /// </summary>
        private void ComboDURUMU_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(comboDURUMU.SelectedItem) == "Verildi")
            {
                txtALINIS_TARIHI.ReadOnly = true;
            }
            else if(Convert.ToString(comboDURUMU.SelectedItem) == "Alındı")
            {
                txtALINIS_TARIHI.ReadOnly = false;
            }
            else
            {
                txtALINIS_TARIHI.ReadOnly = true;
            }
        }
    }
}
