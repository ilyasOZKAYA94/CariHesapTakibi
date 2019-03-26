using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.CariHesap.Cl.Context;

namespace BLL.CariHesap.Cl.Repositories
{
    public class CariRepository : ICariRepository
    {
        CariContext ent = new CariContext();
        public bool CariEkle(Cari c)
        {
            throw new NotImplementedException();
        }

        public bool CariGuncelle()
        {
            throw new NotImplementedException();
        }

        public List<Cari> CarileriListele()
        {
            return ent.Cariler.Where(c => c.Silindi==false).ToList();
        }

        public List<Cari> CarileriListeleByCariTipi(string CariTipi)
        {
            return ent.Cariler.Where(c => c.Silindi == false && c.CariTipi==CariTipi).ToList();
        }

        public List<Cari> CarileriListeleByUnvan(string Unvan)
        {
            return ent.Cariler.Where(c => c.Silindi == false && c.Unvan.StartsWith(Unvan)).ToList();
        }
        public List<Cari> CarileriListeleByUnvanAndCariTipi(string Unvan, string CariTipi)
        {
            return ent.Cariler.Where(c => c.Silindi == false && c.Unvan.StartsWith(Unvan) && c.CariTipi == CariTipi).ToList();
        }
        public bool CariSil(Cari c)
        {
            throw new NotImplementedException();
        }

        public bool CariSil(int ID)
        {
            throw new NotImplementedException();
        }

        public bool CariToplamlariGuncelle(int Id, decimal Borc, decimal Alacak)
        {
            bool Sonuc = false;
            //Değiştirilecek Cariyi bul.
            var degisen = (from c in ent.Cariler
                           where c.Id == Id
                           select c).FirstOrDefault();
            //Toplamları update et.
            degisen.ToplamBorc += Borc;
            degisen.ToplamAlacak += Alacak;
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
