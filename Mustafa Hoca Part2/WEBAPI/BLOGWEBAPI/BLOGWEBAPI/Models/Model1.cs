namespace BLOGWEBAPI.Models
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

        public virtual DbSet<KATEGORI> KATEGORIs { get; set; }
        public virtual DbSet<KULLANICI> KULLANICIs { get; set; }
        public virtual DbSet<SAYFA> SAYFAs { get; set; }
        public virtual DbSet<YAZI> YAZIs { get; set; }
        public virtual DbSet<YORUM> YORUMs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KATEGORI>()
                .Property(e => e.KATEGORI_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<KULLANICI>()
                .Property(e => e.KULLANICI_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<KULLANICI>()
                .Property(e => e.PAROLA)
                .IsUnicode(false);

            modelBuilder.Entity<SAYFA>()
                .Property(e => e.BASLIK)
                .IsUnicode(false);

            modelBuilder.Entity<SAYFA>()
                .Property(e => e.ICERIK)
                .IsUnicode(false);

            modelBuilder.Entity<YAZI>()
                .Property(e => e.BASLIK)
                .IsUnicode(false);

            modelBuilder.Entity<YAZI>()
                .Property(e => e.ICERIK)
                .IsUnicode(false);

            modelBuilder.Entity<YAZI>()
                .Property(e => e.OZET)
                .IsUnicode(false);

            modelBuilder.Entity<YAZI>()
                .Property(e => e.RESIM)
                .IsUnicode(false);

            modelBuilder.Entity<YORUM>()
                .Property(e => e.MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<YORUM>()
                .Property(e => e.ADI_SOYADI)
                .IsUnicode(false);

            modelBuilder.Entity<YORUM>()
                .Property(e => e.IP)
                .IsUnicode(false);

            modelBuilder.Entity<YORUM>()
                .Property(e => e.YORUM_ICERIK)
                .IsUnicode(false);
        }
    }
}
