using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening4_Geometric
{
    class Driehoek : GeometricFigure
    {
        public override int BerekenOppervlakte()
        {
            return Breedte * Hoogte / 2;  
        }
    }
}
