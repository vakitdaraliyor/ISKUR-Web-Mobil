using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Başlıksız.txt";
        }

        private void YeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Yeni
            textBox1.Text = "";
            this.Text = "Başlıksız.txt";
        }

        private void AçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.Default);
                this.Text = openFileDialog1.FileName;
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void KaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Text == "Başlıksız.txt")
            {
                farkliKaydet();
            }
            else
            {
                StreamWriter sw = new StreamWriter(this.Text, false, Encoding.Default);
                sw.WriteLine(textBox1.Text);
                sw.Flush();
                sw.Close();
            }            
        }

        void farkliKaydet()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Text = saveFileDialog1.FileName; // Dosya adını form baslıgına yazar
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false, Encoding.Default);
                sw.WriteLine(textBox1.Text);
                sw.Flush();
                sw.Close();
            }
        }

        private void FarklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Farklı kaydet
            farkliKaydet();
        }

        private void ÇıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Çıkış
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Kapatmak istediğinize emin misiniz?", "ÇIKIŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void ÖzelleştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void SeçeneklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void SayfaAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void YazıcıAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void YazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 1), e.MarginBounds);
            e.Graphics.DrawString(textBox1.Text,
                                  new Font("Arial",12), 
                                  new SolidBrush(textBox1.ForeColor),
                                  e.MarginBounds.Left, e.MarginBounds.Top);
        }
    }
}
