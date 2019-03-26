using DAL.CariHesap.Cl.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.CariHesap.Cl.Repositories
{
    public interface IKasaRepository
    {
        bool KasaHareketEkle(KasaHareket kh);

        bool KasaCariHareketEkle(KasaHareket kh);
        bool KasaHareketGuncelle();
        bool KasaHareketSil(KasaHareket kh);
        bool KasaHareketSil(int ID);
        List<KasaHareket> KasaHareketlerListele();
        List<Decimal> KasaDevirleriToTarih(DateTime Tarih);

        List<KasaHareket> KasaHareketlerByTarih(DateTime Tarih);
    }
}
