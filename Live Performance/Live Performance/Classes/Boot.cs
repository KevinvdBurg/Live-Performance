using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Classes
{
    class Boot
    {
        public int ID { get; set; }
        public Location Location { get; set; }

        public int MaxPersoon { get; set; }

        public int MacSnelheid { get; set; }

        public string Naam { get; set; }

        public string Type { get; set; } // Grotte van de boot

        public Boot(int id, Location location, int maxPersoon, int macSnelheid, string naam, string type)
        {
            this.ID = id;
            this.Location = location;
            this.MaxPersoon = maxPersoon;
            this.MacSnelheid = macSnelheid;
            this.Naam = naam;
            this.Type = type;
        }
    }
}
