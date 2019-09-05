using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUNLUK.admin
{
    public partial class Yorum : System.Web.UI.Page
    {
        BLOGEntities entities = new BLOGEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["GIRIS_YETKI"] == null)
            {
                Response.Redirect("Giris.aspx");
            }
            else
            {
                if (Convert.ToBoolean(Session["GIRIS_YETKI"]) == false)
                {
                    Response.Redirect("Giris.aspx");
                }
            }

            GridView1.DataSource = entities.YORUM.ToList();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seç
            int refno = Convert.ToInt32(GridView1.SelectedDataKey.Value);
            YORUM y = entities.YORUM.Find(refno);

            if (y != null)
            {
                txtYORUM_REFNO.Text = Convert.ToString(y.YORUM_REFNO);
                txtYAZI_REFNO.Text = Convert.ToString(y.YAZI_REFNO);
                txtMAIL.Text = y.MAIL;
                txtADI_SOYADI.Text = y.ADI_SOYADI;
                drpDURUMU.SelectedValue = y.DURUMU.ToString();
                txtTARIH.Text = y.TARIH.ToString().Substring(0, 10).Replace("/", "-");
                txtIP.Text = y.IP;
                txtYORUM_ICERIK.Text = y.YORUM_ICERIK;
            }

            // kayit panelini aç liste panelini kapat
            pnlKAYIT.Visible = true;
            pnlLISTE.Visible = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            // Kaydet
            if (txtYORUM_REFNO.Text != "")
            {
                YORUM y = entities.YORUM.Find(Convert.ToInt32(txtYORUM_REFNO.Text));
                y.YAZI_REFNO = Convert.ToInt32(txtYAZI_REFNO.Text);
                y.MAIL = txtMAIL.Text;
                y.ADI_SOYADI = txtADI_SOYADI.Text;
                y.DURUMU = Convert.ToBoolean(drpDURUMU.SelectedValue);
                y.TARIH = Convert.ToDateTime(txtTARIH.Text);
                y.IP = txtIP.Text;
                y.YORUM_ICERIK = txtYORUM_ICERIK.Text;

                entities.SaveChanges();
            }
            else
            {
                YORUM y = new YORUM();
                y.YAZI_REFNO = Convert.ToInt32(txtYAZI_REFNO.Text);
                y.MAIL = txtMAIL.Text;
                y.ADI_SOYADI = txtADI_SOYADI.Text;
                y.DURUMU = Convert.ToBoolean(drpDURUMU.SelectedValue);
                y.TARIH = Convert.ToDateTime(txtTARIH.Text);
                y.IP = txtIP.Text;
                y.YORUM_ICERIK = txtYORUM_ICERIK.Text;
                entities.YORUM.Add(y);

                entities.SaveChanges();
            }

            GridView1.DataSource = entities.YORUM.ToList();
            GridView1.DataBind();

            pnlKAYIT.Visible = false;
            pnlLISTE.Visible = true;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            // Vazgeç
            GridView1.DataSource = entities.YORUM.ToList();
            GridView1.DataBind();

            pnlLISTE.Visible = true;
            pnlKAYIT.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // Yeni
            txtYORUM_REFNO.Text = "";
            txtYAZI_REFNO.Text = "";
            txtMAIL.Text = "";
            txtADI_SOYADI.Text = "";
            drpDURUMU.SelectedValue = "True";
            txtTARIH.Text = "";
            txtIP.Text = "";
            txtYORUM_ICERIK.Text = "";

            pnlKAYIT.Visible = true;
            pnlLISTE.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Ara
            GridView1.DataSource = entities.YORUM.Where(y => y.YORUM_ICERIK.Contains(txtYORUM_ARA.Text)).ToList();
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            // PageIndexChanging
            GridView1.PageIndex = e.NewPageIndex; // tiklanan sayfa
            GridView1.DataSource = entities.YORUM.Where(y => y.YORUM_ICERIK.Contains(txtYORUM_ARA.Text)).ToList();
            GridView1.DataBind();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            // Sil
            if (txtYORUM_REFNO.Text != "")
            {
                YORUM y = entities.YORUM.Find(Convert.ToInt32(txtYORUM_REFNO.Text));
                entities.YORUM.Remove(y);

                entities.SaveChanges();
            }

            GridView1.DataSource = entities.YORUM.ToList();
            GridView1.DataBind();

            pnlKAYIT.Visible = false;
            pnlLISTE.Visible = true;
        }
    }
}