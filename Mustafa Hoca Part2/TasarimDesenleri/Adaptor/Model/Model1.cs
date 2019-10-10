namespace Adaptor.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<DOVIZ> DOVIZs { get; set; }
        public virtual DbSet<KATEGORI> KATEGORIs { get; set; }
        public virtual DbSet<KDV> KDVs { get; set; }
        public virtual DbSet<MARKA> MARKAs { get; set; }
        public virtual DbSet<SIPARIS_DURUMU> SIPARIS_DURUMU { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DOVIZ>()
                .Property(e => e.PARA_BIRIMI)
                .IsUnicode(false);

            modelBuilder.Entity<DOVIZ>()
                .Property(e => e.SIMGESI)
                .IsUnicode(false);

            modelBuilder.Entity<KATEGORI>()
                .Property(e => e.KATEGORI_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<KDV>()
                .Property(e => e.KDV_ORANI)
                .HasPrecision(2, 0);

            modelBuilder.Entity<MARKA>()
                .Property(e => e.MARKA_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<MARKA>()
                .Property(e => e.LOGO)
                .IsUnicode(false);

            modelBuilder.Entity<MARKA>()
                .Property(e => e.URL)
                .IsUnicode(false);

            modelBuilder.Entity<SIPARIS_DURUMU>()
                .Property(e => e.DURUMU_ADI)
                .IsUnicode(false);
        }
    }
}
