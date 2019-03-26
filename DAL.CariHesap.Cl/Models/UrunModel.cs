using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CariHesap.Cl.Models
{
    public class UrunModel
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; }
        public int Miktar { get; set; }
        public int KritikSeviye { get; set; }
        public decimal Fiyat { get; set; }
    }
}
