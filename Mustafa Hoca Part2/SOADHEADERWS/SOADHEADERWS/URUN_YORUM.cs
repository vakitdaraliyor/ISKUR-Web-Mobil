namespace SOADHEADERWS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class URUN_YORUM
    {
        [Key]
        public int URUN_YORUM_REFNO { get; set; }

        public int UYE_REFNO { get; set; }

        [Required]
        [StringLength(200)]
        public string ICERIK { get; set; }

        [Column(TypeName = "date")]
        public DateTime TARIH { get; set; }

        public int? URUN_REFNO { get; set; }
    }
}
