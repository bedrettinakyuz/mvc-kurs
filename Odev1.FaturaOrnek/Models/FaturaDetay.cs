using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Odev1.FaturaOrnek.Models
{
    public class FaturaDetay
    {
        public int FaturaDetayID { get; set; }

        public int FaturaID { get; set; }

        public int StokID { get; set; }

        public decimal Miktar { get; set; }

        public decimal SatisFiyati { get; set; }

        public decimal Toplam { get; set; }

        public virtual Fatura Fatura { get; set; }


    }

}