namespace WCFServisi.Model1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PROJE")]
    public partial class PROJE
    {
        [Key]
        public int PROJE_REFNO { get; set; }

        [Required]
        [StringLength(50)]
        public string PROJE_ADI { get; set; }

        [Required]
        [StringLength(50)]
        public string RESIM { get; set; }

        [Required]
        public string ACIKLAMA { get; set; }
    }
}
