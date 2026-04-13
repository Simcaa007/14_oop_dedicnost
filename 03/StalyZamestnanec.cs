using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class StalyZamestnanec : Pracovnik
    {
        public int stabilizacniPrispevek;

        public StalyZamestnanec(string j, int plat, int premie, DateTime datum, int stab)
            : base(j, plat, premie, datum)
        {
            this.stabilizacniPrispevek = stab;
        }

        public override double HrubaMzda()
        {
            DateTime vicenezdeset = datumNastupu.AddYears(10);
            if (vicenezdeset > DateTime.Now)
            {
                return base.HrubaMzda() + stabilizacniPrispevek;
            }
            else
            {
                return base.HrubaMzda();
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"\n" +
                $"";
        }
    }
}
