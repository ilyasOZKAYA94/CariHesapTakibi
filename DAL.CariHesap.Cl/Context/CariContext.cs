using DAL.CariHesap.Cl.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DAL.CariHesap.Cl.Context
{
    public class CariContext : DbContext
    {
        public CariContext() : base("CariContext")
        {
            //Migration işlemleri için DbContext (PIContext) ile Migration eşleştirilmelidir.
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CariContext, Configuration>("CariContext"));
            this.Configuration.LazyLoadingEnabled = false; //İlişkili tablolara (Urunler gibi) sorgu çekmiyor, EagerLoading çalışıyor.
        }
        
        //Veritabanında oluşmasını istediğimiz tablolara karşılık gelen sınıflarımızı DbSet koleksiyonları şeklinde tanımlıyoruz.
        public virtual DbSet<Kategori> Kategoriler { get; set; }
        public virtual DbSet<Urun> Urunler { get; set; }
        public virtual DbSet<UrunHareket> UrunHareketler { get; set; }
        public virtual DbSet<Cari> Cariler { get; set; }
        public virtual DbSet<CariHareket> CariHareketler { get; set; }
        public virtual DbSet<KasaHareket> KasaHareketler { get; set; }
    }
}
