using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportStore.Model.Repository
{
    public class Repository
    {
        private EntityFrameworkContext context = new EntityFrameworkContext();
        public IEnumerable<Product> Products
        {
            get
            {
                return context.products;
            }
        }
    }
}