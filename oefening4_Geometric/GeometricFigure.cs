using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening4_Geometric
{
    abstract class GeometricFigure
    {

        public virtual int Hoogte { get; set; }
        public virtual int Breedte { get; set; }

        public int Oppervlakte { get; } //read only because calculated based on height + base using method below 

        public abstract int BerekenOppervlakte();
       
    }
}
