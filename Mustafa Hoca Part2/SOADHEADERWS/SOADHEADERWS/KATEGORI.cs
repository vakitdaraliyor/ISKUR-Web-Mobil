namespace SOADHEADERWS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KATEGORI")]
    public partial class KATEGORI
    {
        [Key]
        public int KATEGORI_REFNO { get; set; }

        [Required]
        [StringLength(30)]
        public string KATEGORI_ADI { get; set; }
    }
}
