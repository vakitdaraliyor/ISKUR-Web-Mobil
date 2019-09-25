namespace WebApiREST.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("URUN")]
    public partial class URUN
    {
        [Key]
        public int URUN_REFNO { get; set; }

        [Required]
        [StringLength(20)]
        public string STOK_KODU { get; set; }

        [Required]
        [StringLength(100)]
        public string URUN_ADI { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FIYATI { get; set; }

        public int DOVIZ_REFNO { get; set; }

        [StringLength(50)]
        public string RESIM { get; set; }

        [Column(TypeName = "text")]
        public string DETAY { get; set; }

        [Column(TypeName = "numeric")]
        public decimal INDIRIMLI_FIYAT { get; set; }

        public bool INDIRIM_DURUMU { get; set; }

        public int TIKLAMA_SAYISI { get; set; }

        public int KDV_REFNO { get; set; }

        public int ALT_KATEGORI_REFNO { get; set; }

        public bool SPOT_URUN { get; set; }

        public int MARKA_REFNO { get; set; }

        public int ADET { get; set; }

        public bool DURUMU { get; set; }

        public bool FIYAT_LISTESI { get; set; }

        [Column(TypeName = "date")]
        public DateTime? KAYIT_TARIHI { get; set; }

        public virtual ALT_KATEGORI ALT_KATEGORI { get; set; }
    }
}
