using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Pracovnik
    {
        public string Jmeno { get; }
        public int ZakldniPlat { get; set; }
        public int Premie {  get; set; }

        public DateTime datumNastupu;

        public Pracovnik(string j, int plat, int premie, DateTime datum) 
        {
            Jmeno = j;
            ZakldniPlat = plat;
            Premie = premie;
            datumNastupu = datum;
        }

        public bool ZkusebniDoba()
        {
            DateTime zkusebka = datumNastupu.AddMonths(3);

            if (zkusebka >= DateTime.Now) return false;
            else return true;
        }

        public void HrubaMzda()
        {
            if (!ZkusebniDoba())
            {
                ZakldniPlat += Premie;
            }
        }

        public override string ToString()
        {
            return $"pracovnik: {Jmeno}\n" +
                $"plat: {ZakldniPlat}\n" +
                $"premie: {Premie}\n" +
                $"zkusebni doba: {(ZkusebniDoba() ? "ano" : "ne")}";
        }
    }
}
