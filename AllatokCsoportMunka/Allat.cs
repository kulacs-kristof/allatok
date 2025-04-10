using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllatokCsoportMunka
{
    public class Allat
    {
        public string Név { get; set; }
        public string Kontinens {  get; set; }
        public double Elettartam { get; set; }
        public string Táplálék {  get; set; }
        public string Osztály {  get; set; }

        public Allat(string[] sorok)
        {
            foreach (var sor in sorok.Skip(1))
            {
                string[] adatok = sor.Split(";");
                Név = adatok[0];
                Kontinens = adatok[1];
                Elettartam = double.Parse(adatok[2]);
                Táplálék = adatok[3];
                Osztály = adatok[4];
            }
        }
    }
}
