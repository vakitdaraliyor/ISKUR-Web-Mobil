using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JavaMotosikletleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Birinci Tıklama");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Click += Test2; // olaya method bağlıyoruz
        }

        private void Test2(object sender, EventArgs e)
        {
            MessageBox.Show("İkinci Tıklama");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            button1.Click -= Test2; // methodu olaydan ayırıyoruzs
        }
    }
}
