using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FIRMA_ASPX
{
    public partial class Urunler : System.Web.UI.Page
    {
        FIRMAEntities db = new FIRMAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataList1.DataSource = db.KATEGORIs.ToList();
            DataList1.DataBind();

            if (Request["kategori_id"] != null)
            {
                int refno = Convert.ToInt32(Request["kategori_id"]);
                DataList2.DataSource = db.URUNs.Where(u => u.KATEGORI_REFNO == refno).ToList();
                DataList2.DataBind();
            }
        }
    }
}