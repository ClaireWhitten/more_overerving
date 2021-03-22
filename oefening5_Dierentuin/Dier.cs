using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening5_Dierentuin
{
    abstract class Dier
    {

        public int Gewicht { get; set; }

        public Dier(int gewicht)
        {
            Gewicht = gewicht;
        }

        public abstract void Zegt();
        

    }
}
