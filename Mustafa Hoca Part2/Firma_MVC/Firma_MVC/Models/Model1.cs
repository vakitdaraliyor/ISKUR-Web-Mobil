namespace Firma_MVC.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FIRMAMODEL : DbContext
    {
        public FIRMAMODEL()
            : base("name=FIRMAMODEL")
        {
        }

        public virtual DbSet<KATEGORI> KATEGORIs { get; set; }
        public virtual DbSet<KULLANICI> KULLANICIs { get; set; }
        public virtual DbSet<MARKA> MARKAs { get; set; }
        public virtual DbSet<PROJE> PROJEs { get; set; }
        public virtual DbSet<SAYFA> SAYFAs { get; set; }
        public virtual DbSet<SLIDER> SLIDERs { get; set; }
        public virtual DbSet<URUN> URUNs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KATEGORI>()
                .HasMany(e => e.URUNs)
                .WithRequired(e => e.KATEGORI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MARKA>()
                .HasMany(e => e.URUNs)
                .WithRequired(e => e.MARKA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<URUN>()
                .Property(e => e.FIYATI)
                .HasPrecision(10, 2);

            modelBuilder.Entity<URUN>()
                .Property(e => e.RESIM1)
                .IsUnicode(false);

            modelBuilder.Entity<URUN>()
                .Property(e => e.RESIM2)
                .IsUnicode(false);

            modelBuilder.Entity<URUN>()
                .Property(e => e.RESIM3)
                .IsUnicode(false);

            modelBuilder.Entity<URUN>()
                .Property(e => e.RESIM4)
                .IsUnicode(false);
        }
    }
}
