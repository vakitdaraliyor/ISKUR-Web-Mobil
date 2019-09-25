using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FIRMA_ASPX
{
    public partial class Home : System.Web.UI.Page
    {
        FIRMAEntities db = new FIRMAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataList1.DataSource = db.URUNs.Take(3).ToList();
            DataList1.DataBind();

            DataList2.DataSource = db.PROJEs.Take(3).ToList();
            DataList2.DataBind();
        }
    }
}