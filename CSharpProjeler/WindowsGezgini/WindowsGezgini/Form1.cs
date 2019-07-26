using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsGezgini
{
    // splitcontainer attik
    public partial class Form1 : Form
    {
        ArrayList liste = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] suruculer = DriveInfo.GetDrives();

            for (int i = 0; i < suruculer.Length; i++)
            {
                TreeNode tn = new TreeNode();
                tn.Text = suruculer[i].Name;
                treeView1.Nodes.Add(tn);
                if (suruculer[i].IsReady)
                {
                    KlasorListele(tn);
                }
                
            }
        }

        void KlasorListele(TreeNode tn)
        {
            string[] klasorler = Directory.GetDirectories(tn.Text);
            for (int i = 0; i < klasorler.Length; i++)
            {
                TreeNode tn1 = new TreeNode();
                tn1.Text = klasorler[i].Substring(3);
                tn.Nodes.Add(tn1);
            }
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            aramaDevam = true;
            txtKLASOR.Text = e.Node.FullPath;
            listView1.Items.Clear();

            DosyaListele(txtKLASOR.Text, "*.*");
            aramaDevam = false;
        }

        void DosyaListele(string path, string filter)
        {
            try
            {
                string[] dosyalar = Directory.GetFiles(path, filter);

                for (int i = 0; i < dosyalar.Length; i++)
                {
                    FileInfo fi = new FileInfo(dosyalar[i]);
                    ListViewItem li = new ListViewItem();
                    li.Text = fi.Name;
                    listView1.Items.Add(li);                                      

                    string uzunluk = "";
                    if (fi.Length / (1024*1024*1024) > 0)
                    {
                        uzunluk = fi.Length / (1024 * 1024 * 1024) + "GB";
                    }
                    else if(fi.Length / (1024 * 1024) > 0)
                    {
                        uzunluk = fi.Length / (1024 * 1024) + "MB";
                    }
                    else if (fi.Length / 1024 > 0)
                    {
                        uzunluk = fi.Length / (1024) + "KB";
                    }
                    else
                    {
                        uzunluk = fi.Length + "Bytes";
                    }
                    li.SubItems.Add(uzunluk);

                    li.SubItems.Add(fi.DirectoryName);
                    // Refresh();
                    Application.DoEvents();

                    if (aramaDevam == false) return;
                }
            }
            catch { }
            
        }

        private void TxtKLASOR_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listView1.Items.Clear();
                DosyaListele(txtKLASOR.Text, "*.*");
            }
        }

        void DosyaAra(string path, string filter)
        {
            try
            {
                DosyaListele(path, filter);

                string[] klasorler = Directory.GetDirectories(path);                
                for (int i = 0; i < klasorler.Length; i++)
                {
                    if (aramaDevam == false) return;
                    string klasor = klasorler[i];
                    txtDURUMU.Text = klasor;
                    DosyaAra(klasor, filter);
                }
            }
            catch { } // erişim izni olmayan klasörlerde hata oluştuğu için try catch içine aldık

        }

        private void TxtARAMA_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                aramaDevam = true;
                toolStripButton1.Text = "Durdur";
                listView1.Items.Clear();
                DosyaAra(txtKLASOR.Text, txtARAMA.Text);
            }
        }

        bool aramaDevam = false;
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            if (toolStripButton1.Text == "Ara")
            {
                aramaDevam = true;
                toolStripButton1.Text = "Durdur";
                listView1.Items.Clear();
                DosyaAra(txtKLASOR.Text, txtARAMA.Text);
                aramaDevam = false;
            }
            else
            {
                toolStripButton1.Text = "Ara";
                aramaDevam = false;
            }
        }

        /// <summary>
        /// Listeleme Çeşitleri
        /// </summary>
        private void ListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Listele
            listView1.View = View.List;
        }

        private void BüyükİconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void KüçükİconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void DetaylıListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void KopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kopyala
            liste.Clear();
            for (int i = 0; i < listView1.SelectedItems.Count; i++)
            {
                liste.Add(listView1.SelectedItems[i]);
            }
        }

        private void YapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Yapıştır
            for (int i = 0; i < liste.Count; i++)
            {
                ListViewItem li = liste[i] as ListViewItem;
                string dosyaadi = li.Text;
                string klasor = li.SubItems[2].Text;

                string hedefklasor = txtKLASOR.Text;
                try
                {
                    File.Copy(klasor + @"\" + dosyaadi, hedefklasor + @"\" + dosyaadi, true);
                }
                catch { }
            }

            listView1.Items.Clear();
            aramaDevam = true;
            DosyaListele(txtKLASOR.Text, "*.*");
            aramaDevam = false;
            liste.Clear(); // Kopyalama listesi temizleniyor.
        }

        private void SilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Sil

            liste.Clear();
            for (int i = 0; i < listView1.SelectedItems.Count; i++)
            {
                liste.Add(listView1.SelectedItems[i]);
            }

            for (int i = 0; i < liste.Count; i++)
            {
                ListViewItem li = liste[i] as ListViewItem;
                string dosyaadi = li.Text;
                string klasor = li.SubItems[2].Text;

                try
                {
                    File.Delete(klasor + @"\" + dosyaadi);
                }
                catch { }
            }

            listView1.Items.Clear();
            aramaDevam = true;
            DosyaListele(txtKLASOR.Text, "*.*");
            aramaDevam = false;
            liste.Clear(); // Kopyalama listesi temizleniyor.
        }
    }
}
