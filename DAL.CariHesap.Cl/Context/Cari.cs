using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.CariHesap.Cl.Context
{
    [Table("Cariler")]
    public class Cari
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CariTipi { get; set; }
        [Required]
        public string Unvan { get; set; }
        public string Yetkili { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Sehir { get; set; }
        public string VergiNo { get; set; }
        public string VergiDairesi { get; set; }
        public decimal ToplamBorc { get; set; }
        public decimal ToplamAlacak { get; set; }
        public decimal Bakiye { get; set; }
        [DefaultValue(false)]
        public bool Silindi { get; set; }

        //Relations
        public virtual List<CariHareket> CariHareketler { get; set; }
        public virtual List<KasaHareket> KasaHareketler { get; set; }
    }
}
