namespace WebApiREST.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("YONETICI")]
    public partial class YONETICI
    {
        [Key]
        public int YONETICI_REFNO { get; set; }

        [Required(ErrorMessage = "Kullan�c� Ad� giriniz")]
        [StringLength(10, ErrorMessage = "En fazla 10 karakter girebilirsiniz")]
        public string KULLANICI_ADI { get; set; }

        [Required(ErrorMessage = "�ifre giriniz")]
        [StringLength(10, ErrorMessage = "En fazla 10 karakter girebilirsiniz")]
        public string SIFRESI { get; set; }

        [Required(ErrorMessage = "�ifre giriniz")]
        public bool DURUMU { get; set; }
    }
}
