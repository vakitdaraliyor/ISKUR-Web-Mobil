namespace WebApiREST.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MANSET")]
    public partial class MANSET
    {
        [Key]
        public int MANSET_REFNO { get; set; }

        [Required]
        [StringLength(200)]
        public string BASLIK { get; set; }

        [Required]
        [StringLength(50)]
        public string URL { get; set; }

        [Required]
        [StringLength(50)]
        public string RESIM { get; set; }
    }
}
