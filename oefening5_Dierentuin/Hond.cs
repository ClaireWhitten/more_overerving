using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening5_Dierentuin
{
    class Hond : Dier
    {

        public Hond(int gewicht) : base(gewicht)
        {

        }


        public override void Zegt()
        {
            Console.WriteLine("Woof Woof");
        }


    }
}
