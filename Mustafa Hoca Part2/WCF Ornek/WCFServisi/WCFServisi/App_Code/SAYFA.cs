namespace WCFServisi.Model1
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
        public int SAYFA_REFNO { get; set; }

        [Required]
        [StringLength(50)]
        public string BASLIK { get; set; }

        [Required]
        public string ICERIK { get; set; }
    }
}