using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUNLUK.admin
{
    public partial class Giris : System.Web.UI.Page
    {

        BLOGEntities entities = new BLOGEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Giriş
            KULLANICI k = entities.KULLANICI.Where(k1 => k1.KULLANICI_ADI == txtKULLANICI_ADI.Text && k1.PAROLA == txtPAROLA.Text)
                                            .SingleOrDefault(); // tek kayit geleceginden eminsek
            if (k != null)
            {
                Session["GIRIS_YETKI"] = true;
                Response.Redirect("Kullanici.aspx");
            }
            else
            {
                Session["GIRIS_YETKI"] = false;
            }
        }
    }
}