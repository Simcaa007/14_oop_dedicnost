using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class ZamestnanecZK : Zamestnanec
    {
        public bool ZkracenyUvazek { get; set; }

        public ZamestnanecZK(string j, DateTime n, int p, bool zkraceny) : base (j, n, p)
        {
            ZkracenyUvazek = zkraceny;
        }

        public bool Vek55()
        {
            TimeSpan rozdil = DateTime.Now - narozen;
            int r = rozdil.Days / 365;
            if (r > 55)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override double PojistneZamestnanec()
        {
            if (ZkracenyUvazek && Vek55())
            {
                return Plat * 0.015;
            }

            return Plat * 0.065;
        }

        public override string ToString()
        {
            return base.ToString() + 
                $"\nuvazek {(ZkracenyUvazek ? "zkraceny uvazek" : "plny uvazek")}";
        }
    }
}
