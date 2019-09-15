namespace Firma_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAYFA")]
    public partial class SAYFA
    {
        [Key]
        [Display(Name = "Sayfa REFNO")]
        public int SAYFA_REFNO { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Ba�l�k")]
        public string BASLIK { get; set; }

        [Required]
        [Display(Name = "��erik")]
        public string ICERIK { get; set; }
    }
}
