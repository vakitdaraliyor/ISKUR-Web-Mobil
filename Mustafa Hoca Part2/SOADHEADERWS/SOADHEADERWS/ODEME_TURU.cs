namespace SOADHEADERWS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ODEME_TURU
    {
        [Key]
        public int ODEME_TURU_REFNO { get; set; }

        [Required]
        [StringLength(20)]
        public string ODEME_ADI { get; set; }
    }
}
