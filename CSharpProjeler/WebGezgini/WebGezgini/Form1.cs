using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebGezgini
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            ;
            if (txtADRES.Text != "")
            {
                webBrowser1.Navigate(txtADRES.Text);
            }
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            // Go Home
            webBrowser1.GoHome();
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            // Go Back
            webBrowser1.GoBack();
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void TxtArama_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string arama = "https://www.google.com/search?q=" + txtArama.Text + "&oq=" + txtArama.Text + "&aqs=chrome..69i57j69i60.4111j0j4&sourceid=chrome&ie=UTF-8";
                webBrowser1.Navigate(arama);
            }
        }

        private void TxtAdres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.Enter)
            {
                txtADRES.Text = "www." + txtADRES.Text + ".com";
                webBrowser1.Navigate(txtADRES.Text);
            }
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            txtDURUMU.Text = "Sayfa tamamlandı.";
        }

        private void WebBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            txtDURUMU.Text = "Sayfa yükleniyor...";
        }
    }
}
