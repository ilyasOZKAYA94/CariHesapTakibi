using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.CariHesap.Cl.Context;
using DAL.CariHesap.Cl.Models;

namespace BLL.CariHesap.Cl.Repositories
{
    public class UrunRepository : IUrunRepository
    {
        CariContext ent = new CariContext();
        public bool UrunEkle(Urun u)
        {
            bool Sonuc = false;
            ent.Urunler.Add(u);
            try
            {
                ent.SaveChanges(); 
                Sonuc = true;
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            return Sonuc;
        }

        public bool UrunGuncelle()
        {
            throw new NotImplementedException();
        }

        public List<UrunModel> UrunListele()
        {
            List<UrunModel> liste = (from u in ent.Urunler.Include("Kategoriler")
                                where u.Silindi == false
                                select new UrunModel { Id = u.Id, UrunAdi = u.UrunAdi, KategoriId = u.KategoriId, KategoriAdi = u.Kategori.KategoriAdi, Miktar = u.Miktar, KritikSeviye = u.KritikSeviye, Fiyat = u.Fiyat }).ToList();
            //var liste = ent.Urunler.ToList();
            return liste;
        }
        public bool UrunKontrol(Urun yeni)
        {
            int Sayisi = (from u in ent.Urunler
                          where u.UrunAdi == yeni.UrunAdi && u.KategoriId == yeni.KategoriId
                          select u).Count();
            return Convert.ToBoolean(Sayisi);
        }
        public bool UrunKontrolFromDegistir(Urun degisen)
        {
            var Urun = ent.Urunler.Where(u => u.UrunAdi == degisen.UrunAdi && u.KategoriId == degisen.KategoriId && u.Id != degisen.Id).FirstOrDefault();
            if (Urun != null)
                return true;
            return false;
        }
        public bool UrunSil(Urun u)
        {
            throw new NotImplementedException();
        }

        public bool UrunSil(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
