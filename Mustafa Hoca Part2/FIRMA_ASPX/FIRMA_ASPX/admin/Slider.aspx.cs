using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FIRMA_ASPX.admin
{
    public partial class Slider : System.Web.UI.Page
    {
        FIRMAEntities db = new FIRMAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = db.SLIDERs.ToList();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // SEÇ
            SLIDER s = db.SLIDERs.Find(Convert.ToInt32(GridView1.SelectedDataKey.Value));
            txtSLIDER_REFNO.Text = Convert.ToString(s.SLIDER_REFNO);
            txtBASLIK.Text = s.BASLIK;
            txtLINK.Text = s.LINK;
            imgRESIM.ImageUrl = "admin/Images/Slider/" + s.RESIM;
            ddlDURUMU.Text = Convert.ToString(s.DURUMU);

            pnlKAYIT.Visible = true;
            pnlLISTE.Visible = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            // KAYDET
            if (txtSLIDER_REFNO.Text != "") // güncelle
            {
                SLIDER s = db.SLIDERs.Find(Convert.ToInt32(txtSLIDER_REFNO.Text));
                s.BASLIK = txtBASLIK.Text;
                s.LINK = txtLINK.Text;
                s.DURUMU = Convert.ToBoolean(ddlDURUMU.SelectedValue);
                ResimKaydet(s, fuRESIM);
                db.SaveChanges();
            }
            else
            {
                SLIDER s = new SLIDER();
                s.BASLIK = txtBASLIK.Text;
                s.LINK = txtLINK.Text;
                s.DURUMU = Convert.ToBoolean(ddlDURUMU.SelectedValue);
                ResimKaydet(s, fuRESIM);
                db.SLIDERs.Add(s);
                db.SaveChanges();
            }

            GridView1.DataSource = db.SLIDERs.ToList();
            GridView1.DataBind();

            pnlKAYIT.Visible = false;
            pnlLISTE.Visible = true;
        }

        void ResimKaydet(SLIDER s, FileUpload fuRESIM)
        {
            if ((fuRESIM.PostedFile != null) && (fuRESIM.PostedFile.ContentLength > 0))
            {
                s.RESIM = fuRESIM.FileName;
                string SaveLocation = Server.MapPath("/admin/Images/Slider/" + fuRESIM.FileName);
                try
                {
                    fuRESIM.PostedFile.SaveAs(SaveLocation);
                }
                catch (Exception ex)
                {

                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // YENİ
            txtBASLIK.Text = "";
            txtLINK.Text = "";
            pnlKAYIT.Visible = true;
            pnlLISTE.Visible = false;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            // VAZGEÇ
            GridView1.DataSource = db.SLIDERs.ToList();
            GridView1.DataBind();

            pnlKAYIT.Visible = false;
            pnlLISTE.Visible = true;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            // SİL
            if (txtSLIDER_REFNO.Text != "")
            {
                SLIDER s = db.SLIDERs.Find(Convert.ToInt32(txtSLIDER_REFNO.Text));
                db.SLIDERs.Remove(s);
                db.SaveChanges();

                GridView1.DataSource = db.SLIDERs.ToList();
                GridView1.DataBind();

                pnlKAYIT.Visible = false;
                pnlLISTE.Visible = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // ARA
            GridView1.DataSource = db.SLIDERs.Where(s => s.BASLIK.Contains(txtARA.Text)).ToList();
            GridView1.DataBind();

            pnlKAYIT.Visible = false;
            pnlLISTE.Visible = true;
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            // PAGING
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = db.SLIDERs.Where(s => s.BASLIK.Contains(txtARA.Text)).ToList();
            GridView1.DataBind();

            pnlKAYIT.Visible = false;
            pnlLISTE.Visible = true;
        }
    }
}