using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening5_Dierentuin
{
    class Muis : Dier
    {

        public Muis (int gewicht) : base(gewicht)
        {

        }

        public override void Zegt()
        {
            Console.WriteLine("Squeak Squeak");
        }
    }
}
