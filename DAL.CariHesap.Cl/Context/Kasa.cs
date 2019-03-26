using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.CariHesap.Cl.Context
{
    public class KasaHareket
    {
        public int Id { get; set; }
        public string KasaTuru { get; set; }
        public DateTime Tarih { get; set; }
        public string IslemTuru { get; set; }
        public int CariId { get; set; }
        public string Belge { get; set; }
        public decimal Giren { get; set; }
        public decimal Cikan { get; set; }
        public string ParaBirimi { get; set; }
        public bool Silindi { get; set; }

        //Relations

    }
}
