using DAL.CariHesap.Cl.Context;
using DAL.CariHesap.Cl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.CariHesap.Cl.Repositories
{
    public interface IUrunRepository
    {
        bool UrunEkle(Urun u);
        bool UrunGuncelle();
        bool UrunSil(Urun u);
        bool UrunSil(int ID);
        List<UrunModel> UrunListele();


    }
}
