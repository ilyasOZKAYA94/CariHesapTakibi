using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.CariHesap.Cl.Context
{
    [Table("Kategoriler")]
    public class Kategori
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string KategoriAdi { get; set; }
        public string Aciklama { get; set; }
        //[DefaultValue(false)]
        public bool Silindi { get; set; }

        //Relations
        public virtual List<Urun> Urunler { get; set; }

        public Kategori()
        {
            Silindi = false;
        }
    }
}
