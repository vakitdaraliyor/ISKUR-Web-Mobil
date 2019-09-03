using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUNLUK.admin
{
    public partial class Kullanici : System.Web.UI.Page
    {
        BLOGEntities entities = new BLOGEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = entities.KULLANICI.ToList();
            GridView1.DataBind();
        }
    }
}