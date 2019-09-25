namespace WSSession.Model
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
        [StringLength(50)]
        public string URUN_ADI { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FIYATI { get; set; }

        public bool DURUMU { get; set; }

        public int KATEGORI_REFNO { get; set; }

        public int KDV_ORANI { get; set; }

        public int MARKA_REFNO { get; set; }

        [StringLength(4000)]
        public string ACIKLAMA { get; set; }

        [Required]
        [StringLength(50)]
        public string RESIM1 { get; set; }

        [StringLength(50)]
        public string RESIM2 { get; set; }

        [StringLength(50)]
        public string RESIM3 { get; set; }

        [StringLength(50)]
        public string RESIM4 { get; set; }

        public virtual KATEGORI KATEGORI { get; set; }

        public virtual MARKA MARKA { get; set; }
    }
}
