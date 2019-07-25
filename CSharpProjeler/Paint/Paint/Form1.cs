using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {

        enum ECizimTipi
        {
            Daire,
            Serbest,
            Kare,
            Cizgi,
            Silgi
        }

        ECizimTipi cizimTipi = ECizimTipi.Serbest;
        bool cizimSuruyor = false;

        Point firstPoint = new Point();
        Point secondPoint = new Point();

        Graphics tuval;

        int cizgiKalinlik = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tuval = pnlCIZIM_ALANI.CreateGraphics();
            // tuval.DrawString("Osman", new Font("Arial", 14), new SolidBrush(Color.Black), 100, 100); // hangi noktada çizeceğini gösteriyoruz(100, 100 )
        }

        private void Panel5_Click(object sender, EventArgs e)
        {
            Panel pnl = sender as Panel;
            cizgiKalinlik = pnl.Height / 4;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            // Button b = (Button)sender;

            pnlRENK.BackColor = b.BackColor;
        }

        private void Button1_Paint(object sender, PaintEventArgs e)
        {
            Button b = (Button)sender;

            ControlPaint.DrawBorder(e.Graphics, b.ClientRectangle,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            cizimTipi = ECizimTipi.Kare;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            cizimTipi = ECizimTipi.Serbest;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            cizimTipi = ECizimTipi.Silgi;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            cizimTipi = ECizimTipi.Daire;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            cizimTipi = ECizimTipi.Cizgi;
        }

        private void PnlCIZIM_ALANI_MouseDown(object sender, MouseEventArgs e)
        {
            cizimSuruyor = true;
            firstPoint = e.Location;
        }

        private void PnlCIZIM_ALANI_MouseUp(object sender, MouseEventArgs e)
        {
            if (cizimTipi == ECizimTipi.Daire)
            {
                Rectangle r = new Rectangle(firstPoint.X, secondPoint.Y, secondPoint.X - firstPoint.X, secondPoint.Y - firstPoint.Y);
                tuval.DrawEllipse(new Pen(pnlRENK.BackColor, cizgiKalinlik), r);
            }
            else if (cizimTipi == ECizimTipi.Kare)
            {
                Rectangle r = new Rectangle(firstPoint.X, secondPoint.Y, secondPoint.X - firstPoint.X, secondPoint.Y - firstPoint.Y);
                tuval.DrawRectangle(new Pen(pnlRENK.BackColor, cizgiKalinlik), r);
            }
            else if (cizimTipi == ECizimTipi.Cizgi)
            {
                tuval.DrawLine(new Pen(pnlRENK.BackColor, cizgiKalinlik), firstPoint, secondPoint);
            }
            cizimSuruyor = false;
        }

        private void PnlCIZIM_ALANI_MouseMove(object sender, MouseEventArgs e)
        {
            if (cizimSuruyor == true)
            {
                // cizim yapılacak kodlar buraya yazılıyor
                secondPoint = e.Location;
                if (cizimTipi == ECizimTipi.Serbest)
                {
                    tuval.DrawLine(new Pen(pnlRENK.BackColor, cizgiKalinlik), firstPoint, secondPoint);
                    firstPoint = secondPoint;
                }
                else if (cizimTipi == ECizimTipi.Silgi)
                {
                    Rectangle r = new Rectangle(firstPoint.X, firstPoint.Y, 40, 40);
                    tuval.FillEllipse(new SolidBrush(pnlCIZIM_ALANI.BackColor), r);
                    firstPoint = secondPoint;
                }
            }
        }

        
    }
}
