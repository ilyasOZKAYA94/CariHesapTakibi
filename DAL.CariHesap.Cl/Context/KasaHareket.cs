using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.CariHesap.Cl.Context
{
    [Table("KasaHareketler")]
    public class KasaHareket
    {
        [Key]
        public int Id { get; set; }
        public string KasaTuru { get; set; }
        public DateTime Tarih { get; set; }
        public string IslemTuru { get; set; }
        public int CariId { get; set; }
        public string Belge { get; set; }
        public decimal Giren { get; set; }
        public decimal Cikan { get; set; }
        public string ParaBirimi { get; set; }
        [DefaultValue(false)]
        public bool Silindi { get; set; }

        //Relations
        [ForeignKey("CariId")]
        public virtual Cari Cari { get; set; }
    }
}
