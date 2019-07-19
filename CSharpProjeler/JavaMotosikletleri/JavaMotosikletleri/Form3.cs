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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            button1.Click += OrtakMethod;
            button2.Click += OrtakMethod;
        }
        
        private void OrtakMethod(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            this.Text = btn.Text;
        }
        
    }
}
