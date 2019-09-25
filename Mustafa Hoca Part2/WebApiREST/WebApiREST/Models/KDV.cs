namespace WebApiREST.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KDV")]
    public partial class KDV
    {
        [Key]
        public int KDV_REFNO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal KDV_ORANI { get; set; }
    }
}
