using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.CariHesap.Cl.Context
{
    [Table("Urunler")]
    public class Urun
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string UrunAdi { get; set; }
        public int KategoriId { get; set; }

        [NotMapped]
        public string KategoriAdi { get; set; }
        public int Miktar { get; set; }
        public int KritikSeviye { get; set; }
        public decimal Fiyat { get; set; }
        [DefaultValue(false)]
        public bool Silindi { get; set; }

        //Relations
        [ForeignKey("KategoriId")]
        public virtual Kategori Kategori { get; set; }
        public virtual List<UrunHareket> UrunHareketler { get; set; }
    }
}
