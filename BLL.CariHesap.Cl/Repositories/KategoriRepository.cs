using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.CariHesap.Cl.Context;

namespace BLL.CariHesap.Cl.Repositories
{
    public class KategoriRepository : IKategoriRepository
    {
        CariContext ent = new CariContext();
        public bool KategoriEkle(Kategori k)
        {
            bool Sonuc = false;
            ent.Kategoriler.Add(k);
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
        public Kategori KategoriGetirByID(int ID)
        {
            Kategori degisen = (from c in ent.Kategoriler
                                  where c.Id == ID
                                  select c).FirstOrDefault();
            return degisen;
        }
        public bool KategoriKontrol(Kategori yeni)
        {
            return Convert.ToBoolean(ent.Kategoriler.Where(k => k.KategoriAdi == yeni.KategoriAdi).ToList().Count);
        }
        public bool KategoriKontrolFromDegistir(Kategori yeni)
        {
            return Convert.ToBoolean(ent.Kategoriler.Where(k => k.KategoriAdi == yeni.KategoriAdi && k.Id != yeni.Id).ToList().Count);
        }
        public bool KategoriGuncelle()
        {
            bool Sonuc = false;
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
        public List<Kategori> KategoriListele()
        {
            return ent.Kategoriler.Where(k => k.Silindi == false).ToList();
        }
        public bool KategoriSil(Kategori k)
        {
            bool Sonuc = false;
            ent.Kategoriler.Remove(k);
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
        public bool KategoriSil(int ID)
        {
            bool Sonuc = false;
            Kategori silinen = (from c in ent.Kategoriler
                                where c.Id == ID
                                select c).FirstOrDefault();
            silinen.Silindi = true;
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
    }
}
