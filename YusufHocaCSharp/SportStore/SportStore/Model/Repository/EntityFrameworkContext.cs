using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SportStore.Model.Repository
{
    public class EntityFrameworkContext : DbContext
    {
        public DbSet<Product> products { get; set; }

    }
}