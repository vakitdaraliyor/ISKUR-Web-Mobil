using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityOnHazırlık
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Kisi k = new Kisi();
            k.SetAdi("Amaç Yazılım Eğitim Danışmanlık Hizmetleri");
            button1.Text = k.GetAdi();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Kisi k = new Kisi();
            k.Soyadi = "savas yazılım eğitim ve danışmanlık";
            this.Text = k.Soyadi;
            propertyGrid1.SelectedObject = k;
        }
                
    }
}
