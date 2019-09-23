namespace SOADHEADERWS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UYE")]
    public partial class UYE
    {
        [Key]
        public int UYE_REFNO { get; set; }

        [Required]
        [StringLength(30)]
        public string ADI_SOYADI { get; set; }

        [Required]
        [StringLength(10)]
        public string SIFRESI { get; set; }

        [Required]
        [StringLength(10)]
        public string KULLANICI_ADI { get; set; }

        [Required]
        [StringLength(150)]
        public string EV_ADRESI { get; set; }

        [Required]
        [StringLength(11)]
        public string EV_TEL { get; set; }

        [Required]
        [StringLength(20)]
        public string EV_SEHIR { get; set; }

        [Required]
        [StringLength(20)]
        public string EV_ILCE { get; set; }

        [Required]
        [StringLength(11)]
        public string CEP_TEL { get; set; }

        [Required]
        [StringLength(5)]
        public string EV_POSTAKODU { get; set; }

        [Required]
        [StringLength(50)]
        public string MAIL { get; set; }

        public bool DURUMU { get; set; }

        public bool HABER_VER { get; set; }

        [StringLength(20)]
        public string ACTIVATION_CODE { get; set; }
    }
}
