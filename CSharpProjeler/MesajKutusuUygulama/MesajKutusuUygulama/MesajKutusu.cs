using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesajKutusuUygulama
{
    public partial class MesajKutusu : Form
    {
        public MesajKutusu()
        {
            InitializeComponent();
        }

        public static DialogResult Goster(String mesaj, string baslik)
        {
            MesajKutusu frm = new MesajKutusu();
            frm.label1.Text = mesaj;
            frm.Text = baslik;

            DialogResult dr = frm.ShowDialog(); // Evet ya da Hayır butonuna mı basıldı
            return dr;
        }

        private void MesajKutusu_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.Width - panel1.Width) / 2;
            panel1.Top = (this.Height - panel1.Height) / 2;
        }

        private void MesajKutusu_Load(object sender, EventArgs e)
        {

        }
    }
}
