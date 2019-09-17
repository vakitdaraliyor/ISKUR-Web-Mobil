using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FIRMA_ASPX.admin
{
    public partial class Urun : System.Web.UI.Page
    {
        FIRMAEntities db = new FIRMAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = db.urunlers.ToList();
            GridView1.DataBind();

            if (IsPostBack)
            {
                ddlKATEGORI_ADI.DataSource = db.KATEGORIs.ToList();
                ddlKATEGORI_ADI.DataTextField = "KATEGORI_ADI";
                ddlKATEGORI_ADI.DataValueField = "KATEGORI_REFNO";
                ddlKATEGORI_ADI.DataBind();

                ddlMARKA_ADI.DataSource = db.MARKAs.ToList();
                ddlMARKA_ADI.DataTextField = "MARKA_ADI";
                ddlMARKA_ADI.DataValueField = "MARKA_REFNO";
                ddlMARKA_ADI.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // SEÇ
            int refno = Convert.ToInt32(GridView1.SelectedDataKey.Value);
            URUN u = db.URUNs.Find(refno);

            if (u != null)
            {
                txtURUN_REFNO.Text = Convert.ToString(u.URUN_REFNO);
                txtURUN_ADI.Text = u.URUN_ADI;
                txtFIYATI.Text = Convert.ToString(u.FIYATI);
                ddlDURUMU.Text = Convert.ToString(u.DURUMU);
                ddlKATEGORI_ADI.SelectedValue = Convert.ToString(u.KATEGORI_REFNO);
                txtKDV_ORANI.Text = Convert.ToString(u.KDV_ORANI);
                ddlMARKA_ADI.SelectedValue = Convert.ToString(u.MARKA_REFNO);
                txtACIKLAMA.Text = HttpUtility.HtmlDecode(u.ACIKLAMA);
            }

            pnlKAYIT.Visible = true;
            pnlLISTE.Visible = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            // KAYDET
            if (txtURUN_REFNO.Text != "") // güncelle
            {
                URUN u = db.URUNs.Find(Convert.ToInt32(txtURUN_REFNO.Text));

                u.ACIKLAMA = HttpUtility.HtmlDecode(txtACIKLAMA.Text);
                u.DURUMU = Convert.ToBoolean(ddlDURUMU.SelectedValue);
                u.FIYATI = Convert.ToInt32(txtFIYATI.Text);
                u.KATEGORI_REFNO = Convert.ToInt32(ddlKATEGORI_ADI.SelectedValue);
                u.KDV_ORANI = Convert.ToInt32(txtKDV_ORANI.Text);
                u.MARKA_REFNO = Convert.ToInt32(ddlMARKA_ADI.SelectedValue);
                u.URUN_ADI = txtURUN_ADI.Text;
                u.RESIM1 = fuRESIM1.FileName;
                u.RESIM2 = fuRESIM2.FileName;
                u.RESIM3 = fuRESIM3.FileName;
                u.RESIM4 = fuRESIM4.FileName;
                db.SaveChanges();
            }
            else
            {
                URUN u = new URUN();

                u.ACIKLAMA = HttpUtility.HtmlDecode(txtACIKLAMA.Text);
                u.DURUMU = Convert.ToBoolean(ddlDURUMU.SelectedValue);
                u.FIYATI = Convert.ToInt32(txtFIYATI.Text);
                u.KATEGORI_REFNO = Convert.ToInt32(ddlKATEGORI_ADI.SelectedValue);
                u.KDV_ORANI = Convert.ToInt32(txtKDV_ORANI.Text);
                u.MARKA_REFNO = Convert.ToInt32(ddlMARKA_ADI.SelectedValue);
                u.URUN_ADI = txtURUN_ADI.Text;
                u.RESIM1 = fuRESIM1.FileName;
                u.RESIM2 = fuRESIM2.FileName;
                u.RESIM3 = fuRESIM3.FileName;
                u.RESIM4 = fuRESIM4.FileName;
                db.URUNs.Add(u);
                db.SaveChanges();
            }

            GridView1.DataSource = db.urunlers.ToList();
            GridView1.DataBind();
            pnlKAYIT.Visible = false;
            pnlLISTE.Visible = true;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            // VAZGEÇ
            GridView1.DataSource = db.urunlers.ToList();
            GridView1.DataBind();
            pnlKAYIT.Visible = false;
            pnlLISTE.Visible = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // YENİ
            txtURUN_REFNO.Text = "";
            txtURUN_ADI.Text = "";
            txtFIYATI.Text = "";
            ddlDURUMU.Text = "True";
            ddlKATEGORI_ADI.Text = "1";
            txtKDV_ORANI.Text = "";
            ddlMARKA_ADI.Text = "1";
            txtACIKLAMA.Text = "";

            pnlKAYIT.Visible = true;
            pnlLISTE.Visible = false;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            // SİL
            if (txtURUN_REFNO.Text != "")
            {
                URUN u = db.URUNs.Find(Convert.ToInt32(txtURUN_REFNO.Text));
                db.URUNs.Remove(u);
                db.SaveChanges();

                GridView1.DataSource = db.urunlers.ToList();
                GridView1.DataBind();

                pnlKAYIT.Visible = false;
                pnlLISTE.Visible = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // ARA
            GridView1.DataSource = db.urunlers.Where(u => u.URUN_ADI.Contains(txtARA.Text)).ToList();
            GridView1.DataBind();
            pnlKAYIT.Visible = false;
            pnlLISTE.Visible = true;
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            // PAGING
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = db.urunlers.Where(u => u.URUN_ADI.Contains(txtARA.Text)).ToList();
            GridView1.DataBind();
            pnlKAYIT.Visible = false;
            pnlLISTE.Visible = true;
        }
    }
}