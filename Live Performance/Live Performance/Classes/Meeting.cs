using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Classes
{
    class Meeting : Waarnaming
    {
        public Location Location { get; set; }

        public Meeting(string datum, string naam, string tekst, Location location)
            : base(datum, naam, tekst)
        {
            this.Location = location;
        }
    }
}
