using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Classes
{
    public abstract class Waarnaming
    {
        public string Datum { get; set; }

        public string Naam { get; set; }

        public string Tekst { get; set; }

        protected Waarnaming(string datum, string naam, string tekst)
        {
            this.Datum = datum;
            this.Naam = naam;
            this.Tekst = tekst;
        }
    }
}
