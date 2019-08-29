using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SportStore.Model.Repository;

namespace SportStore.Controls
{
    public partial class CategoryList : System.Web.UI.UserControl
    {
        Repository repository = new Repository();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected IEnumerable<string> GetCategories()
        {
            return repository.Products.Select(p => p.CATEGORY).Distinct().OrderBy(x => x);
        }

        protected string CreateLinkHtml(string category)
        {
            string selectedCategory = Request.QueryString["category"];
            string link = string.Format("<a href='/Pages/Listing.aspx?category={0}'{1}>{0}</a></br>", category, category == selectedCategory ? "class='selected'" : "");
            return link;
        }

    }
}