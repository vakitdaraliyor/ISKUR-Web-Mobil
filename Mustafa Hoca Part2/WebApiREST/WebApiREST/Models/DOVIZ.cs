namespace WebApiREST.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOVIZ")]
    public partial class DOVIZ
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DOVIZ_REFNO { get; set; }

        [Required]
        [StringLength(20)]
        public string PARA_BIRIMI { get; set; }

        [Required]
        [StringLength(2)]
        public string SIMGESI { get; set; }
    }
}
