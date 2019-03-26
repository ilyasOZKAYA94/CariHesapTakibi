using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.CariHesap.Cl.Context;

namespace BLL.CariHesap.Cl.Repositories
{
    public class CariHareketRepository : ICariHareketRepository
    {
        CariContext ent = new CariContext();
        public bool CariHareketEkle(CariHareket ch)
        {
            bool Sonuc = false;
            ent.CariHareketler.Add(ch);
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

        public bool CariHareketGuncelle()
        {
            throw new NotImplementedException();
        }

        public List<CariHareket> CariHareketlerListele()
        {
            throw new NotImplementedException();
        }

        public bool CariHareketSil(CariHareket ch)
        {
            throw new NotImplementedException();
        }

        public bool CariHareketSil(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
