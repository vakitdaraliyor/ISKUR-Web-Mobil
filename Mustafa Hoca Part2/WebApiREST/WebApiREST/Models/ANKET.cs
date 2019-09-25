namespace WebApiREST.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ANKET")]
    public partial class ANKET
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ANKET()
        {
            ANKET_DETAY = new HashSet<ANKET_DETAY>();
        }

        [Key]
        public int ANKET_REFNO { get; set; }

        [Required]
        [StringLength(100)]
        public string SORU { get; set; }

        public bool DURUMU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ANKET_DETAY> ANKET_DETAY { get; set; }
    }
}
