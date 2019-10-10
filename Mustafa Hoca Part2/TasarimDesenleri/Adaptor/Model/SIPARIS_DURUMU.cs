namespace Adaptor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SIPARIS_DURUMU
    {
        [Key]
        public int SIPARIS_DURUMU_REFNO { get; set; }

        [Required]
        [StringLength(20)]
        public string DURUMU_ADI { get; set; }
    }
}
