namespace WebApiREST.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SIPARIS_DETAY
    {
        [Key]
        public int SIPARIS_DETAY_REFNO { get; set; }

        public int SIPARIS_REFNO { get; set; }

        public int URUN_REFNO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DOVIZ_KURU { get; set; }

        public double BIRIM_FIYATI { get; set; }

        public int MIKTARI { get; set; }

        [Column(TypeName = "numeric")]
        public decimal KDV_ORANI { get; set; }
    }
}
