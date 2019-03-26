namespace DAL.CariHesap.Cl.Migrations
{
    using DAL.CariHesap.Cl.Context;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.CariHesap.Cl.Context.CariContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "DAL.CariHesap.Cl.Context.CariContext";
        }

        protected override void Seed(DAL.CariHesap.Cl.Context.CariContext context)
        {
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //context.Kategoriler.AddOrUpdate(
            //    new Kategori { Id = 1, KategoriAdi = "Gömlekler", Aciklama = "Kısa ve Uzun Kollu" },
            //    new Kategori { Id = 2, KategoriAdi = "Kazaklar", Aciklama = "Yünlü kazaklar" },
            //    new Kategori { Id = 3, KategoriAdi = "Pantolonlar", Aciklama = "Kumaş ve kot pantolonlar" },
            //    new Kategori { Id = 4, KategoriAdi = "Ceketler", Aciklama = "Klasik ve spor ceketler" }
            //    );
        }
    }
}
