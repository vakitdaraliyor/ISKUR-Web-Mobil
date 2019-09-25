namespace WebApiREST.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DUYURU")]
    public partial class DUYURU
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DUYURU_REFNO { get; set; }

        [Required]
        [StringLength(255)]
        public string BASLIK { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string DETAY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime BASLANGIC_TARIHI { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime BITIS_TARIHI { get; set; }

        public bool DURUMU { get; set; }
    }
}
