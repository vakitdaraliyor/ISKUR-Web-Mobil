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

            if (IsPostBack==false)
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
                imgRESIM1.ImageUrl = u.RESIM1;
                imgRESIM2.ImageUrl = u.RESIM2;
                imgRESIM3.ImageUrl = u.RESIM3;
                imgRESIM4.ImageUrl = u.RESIM4;
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

                ResimKaydet(u, fuRESIM1, fuRESIM2, fuRESIM3, fuRESIM4);

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
                
                ResimKaydet(u, fuRESIM1, fuRESIM2, fuRESIM3, fuRESIM4);

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

        public void ResimKaydet(URUN u, FileUpload fuRESIM1, FileUpload fuRESIM2, FileUpload fuRESIM3, FileUpload fuRESIM4)
        {
            if ((fuRESIM1.PostedFile != null) && (fuRESIM1.PostedFile.ContentLength > 0))
            {
                u.RESIM1 = fuRESIM1.FileName;
                string SaveLocation = Server.MapPath("/admin/Images/" + fuRESIM1.FileName);
                try
                {
                    fuRESIM1.PostedFile.SaveAs(SaveLocation);
                }
                catch (Exception ex)
                {

                }
            }

            if ((fuRESIM2.PostedFile != null) && (fuRESIM2.PostedFile.ContentLength > 0))
            {
                u.RESIM2 = fuRESIM2.FileName;
                string SaveLocation = Server.MapPath("/admin/Images/" + fuRESIM2.FileName);
                try
                {
                    fuRESIM2.PostedFile.SaveAs(SaveLocation);
                }
                catch (Exception ex)
                {

                }
            }

            if ((fuRESIM3.PostedFile != null) && (fuRESIM3.PostedFile.ContentLength > 0))
            {
                u.RESIM3 = fuRESIM3.FileName;
                string SaveLocation = Server.MapPath("/admin/Images/" + fuRESIM3.FileName);
                try
                {
                    fuRESIM3.PostedFile.SaveAs(SaveLocation);
                }
                catch (Exception ex)
                {

                }
            }

            if ((fuRESIM4.PostedFile != null) && (fuRESIM4.PostedFile.ContentLength > 0))
            {
                u.RESIM4 = fuRESIM4.FileName;
                string SaveLocation = Server.MapPath("/admin/Images/" + fuRESIM4.FileName);
                try
                {
                    fuRESIM4.PostedFile.SaveAs(SaveLocation);
                }
                catch (Exception ex)
                {

                }
            }

        }
    }
}