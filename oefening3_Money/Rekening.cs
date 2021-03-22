using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening3_Money
{
    abstract class Rekening
    {
        private int saldo;

        public int Saldo
        {
            get { return saldo;}
        }


        public void VoegGeldToe(int hoeveel)
        {
            saldo = saldo + hoeveel;
        }

        public void HaalGeldAf(int hoeveel)
        {
            saldo = saldo - hoeveel;
        }

        public abstract double BerekenRente(); //rente = interest
       

       


    }
}
