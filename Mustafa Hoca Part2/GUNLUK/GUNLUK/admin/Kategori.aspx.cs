using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUNLUK.admin
{
    public partial class Kategori : System.Web.UI.Page
    {
        BLOGEntities entities = new BLOGEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = entities.KATEGORI.ToList();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seç
            int refno = Convert.ToInt32(GridView1.SelectedDataKey.Value);
            KATEGORI k = entities.KATEGORI.Find(refno);

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
            // Kaydet
            if (txtKATEGORI_REFNO.Text != "")
            {
                KATEGORI k = entities.KATEGORI.Find(Convert.ToInt32(txtKATEGORI_REFNO.Text));
                k.KATEGORI_ADI = txtKATEGORI_ADI.Text;

                entities.SaveChanges();
            }
            else
            {
                KATEGORI k = new KATEGORI();
                k.KATEGORI_ADI = txtKATEGORI_ADI.Text;

                entities.KATEGORI.Add(k);
                entities.SaveChanges();
            }

            GridView1.DataSource = entities.KATEGORI.ToList();
            GridView1.DataBind();

            pnlKAYIT.Visible = false;
            pnlLISTE.Visible = true;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            // Vazgeç
            GridView1.DataSource = entities.KATEGORI.ToList();
            GridView1.DataBind();

            pnlLISTE.Visible = true;
            pnlKAYIT.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // Yeni
            txtKATEGORI_REFNO.Text = "";
            txtKATEGORI_ADI.Text = "";

            pnlKAYIT.Visible = true;
            pnlLISTE.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Ara
            GridView1.DataSource = entities.KATEGORI.Where(k => k.KATEGORI_ADI.Contains(txtKATEGORI_ADI_ARA.Text)).ToList();
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            // PageIndexChanging
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = entities.KATEGORI.Where(k => k.KATEGORI_ADI.Contains(txtKATEGORI_ADI_ARA.Text)).ToList();
            GridView1.DataBind();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            // Sil
            if (txtKATEGORI_REFNO.Text != "")
            {
                KATEGORI k = entities.KATEGORI.Find(Convert.ToInt32(txtKATEGORI_REFNO.Text));
                entities.KATEGORI.Remove(k);

                entities.SaveChanges();
            }

            GridView1.DataSource = entities.KATEGORI.ToList();
            GridView1.DataBind();

            pnlKAYIT.Visible = false;
            pnlLISTE.Visible = true;
        }
    }
}