using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllatokCsoportMunka
{
    class Allat
    {
        public string Nev { get; set; }
        public string Kontinens {  get; set; }
        public double Elettartam { get; set; }
        public string Taplalek {  get; set; }
        public string Osztaly {  get; set; }

        public Allat(string sor)
        {

            string[] adatok = sor.Split(";");
            Nev = adatok[0];
            Kontinens = adatok[1];
            Elettartam = double.Parse(adatok[2]);
            Taplalek = adatok[3];
            Osztaly = adatok[4];

        }

        public Allat()
        {
            
        }
    }
}
