using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.CariHesap.Cl.Context;

namespace BLL.CariHesap.Cl.Repositories
{
    public class KasaRepository : IKasaRepository
    {
        CariContext ent = new CariContext();

        public List<decimal> KasaDevirleriToTarih(DateTime Tarih)
        {
            List<Decimal> Devirler = new List<decimal>();
            Tarih = Convert.ToDateTime(Tarih.ToShortDateString());
            decimal Giren = (from k in ent.KasaHareketler
                         where k.Silindi == false && k.Tarih < Tarih
                         select k.Giren).DefaultIfEmpty(0).Sum();
            Devirler.Add(Giren);
            decimal Cikan = (from k in ent.KasaHareketler
                             where k.Silindi == false && k.Tarih < Tarih
                             select k.Cikan).DefaultIfEmpty(0).Sum();
            Devirler.Add(Cikan);
            Devirler.Add(Giren - Cikan);
            return Devirler;
        }
        public List<KasaHareket> KasaHareketlerByTarih(DateTime Tarih)
        {
            var Hareketler = (from k in ent.KasaHareketler
                             where k.Silindi == false && k.Tarih.Month == Tarih.Month && k.Tarih.Day == Tarih.Day
                             select k).ToList();
            return Hareketler;
        }
        public bool KasaHareketEkle(KasaHareket kh)
        {
            bool Sonuc = false;
            ent.KasaHareketler.Add(kh);
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

        public bool KasaHareketGuncelle()
        {
            throw new NotImplementedException();
        }



        public List<KasaHareket> KasaHareketlerListele()
        {
            throw new NotImplementedException();
        }

        public bool KasaHareketSil(KasaHareket kh)
        {
            throw new NotImplementedException();
        }

        public bool KasaHareketSil(int ID)
        {
            throw new NotImplementedException();
        }

        public bool KasaCariHareketEkle(KasaHareket kh)
        {
            using (var trans = ent.Database.BeginTransaction())
            {
                bool Sonuc = false;
                try
                {
                    //KasaHareket ekle.
                    ent.KasaHareketler.Add(kh);
                    ent.SaveChanges();

                    //CariHareket ekle.
                    CariHareket ch = new CariHareket();
                    ch.IslemTuru = kh.IslemTuru;
                    ch.Tarih = kh.Tarih;
                    ch.CariId = kh.CariId;
                    ch.Belge = kh.Belge;
                    ch.Borc = kh.Cikan;
                    ch.Alacak = kh.Giren;
                    //ch.KasaHareketId = kh.Id;
                    ch.KasaHareketId = 22;
                    ent.CariHareketler.Add(ch);
                    ent.SaveChanges();

                    //Değiştirilecek cariyi bul.
                    var degisenCari = ( from c in ent.Cariler
                                        where c.Id == ch.CariId
                                        select c).FirstOrDefault();
                    //Cari toplamları güncelle.
                    degisenCari.ToplamBorc += ch.Borc;
                    degisenCari.ToplamAlacak += ch.Alacak;
                    ent.SaveChanges();

                    trans.Commit();
                    Sonuc = true;
                }
                catch (Exception)
                {
                    trans.Rollback();
                }

                return Sonuc;
            }
        }
    }
}
