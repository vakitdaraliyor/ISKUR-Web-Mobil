namespace SOADHEADERWS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALT_KATEGORI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ALT_KATEGORI()
        {
            URUNs = new HashSet<URUN>();
        }

        [Key]
        public int ALT_KATEGORI_REFNO { get; set; }

        [Required]
        [StringLength(30)]
        public string ALT_KATEGORI_ADI { get; set; }

        public int KATEGORI_REFNO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<URUN> URUNs { get; set; }
    }
}
