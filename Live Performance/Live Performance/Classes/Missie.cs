using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Classes
{
    class Missie
    {
        public int ID { get; set; }
        public string Naam { get; set; }

        public bool Actief  { get; set; }
       
        public string DatumVertrek { get; set; }

        public string DatumTerug { get; set; }

        public bool Goedgekeurd  { get; set; }

        public Location Location { get; set; }

        public Missie(int id, string naam, bool actief, string datumVertrek, string datumTerug, bool goedgekeurd, Location location)
        {
            ID = id;
            Naam = naam;
            Actief = actief;
            DatumVertrek = datumVertrek;
            DatumTerug = datumTerug;
            Goedgekeurd = goedgekeurd;
            Location = location;
        }

    }
}
