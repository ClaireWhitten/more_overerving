using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_overerving
{
    class Persoon : System.Object
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }

        public Persoon(string naam, int leeftijd)
        {
            Naam = naam;
            Leeftijd = leeftijd;
        }

        public override string ToString()
        {
            return $"{GetType().Name}, {GetHashCode()}";
        }

        public override bool Equals(object obj)
        {
            Persoon temp = (Persoon)obj;
            return (Naam == temp.Naam && Leeftijd == temp.Leeftijd);
        }
    }
}
