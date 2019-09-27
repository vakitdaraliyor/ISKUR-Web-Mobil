namespace WCFSERVISI1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("YAZI")]
    public partial class YAZI
    {
        [Key]
        public int YAZI_REFNO { get; set; }

        [Required]
        [StringLength(10)]
        public string BASLIK { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string ICERIK { get; set; }

        [Column(TypeName = "date")]
        public DateTime TARIH { get; set; }

        public bool DURUMU { get; set; }

        public int KATEGORI_REFNO { get; set; }

        public int TIKLAMA_SAYISI { get; set; }

        [Required]
        [StringLength(250)]
        public string OZET { get; set; }

        [StringLength(150)]
        public string RESIM { get; set; }
    }
}
