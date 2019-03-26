using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.CariHesap.Cl.Context
{
    [Table("CariHareketler")]
    public class CariHareket
    {
        [Key]
        public int Id { get; set; }
        public string IslemTuru { get; set; }
        public DateTime Tarih { get; set; }
        public int? CariId { get; set; }
        public string Belge { get; set; }
        public decimal Borc { get; set; }
        public decimal Alacak { get; set; }
        public int KasaHareketId { get; set; }
        [DefaultValue(false)]
        public bool Silindi { get; set; }

        //Relations
        [ForeignKey("CariId")]
        public virtual Cari Cari { get; set; }

        [ForeignKey("KasaHareketId")]
        public virtual KasaHareket KasaHareket { get; set; }
    }
}
