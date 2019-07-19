﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADO.Net;

namespace PRATİK
{
    public partial class FrmANA : Form
    {
        DBClass db = new DBClass();
        public FrmANA()
        {
            InitializeComponent();
        }

        private void MüşteriKartıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Formun gosterilmesi
            FrmMUSTERI frmMUSTERI = new FrmMUSTERI();
            frmMUSTERI.ShowDialog();
        }

        private void YineleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kategori
            FrmKATEGORI kategori = new FrmKATEGORI();
            kategori.ShowDialog();
        }

        private void MüşteriHareketListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Musteri hareket listesi
            FrmMUSHAR mushar = new FrmMUSHAR();
            mushar.ShowDialog();
        }

        private void MüşteriListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Müşteri listesi
            string sql = "SELECT * FROM MUSTERI";
            string dosyaAdi = "MUSTERI.csv";
            string yol = @"C:\Users\AYBU\Desktop\";
            Genel.csvReport(yol, dosyaAdi, sql, true);
        }

        private void KullanıcılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Genel.YetkiVarmı(Genel.KULLANICI_REFNO, Convert.ToInt32(MODUL.Kullanıcı), Convert.ToInt32(YETKI.OKU)) == true)
            {
                FrmKULLANICI kullanıcı = new FrmKULLANICI();
                kullanıcı.ShowDialog();
            }
            else
            {
                MessageBox.Show("Yetkiniz yok!");
            }
            
        }

        private void ÜrünKartıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmURUN urun = new FrmURUN();
            urun.ShowDialog();
        }

        private void ÜrünHareketListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmURUNHAR urunHar = new FrmURUNHAR();
            urunHar.ShowDialog();
        }

        private void ÜrünListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Urun listesi
            string sql = "SELECT * FROM URUN";
            string dosyaAdi = "URUN.csv";
            string yol = @"C:\Users\AYBU\Desktop\";
            Genel.csvReport(yol, dosyaAdi, sql, true);
        }
    }
}
