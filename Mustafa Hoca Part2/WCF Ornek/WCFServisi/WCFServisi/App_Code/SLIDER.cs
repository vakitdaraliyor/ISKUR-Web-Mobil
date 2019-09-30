namespace WCFServisi.Model1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SLIDER")]
    public partial class SLIDER
    {
        [Key]
        public int SLIDER_REFNO { get; set; }

        [Required]
        [StringLength(50)]
        public string BASLIK { get; set; }

        [Required]
        [StringLength(50)]
        public string LINK { get; set; }

        [Required]
        [StringLength(50)]
        public string RESIM { get; set; }

        public bool DURUMU { get; set; }
    }
}
