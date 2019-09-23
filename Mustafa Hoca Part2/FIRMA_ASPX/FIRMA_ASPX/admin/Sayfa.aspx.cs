using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FIRMA_ASPX.admin
{
    public partial class Sayfa : System.Web.UI.Page
    {
        FIRMAEntities db = new FIRMAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = db.SAYFAs.ToList();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // SEÇ
            SAYFA s = db.SAYFAs.Find(Convert.ToInt32(GridView1.SelectedDataKey.Value));
            if (s != null)
            {
                txtSAYFA_REFNO.Text = Convert.ToString(s.SAYFA_REFNO);
                txtBASLIK.Text = s.BASLIK;
                txtICERIK.Text = HttpUtility.HtmlDecode(s.ICERIK);
            }
            pnlKAYIT.Visible = true;
            pnlLISTE.Visible = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            // KAYDET
            if (txtSAYFA_REFNO.Text != "") // güncelle
            {
                SAYFA s = db.SAYFAs.Find(Convert.ToInt32(txtSAYFA_REFNO.Text));
                s.BASLIK = txtBASLIK.Text;
                s.ICERIK = HttpUtility.HtmlDecode(txtICERIK.Text);
                db.SaveChanges();
            }
            else
            {
                SAYFA s = new SAYFA();
                s.BASLIK = txtBASLIK.Text;
                s.ICERIK = txtICERIK.Text;
                db.SAYFAs.Add(s);
                db.SaveChanges();
            }
            GridView1.DataSource = db.SAYFAs.ToList();
            GridView1.DataBind();
            pnlKAYIT.Visible = false;
            pnlLISTE.Visible = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // YENİ
            txtSAYFA_REFNO.Text = "";
            txtBASLIK.Text = "";
            txtICERIK.Text = "";
            pnlKAYIT.Visible = true;
            pnlLISTE.Visible = false;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            // VAZGEÇ
            GridView1.DataSource = db.SAYFAs.ToList();
            GridView1.DataBind();
            pnlKAYIT.Visible = false;
            pnlLISTE.Visible = true;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            // SİL
            if (txtSAYFA_REFNO.Text != "")
            {
                SAYFA s = db.SAYFAs.Find(Convert.ToInt32(txtSAYFA_REFNO.Text));
                db.SAYFAs.Remove(s);
                db.SaveChanges();

                GridView1.DataSource = db.SAYFAs.ToList();
                GridView1.DataBind();

                pnlKAYIT.Visible = false;
                pnlLISTE.Visible = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // ARA
            GridView1.DataSource = db.SAYFAs.Where(s => s.BASLIK.Contains(txtARA.Text)).ToList();
            GridView1.DataBind();
            pnlKAYIT.Visible = false;
            pnlLISTE.Visible = true;
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = db.SAYFAs.Where(s => s.BASLIK.Contains(txtARA.Text)).ToList();
            GridView1.DataBind();
            pnlKAYIT.Visible = false;
            pnlLISTE.Visible = true;
        }
    }
}