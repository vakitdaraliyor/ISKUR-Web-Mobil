//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF_OGRENIYORUM
{
    using System;
    using System.Collections.Generic;
    
    public partial class SIP_DETAY
    {
        public int SIP_DETAY_REFNO { get; set; }
        public Nullable<int> SIPARIS_REFNO { get; set; }
        public Nullable<int> URUN_REFNO { get; set; }
        public Nullable<float> MIKTAR { get; set; }
        public Nullable<decimal> KDVSIZ_BIRIM_FIYATI { get; set; }
        public string BIRIMI { get; set; }
        public Nullable<int> KDV_ORANI { get; set; }
        public Nullable<decimal> KDV_TUTAR { get; set; }
    }
}
