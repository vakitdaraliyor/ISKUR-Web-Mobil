//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KUTUPHANE
{
    using System;
    using System.Collections.Generic;
    
    public partial class UYE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UYE()
        {
            this.ODUNC_KITAP = new HashSet<ODUNC_KITAP>();
        }
    
        public int UYE_REFNO { get; set; }
        public string ADI_SOYADI { get; set; }
        public string ADRES { get; set; }
        public string TELEFON { get; set; }
        public string EMAIL { get; set; }
        public System.DateTime EKLEME_TARIHI { get; set; }
        public bool DURUMU { get; set; }
        public string ACIKLAMA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ODUNC_KITAP> ODUNC_KITAP { get; set; }
    }
}