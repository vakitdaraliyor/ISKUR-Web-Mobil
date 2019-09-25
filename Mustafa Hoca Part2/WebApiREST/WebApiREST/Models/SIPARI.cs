namespace WebApiREST.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIPARIS")]
    public partial class SIPARI
    {
        [Key]
        public int SIPARIS_REFNO { get; set; }

        public int UYE_REFNO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime TARIHI { get; set; }

        public int DURUMU_REFNO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? TELIMAT_TARIHI { get; set; }

        public int ODEME_TURU_REFNO { get; set; }
    }
}
