namespace WebApiREST.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("YONETICI")]
    public partial class YONETICI
    {
        [Key]
        public int YONETICI_REFNO { get; set; }

        [Required]
        [StringLength(10)]
        public string KULLANICI_ADI { get; set; }

        [Required]
        [StringLength(10)]
        public string SIFRESI { get; set; }

        public bool DURUMU { get; set; }
    }
}
