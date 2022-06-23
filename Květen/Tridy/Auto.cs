using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_kveten.Tridy
{
    internal class Auto
    {
        public string Model { get; set; }
        public int PocetSedadel { get; set; }
        public string DruhPohonu { get; set; }
        public int Cena { get; set; }
        public string Obrazek { get; set; }

        public string Znacka = "Tesla";

        public int RokVyroby = DateTime.Now.Year;
    }
}
