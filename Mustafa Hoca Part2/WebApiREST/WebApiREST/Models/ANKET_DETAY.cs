namespace WebApiREST.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ANKET_DETAY
    {
        [Key]
        public int ANKET_DETAY_REFNO { get; set; }

        public int ANKET_REFNO { get; set; }

        [Required]
        [StringLength(100)]
        public string SECENEK { get; set; }

        public int OY_SAYISI { get; set; }

        public virtual ANKET ANKET { get; set; }
    }
}
