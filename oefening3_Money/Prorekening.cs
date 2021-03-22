using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening3_Money
{
    class Prorekening : Spaarrekening
    {

        public override double BerekenRente()
        {
            
            int aantalDuizend = Saldo / 1000;
            return base.BerekenRente() + (aantalDuizend * 10);

            
        }
    }
}
