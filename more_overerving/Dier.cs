using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_overerving
{
    abstract class Dier
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public abstract int MaxLeeftijd { get; }

        public abstract string MaakGeluid();
    }
}
