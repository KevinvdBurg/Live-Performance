using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Classes
{
    class Matriaal
    {
        public string Naam { get; set; }

        public Boot Boot { get; set; }

        public Matriaal(string naam, Boot boot)
        {
            Naam = naam;
            Boot = boot;
        }
    }
}
