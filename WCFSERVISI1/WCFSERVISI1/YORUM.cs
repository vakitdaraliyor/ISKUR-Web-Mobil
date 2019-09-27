namespace WCFSERVISI1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("YORUM")]
    public partial class YORUM
    {
        [Key]
        public int YORUM_REFNO { get; set; }

        public int YAZI_REFNO { get; set; }

        [Required]
        [StringLength(50)]
        public string MAIL { get; set; }

        [Required]
        [StringLength(50)]
        public string ADI_SOYADI { get; set; }

        public bool DURUMU { get; set; }

        [Column(TypeName = "date")]
        public DateTime TARIH { get; set; }

        [Required]
        [StringLength(50)]
        public string IP { get; set; }

        [Required]
        [StringLength(150)]
        public string YORUM_ICERIK { get; set; }
    }
}
