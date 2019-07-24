using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AfilliForm
{
    public partial class Form1 : Form
    {

        bool surukleniyor = false;
        private Point firstPoint;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Mouse a ilk tıkladık bırakmadık. Bu anda ilk point i aldık.
        /// </summary>
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            firstPoint = e.Location;
            surukleniyor = true;
        }

        /// <summary>
        /// Mouse un hareketine göre farkı aldık ve yeni pozisyonu ayarladık
        /// </summary>
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (surukleniyor)
            {
                int xfark = firstPoint.X - e.Location.X;
                int yfark = firstPoint.Y - e.Location.Y;

                int x = this.Location.X - xfark;
                int y = this.Location.Y - yfark;
                this.Location = new Point(x, y);
            }            
        }               

        /// <summary>
        /// Mouse u bıraktık sürükleme işlemi bitti
        /// </summary>
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            surukleniyor = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
