namespace SOADHEADERWS
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

        public virtual DbSet<ALT_KATEGORI> ALT_KATEGORI { get; set; }
        public virtual DbSet<ANKET> ANKETs { get; set; }
        public virtual DbSet<ANKET_DETAY> ANKET_DETAY { get; set; }
        public virtual DbSet<DOVIZ> DOVIZs { get; set; }
        public virtual DbSet<DUYURU> DUYURUs { get; set; }
        public virtual DbSet<KATEGORI> KATEGORIs { get; set; }
        public virtual DbSet<KDV> KDVs { get; set; }
        public virtual DbSet<MANSET> MANSETs { get; set; }
        public virtual DbSet<MARKA> MARKAs { get; set; }
        public virtual DbSet<ODEME_TURU> ODEME_TURU { get; set; }
        public virtual DbSet<SAYFA> SAYFAs { get; set; }
        public virtual DbSet<SIPARI> SIPARIS { get; set; }
        public virtual DbSet<SIPARIS_DETAY> SIPARIS_DETAY { get; set; }
        public virtual DbSet<SIPARIS_DURUMU> SIPARIS_DURUMU { get; set; }
        public virtual DbSet<URUN> URUNs { get; set; }
        public virtual DbSet<URUN_YORUM> URUN_YORUM { get; set; }
        public virtual DbSet<UYE> UYEs { get; set; }
        public virtual DbSet<YONETICI> YONETICIs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ALT_KATEGORI>()
                .Property(e => e.ALT_KATEGORI_ADI)
                .IsUnicode(false);

            //modelBuilder.Entity<ALT_KATEGORI>()
            //    .HasMany(e => e.URUNs)
            //    .WithRequired(e => e.ALT_KATEGORI)
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<ANKET>()
                .Property(e => e.SORU)
                .IsUnicode(false);

            modelBuilder.Entity<ANKET_DETAY>()
                .Property(e => e.SECENEK)
                .IsUnicode(false);

            modelBuilder.Entity<DOVIZ>()
                .Property(e => e.PARA_BIRIMI)
                .IsUnicode(false);

            modelBuilder.Entity<DOVIZ>()
                .Property(e => e.SIMGESI)
                .IsUnicode(false);

            modelBuilder.Entity<DUYURU>()
                .Property(e => e.BASLIK)
                .IsUnicode(false);

            modelBuilder.Entity<DUYURU>()
                .Property(e => e.DETAY)
                .IsUnicode(false);

            modelBuilder.Entity<KATEGORI>()
                .Property(e => e.KATEGORI_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<KDV>()
                .Property(e => e.KDV_ORANI)
                .HasPrecision(2, 0);

            modelBuilder.Entity<MANSET>()
                .Property(e => e.BASLIK)
                .IsUnicode(false);

            modelBuilder.Entity<MANSET>()
                .Property(e => e.URL)
                .IsUnicode(false);

            modelBuilder.Entity<MANSET>()
                .Property(e => e.RESIM)
                .IsUnicode(false);

            modelBuilder.Entity<MARKA>()
                .Property(e => e.MARKA_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<MARKA>()
                .Property(e => e.LOGO)
                .IsUnicode(false);

            modelBuilder.Entity<MARKA>()
                .Property(e => e.URL)
                .IsUnicode(false);

            modelBuilder.Entity<ODEME_TURU>()
                .Property(e => e.ODEME_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<SAYFA>()
                .Property(e => e.ADI)
                .IsUnicode(false);

            modelBuilder.Entity<SAYFA>()
                .Property(e => e.ICERIK)
                .IsUnicode(false);

            modelBuilder.Entity<SIPARIS_DETAY>()
                .Property(e => e.DOVIZ_KURU)
                .HasPrecision(6, 4);

            modelBuilder.Entity<SIPARIS_DETAY>()
                .Property(e => e.KDV_ORANI)
                .HasPrecision(2, 0);

            modelBuilder.Entity<SIPARIS_DURUMU>()
                .Property(e => e.DURUMU_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<URUN>()
                .Property(e => e.FIYATI)
                .HasPrecision(7, 2);

            modelBuilder.Entity<URUN>()
                .Property(e => e.RESIM)
                .IsUnicode(false);

            modelBuilder.Entity<URUN>()
                .Property(e => e.DETAY)
                .IsUnicode(false);

            modelBuilder.Entity<URUN>()
                .Property(e => e.INDIRIMLI_FIYAT)
                .HasPrecision(7, 2);

            modelBuilder.Entity<URUN_YORUM>()
                .Property(e => e.ICERIK)
                .IsUnicode(false);

            modelBuilder.Entity<UYE>()
                .Property(e => e.ADI_SOYADI)
                .IsUnicode(false);

            modelBuilder.Entity<UYE>()
                .Property(e => e.SIFRESI)
                .IsUnicode(false);

            modelBuilder.Entity<UYE>()
                .Property(e => e.KULLANICI_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<UYE>()
                .Property(e => e.EV_ADRESI)
                .IsUnicode(false);

            modelBuilder.Entity<UYE>()
                .Property(e => e.EV_TEL)
                .IsUnicode(false);

            modelBuilder.Entity<UYE>()
                .Property(e => e.EV_SEHIR)
                .IsUnicode(false);

            modelBuilder.Entity<UYE>()
                .Property(e => e.EV_ILCE)
                .IsUnicode(false);

            modelBuilder.Entity<UYE>()
                .Property(e => e.CEP_TEL)
                .IsUnicode(false);

            modelBuilder.Entity<UYE>()
                .Property(e => e.EV_POSTAKODU)
                .IsUnicode(false);

            modelBuilder.Entity<UYE>()
                .Property(e => e.MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<UYE>()
                .Property(e => e.ACTIVATION_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<YONETICI>()
                .Property(e => e.KULLANICI_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<YONETICI>()
                .Property(e => e.SIFRESI)
                .IsUnicode(false);
        }
    }
}
