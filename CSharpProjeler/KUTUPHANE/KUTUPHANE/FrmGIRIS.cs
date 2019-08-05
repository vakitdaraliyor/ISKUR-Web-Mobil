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
    public partial class FrmGIRIS : Form
    {
        public FrmGIRIS()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();

            this.Opacity += 0.01;

            if (this.Opacity == 1)
            {
                System.Threading.Thread.Sleep(1000);
                timer1.Stop();
                this.Visible = false;
                frm1.ShowDialog();
                this.Close();
            }
        }

        private void FrmGIRIS_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
