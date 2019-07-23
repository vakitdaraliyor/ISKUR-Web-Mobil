using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_OGRENIYORUM
{
    public partial class Frm3 : Form
    {
        PRATIKEntities db = new PRATIKEntities();
        public Frm3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            db.Configuration.LazyLoadingEnabled = false; // eager loading tek sorguda getirdi
            var liste = db.KATEGORIs.Include("URUNs").ToList();

            listBox1.Items.Clear();
            foreach (var kategori in liste)
            {
                listBox1.Items.Add(kategori.KATEGORI_ADI.ToString());
                listBox1.Items.Add("--------------------------------------------------");

                foreach (var urun in kategori.URUNs)
                {
                    listBox1.Items.Add(urun.ADI);
                }
            }

        }
    }
}
