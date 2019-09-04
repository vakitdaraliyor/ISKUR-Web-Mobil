using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUNLUK.admin
{
    public partial class Kullanici : System.Web.UI.Page
    {
        BLOGEntities entities = new BLOGEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = entities.KULLANICI.ToList();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {     
            int refno =  Convert.ToInt32(GridView1.SelectedDataKey.Value);
            KULLANICI k = entities.KULLANICI.Find(refno);

            if (k != null)
            {
                txtKULLANICI_REFNO.Text = Convert.ToString(k.KULLANICI_REFNO);
                txtKULLANICI_ADI.Text = k.KULLANICI_ADI;
                txtPAROLA.Text = k.PAROLA;
                drpDURUMU.SelectedValue = k.DURUMU.ToString();
            }

            // kayit panelini aç liste panelini kapat
            pnlKAYIT.Visible = true;
            pnlLISTE.Visible = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            // Kaydet
            if (txtKULLANICI_REFNO.Text != "")
            {
                KULLANICI k = entities.KULLANICI.Find(Convert.ToInt32(txtKULLANICI_REFNO.Text));
                k.KULLANICI_ADI = txtKULLANICI_ADI.Text;
                k.PAROLA = txtPAROLA.Text;
                k.DURUMU = Convert.ToBoolean(drpDURUMU.SelectedValue);

                entities.SaveChanges();
            }
            else
            {
                KULLANICI k = new KULLANICI();
                k.KULLANICI_ADI = txtKULLANICI_ADI.Text;
                k.PAROLA = txtPAROLA.Text;
                k.DURUMU = Convert.ToBoolean(drpDURUMU.SelectedValue);
                entities.KULLANICI.Add(k);

                entities.SaveChanges();
            }

            GridView1.DataSource = entities.KULLANICI.ToList();
            GridView1.DataBind();

            pnlKAYIT.Visible = false;
            pnlLISTE.Visible = true;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            // Vazgeç
            GridView1.DataSource = entities.KULLANICI.ToList();
            GridView1.DataBind();

            pnlLISTE.Visible = true;
            pnlKAYIT.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // Yeni
            txtKULLANICI_REFNO.Text = "";
            txtKULLANICI_ADI.Text = "";
            txtPAROLA.Text = "";
            drpDURUMU.SelectedValue = "True";

            pnlKAYIT.Visible = true;
            pnlLISTE.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Ara
            GridView1.DataSource = entities.KULLANICI.Where(a => a.KULLANICI_ADI.Contains(txtARA.Text)).ToList();
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            // PageIndexChanging
            GridView1.PageIndex = e.NewPageIndex; // tiklanan sayfa
            GridView1.DataSource = entities.KULLANICI.Where(a => a.KULLANICI_ADI.Contains(txtARA.Text)).ToList();
            GridView1.DataBind();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            // Sil
            if (txtKULLANICI_REFNO.Text != "")
            {
                KULLANICI k = entities.KULLANICI.Find(Convert.ToInt32(txtKULLANICI_REFNO.Text));
                entities.KULLANICI.Remove(k);

                entities.SaveChanges();
            }

            GridView1.DataSource = entities.KULLANICI.ToList();
            GridView1.DataBind();

            pnlKAYIT.Visible = false;
            pnlLISTE.Visible = true;
        }
    }
}