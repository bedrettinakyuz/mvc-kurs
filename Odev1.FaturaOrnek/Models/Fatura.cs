using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Odev1.FaturaOrnek.Models
{
    public class Fatura
    {
        public int FaturaID { get; set; }

        public decimal GenelToplam { get; set; }

        public DateTime KayitZamani { get; set; }

        public int KullaniciID { get; set; }

        public bool Onaylandi { get; set; }

        public bool Yazdirildi { get; set; }

        public virtual List<FaturaDetay> FaturaDetay { get; set; }
    }
}