using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllatokCsoportMunka
{
    class Allat
    {
        public string Név { get; set; }
        public string Kontinens {  get; set; }
        public int Elettartam { get; set; }
        public string Táplálék {  get; set; }
        public string Osztály {  get; set; }

        public Allat(string[] sorok)
        {
            foreach (var sor in sorok)
            {
                string[] adatok = sor.Split(",");
                Név = adatok[0];
                Kontinens = adatok[1];
                Elettartam = int.Parse(adatok[2]);
                Táplálék = adatok[3];
                Osztály = adatok[4];
            }
        }
    }
}
