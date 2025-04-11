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

        public Allat(string nev, string kontinens, double elettartam, string taplalek, string osztaly)
        {
            this.Név = nev;
            this.Kontinens = kontinens;
            this.Elettartam = elettartam;
            this.Táplálék = taplalek;
            this.Osztály = osztaly;
        }

        public Allat()
        {
            
        }
    }
}
