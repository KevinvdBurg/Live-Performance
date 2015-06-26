using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Classes
{
    class Medewerker
    {
        public string Naam { get; set; }

        public string Functie { get; set; }

        public string Gebruikersnaam { get; set; }

        public Medewerker(string naam, string functie, string gebruikersnaam)
        {
            this.Naam = naam;
            this.Functie = functie;
            this.Gebruikersnaam = gebruikersnaam;
        }
    }
}
