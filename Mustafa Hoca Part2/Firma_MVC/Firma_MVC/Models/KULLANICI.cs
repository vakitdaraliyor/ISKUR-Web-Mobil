namespace Firma_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KULLANICI")]
    public partial class KULLANICI
    {
        [Key]
        public int KULLANICI_REFNO { get; set; }

        [Required]
        [StringLength(50)]
        public string KULLANICI_ADI { get; set; }

        [Required]
        [StringLength(50)]
        public string PAROLA { get; set; }
    }
}
