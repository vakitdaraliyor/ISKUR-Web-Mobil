using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FIRMA_ASPX.admin
{
    public partial class Proje : System.Web.UI.Page
    {
        FIRMAEntities db = new FIRMAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = db.PROJEs.ToList();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // SEÇ
            PROJE p = db.PROJEs.Find(Convert.ToInt32(GridView1.SelectedDataKey.Value));
            txtPROJE_REFNO.Text = Convert.ToString(p.PROJE_REFNO);
            txtPROJE_ADI.Text = p.PROJE_ADI;
            txtACIKLAMA.Text = HttpUtility.HtmlDecode(p.ACIKLAMA);
            imgRESIM.ImageUrl = p.RESIM;

            pnlKAYIT.Visible = true;
            pnlLISTE.Visible = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            // KAYDET 
            if (txtPROJE_REFNO.Text != "") // güncelle
            {
                PROJE p = db.PROJEs.Find(Convert.ToInt32(txtPROJE_REFNO.Text));
                p.PROJE_ADI = txtPROJE_ADI.Text;
                p.ACIKLAMA = HttpUtility.HtmlDecode(txtACIKLAMA.Text);
                ResimKaydet(p, fuRESIM);
                db.SaveChanges();
            }
            else
            {
                PROJE p = new PROJE();
                p.PROJE_ADI = txtPROJE_ADI.Text;
                p.ACIKLAMA = HttpUtility.HtmlDecode(txtACIKLAMA.Text);
                ResimKaydet(p, fuRESIM);
                db.PROJEs.Add(p);
                db.SaveChanges();
            }

            GridView1.DataSource = db.PROJEs.ToList();
            GridView1.DataBind();
            pnlKAYIT.Visible = false;
            pnlLISTE.Visible = true;
        }        

        protected void Button2_Click(object sender, EventArgs e)
        {
            // YENİ
            txtPROJE_REFNO.Text = "";
            txtPROJE_ADI.Text = "";
            txtACIKLAMA.Text = "";

            pnlKAYIT.Visible = true;
            pnlLISTE.Visible = false;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            // VAZGEÇ
            GridView1.DataSource = db.PROJEs.ToList();
            GridView1.DataBind();
            pnlKAYIT.Visible = false;
            pnlLISTE.Visible = true;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            // SİL
            PROJE p = db.PROJEs.Find(Convert.ToInt32(txtPROJE_REFNO.Text));
            db.PROJEs.Remove(p);
            db.SaveChanges();
            GridView1.DataSource = db.PROJEs.ToList();
            GridView1.DataBind();
            pnlKAYIT.Visible = false;
            pnlLISTE.Visible = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // ARA
            GridView1.DataSource = db.PROJEs.Where(p => p.PROJE_ADI.Contains(txtARA.Text)).ToList();
            GridView1.DataBind();
            pnlKAYIT.Visible = false;
            pnlLISTE.Visible = true;
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = db.PROJEs.Where(p => p.PROJE_ADI.Contains(txtARA.Text)).ToList();
            GridView1.DataBind();
            pnlKAYIT.Visible = false;
            pnlLISTE.Visible = true;
        }

        void ResimKaydet(PROJE p, FileUpload fuRESIM)
        {
            if ((fuRESIM.PostedFile != null) && (fuRESIM.PostedFile.ContentLength > 0))
            {
                p.RESIM = fuRESIM.FileName;
                string SaveLocation = Server.MapPath("/admin/Images/Proje/" + fuRESIM.FileName);
                try
                {
                    fuRESIM.PostedFile.SaveAs(SaveLocation);
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}