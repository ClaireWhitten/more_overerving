using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToString
{
    class Pokemon
    {
        public int Level { get; set; }

        public int Leeftijd { get; set; }
        public string Naam { get; set; }

        public Pokemon(string naam, int leeftijd, int level)
        {
            Naam = naam;
            Leeftijd = leeftijd;
            Level = level;
        }

        public override string ToString()
        {
            return $"Pokemon stats: {Naam}, {Leeftijd}, {Level}";
        }
    }
}
