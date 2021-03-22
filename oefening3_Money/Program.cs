using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening3_Money
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekening rekening1 = new Rekening(); //can't make object - abstract class

            Bankrekening rekening1 = new Bankrekening();
            Spaarrekening rekening2 = new Spaarrekening();
            Prorekening rekening3 = new Prorekening();

            //rekening1.Saldo = 200; //can't - read only 


            rekening1.VoegGeldToe(200);
            Console.WriteLine(rekening1.Saldo);
            rekening1.HaalGeldAf(50);
            Console.WriteLine(rekening1.Saldo);
            Console.WriteLine(rekening1.BerekenRente());

            rekening2.VoegGeldToe(2500);
            Console.WriteLine(rekening2.Saldo);
            Console.WriteLine(rekening2.BerekenRente());

            rekening3.VoegGeldToe(6500);
            Console.WriteLine(rekening3.Saldo);
            Console.WriteLine(rekening3.BerekenRente());


            Console.ReadLine();

        }
    }
}
