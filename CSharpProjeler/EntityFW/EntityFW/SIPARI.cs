//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFW
{
    using System;
    using System.Collections.Generic;
    
    public partial class SIPARI
    {
        public int SIPARIS_REFNO { get; set; }
        public Nullable<int> MUSTERI_REFNO { get; set; }
        public string SIPARIS_TIPI { get; set; }
        public Nullable<System.DateTime> SIPARIS_TARIHI { get; set; }
        public Nullable<System.DateTime> TESLIM_TARIHI { get; set; }
        public string ADRES { get; set; }
        public string SEHIR { get; set; }
        public string ILGILI_KISI { get; set; }
        public string ACIKLAMA { get; set; }
    }
}