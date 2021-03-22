using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening5_Dierentuin
{
    class Cat : Dier
    {
        public Cat(int gewicht) : base(gewicht)
        {

        }

        public override void Zegt()
        {
            Console.WriteLine("Meeoow");
        }
    }
}
