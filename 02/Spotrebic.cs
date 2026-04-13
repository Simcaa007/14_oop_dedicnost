using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Spotrebic
    {
        public string Kod { get; } = "1F82E";
        public double Cena {  get; set; }
        public DateTime datumVyroby;
        public DateTime datumProdeje;

        public Spotrebic (string kod, double cena, DateTime datumVyroby, DateTime datumProdeje)
        {
            Kod = kod;
            Cena = cena;
            this.datumVyroby = datumVyroby;
            this.datumProdeje = datumProdeje;
        }

        public bool VeSleve()
        {
            TimeSpan rozdil =  datumVyroby - datumProdeje;
            double r = rozdil.Days / 365;

            if (r >= 1)
            {
                return true;
            }
            else return false;
        }

        public virtual double CelkovaCena()
        {
            if (VeSleve())
            {
                double dph = Cena * 1.21;
                double sleva = dph * 0.90;
                return sleva;
            }
            else
            {
                return Cena * 1.21;
            }
        }

        public override string ToString()
        {
            return $"kod spotrebice: {Kod}\n" +
                $"cena: {Cena}\n" +
                $"datum vyroby: {datumVyroby}\n" +
                $"datum prodeje: {datumProdeje}\n" +
                $"sleva: {(VeSleve() ? "ano" : "ne")}\n" +
                $"celkova cena: {CelkovaCena()}";
        }
    }
}
