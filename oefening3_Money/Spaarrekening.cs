using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening3_Money
{
    class Spaarrekening : Rekening
    {
        public override double BerekenRente()
        {
                return Saldo * 0.02;
        }

    }
}
