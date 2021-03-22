using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening3_Money
{
    class Bankrekening : Rekening
    {
        public override double BerekenRente()
        {
            if (Saldo > 100)
            {
                return Saldo * 0.05;
            } else
            {
                return 0;
            }
        }

    }
}
