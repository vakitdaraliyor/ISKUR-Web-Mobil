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
        [Display(Name = "KULLANICI REFNO")]
       
        public int KULLANICI_REFNO { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "KULLANICI ADI")]
        [ValidateUsername]
        public string KULLANICI_ADI { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "PAROLA")]
        public string PAROLA { get; set; }
    }
}
