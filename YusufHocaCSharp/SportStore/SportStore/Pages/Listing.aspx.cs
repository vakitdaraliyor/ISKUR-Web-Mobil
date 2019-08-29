using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SportStore.Model;
using SportStore.Model.Repository;

namespace SportStore.Pages
{
    public partial class Listing : System.Web.UI.Page
    {
        private Repository repository = new Repository();
        private int PageSize = 4;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected int CurrentPage
        {
            get
            {
                int pageNumber;
                if(int.TryParse(Request.QueryString["page"], out pageNumber))
                {
                    if (pageNumber > MaxPage)
                    {
                        return MaxPage;
                    }
                    else if(pageNumber < 1)
                    {
                        return 1;
                    }
                    else
                    {
                        return pageNumber;
                    }
                }
                else
                {
                    return 1;
                }
            }
        }

        protected int MaxPage
        {
            get
            {
                int max = (int)Math.Ceiling((decimal)FilteredProductsByCategory().Count() / PageSize);
                return max;
            }
        }

        protected IEnumerable<Product> FilteredProductsByCategory()
        {
            IEnumerable<Product> products = repository.Products;
            string category = Request.QueryString["category"];
            if (category == null || category == "")
            {
                return products;
            }
            else
            {
                return category == null ? products : products.Where(p => p.CATEGORY == category);
            }
            
        }

        // Veri tabaninin icerisinde bulundugu listeyi return eder
        protected IEnumerable<Product> GetProducts()
        {
            return FilteredProductsByCategory().OrderBy(p => p.PRODUCT_REFNO)
                                      .Skip((CurrentPage - 1) * PageSize)
                                      .Take(PageSize);
        }

        protected string CurrentCategory
        {
            get
            {
                string category = Request.QueryString["category"];
                return category == null ? "" : category;
            }
        }
    }
}