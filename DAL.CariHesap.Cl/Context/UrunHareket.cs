using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.CariHesap.Cl.Context
{
    [Table("UrunHareketler")]
    public class UrunHareket
    {
        [Key]
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public string IslemTuru { get; set; }
        public int UrunId { get; set; }
        public int CariId { get; set; }
        public string Belge { get; set; }
        public string Birim { get; set; }
        public int Adet { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal Tutar { get; set; }
        [DefaultValue(false)]
        public bool Silindi { get; set; }

        //Relations
        [ForeignKey("UrunId")]
        public virtual Urun Urun { get; set; }
        [ForeignKey("CariId")]
        public virtual Cari Cari { get; set; }

    }
}
