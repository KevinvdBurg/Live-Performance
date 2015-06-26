using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Classes
{
    class Incident : Waarnaming
    {
        public bool Politie { get; set; } // kijkt of het een politie incident is

        public Incident(string datum, string naam, string tekst, bool politie)
            : base(datum, naam, tekst)
        {
            this.Politie = politie;
        }
    }
}
