using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Pracka : Spotrebic
    {
        public bool ProdlouzenaZaruka {  get; set; }

        public Pracka(string kod, double cena, DateTime datumVyroby, DateTime datumProdeje)
            : base(kod, cena, datumVyroby, datumProdeje)
        {
        }

        public Pracka(string kod, double cena, DateTime datumVyroby, DateTime datumProdeje, bool prod)
            : base ( kod,  cena,  datumVyroby,  datumProdeje)
        {
            ProdlouzenaZaruka = prod;
        }

        public override double CelkovaCena()
        {
            if (ProdlouzenaZaruka)
            {
                return base.CelkovaCena() + 2000;
            }
            else
            {
                return base.CelkovaCena();
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"\nprodlouzena zaruka: " +
                $"{(ProdlouzenaZaruka ? "ano" : "ne")}";
        }
    }
}
