using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SportStore.Model
{
    public class Product
    {
        [Key]
        public int PRODUCT_REFNO { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string CATEGORY { get; set; }
        public decimal PRICE { get; set; }
    }
}