﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FIRMA_ASPX
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FIRMAEntities : DbContext
    {
        public FIRMAEntities()
            : base("name=FIRMAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<KATEGORI> KATEGORIs { get; set; }
        public virtual DbSet<KULLANICI> KULLANICIs { get; set; }
        public virtual DbSet<MARKA> MARKAs { get; set; }
        public virtual DbSet<PROJE> PROJEs { get; set; }
        public virtual DbSet<SAYFA> SAYFAs { get; set; }
        public virtual DbSet<SLIDER> SLIDERs { get; set; }
        public virtual DbSet<URUN> URUNs { get; set; }
        public virtual DbSet<urunler> urunlers { get; set; }
    }
}
