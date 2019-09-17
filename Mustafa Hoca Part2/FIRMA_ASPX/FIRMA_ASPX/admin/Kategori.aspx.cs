using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FIRMA_ASPX.admin
{
    public partial class Kategori : System.Web.UI.Page
    {
        FIRMAEntities db = new FIRMAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = db.KATEGORIs.ToList();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SEÇ
            int refno = Convert.ToInt32(GridView1.SelectedDataKey.Value);
            KATEGORI k = db.KATEGORIs.Find(refno);
            if (k != null)
            {
                txtKATEGORI_REFNO.Text = Convert.ToString(k.KATEGORI_REFNO);
                txtKATEGORI_ADI.Text = k.KATEGORI_ADI;
            }

            pnlKAYIT.Visible = true;
            pnlLISTE.Visible = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            // KAYDET
            if (txtKATEGORI_REFNO.Text != "") //güncelle
            {
                KATEGORI k = db.KATEGORIs.Find(Convert.ToInt32(txtKATEGORI_REFNO.Text));
                k.KATEGORI_ADI = txtKATEGORI_ADI.Text;
                db.SaveChanges();
            }
            else // yeni kayıt
            {
                KATEGORI k = new KATEGORI();
                k.KATEGORI_ADI = txtKATEGORI_ADI.Text;
                db.KATEGORIs.Add(k);
                db.SaveChanges();
            }

            GridView1.DataSource = db.KATEGORIs.ToList();
            GridView1.DataBind();

            pnlKAYIT.Visible = false;
            pnlLISTE.Visible = true;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            // VAZGEÇ
            GridView1.DataSource = db.KATEGORIs.ToList();
            GridView1.DataBind();
            pnlKAYIT.Visible = false;
            pnlLISTE.Visible = true;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            // SİL
            if (txtKATEGORI_REFNO.Text != "")
            {
                KATEGORI k = db.KATEGORIs.Find(Convert.ToInt32(txtKATEGORI_REFNO.Text));
                db.KATEGORIs.Remove(k);
                db.SaveChanges();

                GridView1.DataSource = db.KATEGORIs.ToList();
                GridView1.DataBind();

                pnlKAYIT.Visible = false;
                pnlLISTE.Visible = true;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // YENİ
            txtKATEGORI_ADI.Text = "";
            txtKATEGORI_REFNO.Text = "";
            pnlKAYIT.Visible = true;
            pnlLISTE.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // ARA
            GridView1.DataSource = db.KATEGORIs.Where(k => k.KATEGORI_ADI.Contains(txtARA.Text)).ToList();
            GridView1.DataBind();

            pnlKAYIT.Visible = false;
            pnlLISTE.Visible = true;
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //PAGING
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = db.KATEGORIs.Where(k => k.KATEGORI_ADI.Contains(txtARA.Text)).ToList();
            GridView1.DataBind();
        }
    }
}