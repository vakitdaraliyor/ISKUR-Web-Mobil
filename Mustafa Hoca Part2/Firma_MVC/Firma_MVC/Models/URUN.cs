namespace Firma_MVC.Models
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

        [Required(ErrorMessage = "�r�n ad� giriniz")]
        [StringLength(50, ErrorMessage = "�r�n ad� 3 ile 50 karakter aras�nda olmal�d�r.",
                          ErrorMessageResourceName = "", 
                          ErrorMessageResourceType = null, 
                          MinimumLength =3)]
        public string URUN_ADI { get; set; }

        [Column(TypeName = "numeric")]
        [Required(ErrorMessage = "Fiyat� giriniz")]
        public decimal FIYATI { get; set; }

        [Required(ErrorMessage = "Durumu se�iniz")]
        public bool DURUMU { get; set; }

        [Required(ErrorMessage = "Kategori Se�iniz")]
        public int KATEGORI_REFNO { get; set; }

        [Required(ErrorMessage = "KDV oran� se�iniz")]
        public int KDV_ORANI { get; set; }

        [Required(ErrorMessage = "Marka se�iniz")]
        public int MARKA_REFNO { get; set; }

        [StringLength(4000)]
        public string ACIKLAMA { get; set; }

        [Required(ErrorMessage = "�r�n resmi giriniz")]
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
