using DAL.CariHesap.Cl.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.CariHesap.Cl.Repositories
{
    public interface ICariRepository
    {
        bool CariEkle(Cari c);
        bool CariGuncelle();
        bool CariSil(Cari c);
        bool CariSil(int ID);
        List<Cari> CarileriListele();
        List<Cari> CarileriListeleByCariTipi(string CariTipi);
        List<Cari> CarileriListeleByUnvan(string Unvan);
        bool CariToplamlariGuncelle(int Id, decimal Borc, decimal Alacak);

    }
}
