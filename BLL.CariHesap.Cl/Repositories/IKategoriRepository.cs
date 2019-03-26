using DAL.CariHesap.Cl.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.CariHesap.Cl.Repositories
{
    public interface IKategoriRepository
    {
        bool KategoriEkle(Kategori k);
        bool KategoriGuncelle();
        bool KategoriSil(Kategori k);
        bool KategoriSil(int ID);
        List<Kategori> KategoriListele();
    }
}
