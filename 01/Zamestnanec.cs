using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Zamestnanec
    {
        protected string jmeno;
        protected DateTime narozen;
        protected int Plat {  get; set; }

        public Zamestnanec(string j, DateTime n, int p)
        {
            jmeno = j;
            narozen = n;
            Plat = p;
        }

        public double PojistneZamestnavatel()
        {
            return (Plat / 100) * 24.8;
        }

        public virtual double PojistneZamestnanec()
        {
            return (Plat / 100) * 6.5;
        }

        public override string ToString()
        {
            return $"zamestnanec: {jmeno}\n" +
                $"narozen/a: {narozen}\n" +
                $"plat ma: {Plat}\n" +
                $"socialni pojisteni: {PojistneZamestnanec()}";
        }
    }
}
