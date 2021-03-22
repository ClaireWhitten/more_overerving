using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening4_Geometric
{
    class Vierkant : Rechthoek
    {
        //set breedte and hoogte to read-only?

       /*
        public override int Hoogte { get { return base.Hoogte; } }

        public override int Breedte { get { return base.Breedte; } }
       */


        //constructors
        public Vierkant(int breedte, int hoogte)
        {
            if (breedte == hoogte)
            {
                Breedte = breedte;
                Hoogte = hoogte;
            } else
            {
                hoogte = breedte;
                Breedte = breedte;
                Hoogte = hoogte;
            }
        }

        public Vierkant(int nummer)
        {
            Breedte = nummer;
            Hoogte = nummer;
        }

        public override int BerekenOppervlakte()
        {
            return base.BerekenOppervlakte(); // uses the rechthoek implementation 
        }
    }
}
