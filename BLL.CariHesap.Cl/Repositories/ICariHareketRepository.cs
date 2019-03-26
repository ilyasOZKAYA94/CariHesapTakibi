using DAL.CariHesap.Cl.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.CariHesap.Cl.Repositories
{
    public interface ICariHareketRepository
    {
        bool CariHareketEkle(CariHareket ch);
        bool CariHareketGuncelle();
        bool CariHareketSil(CariHareket ch);
        bool CariHareketSil(int ID);
        List<CariHareket> CariHareketlerListele();
    }
}
