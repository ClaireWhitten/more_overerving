using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening4_Geometric
{
    class Program
    {
        static void Main(string[] args)
        {
            Rechthoek rechthoek1 = new Rechthoek();
            rechthoek1.Hoogte = 5;
            rechthoek1.Breedte = 6;
            Console.WriteLine(rechthoek1.BerekenOppervlakte()); 



            Vierkant vierkant1 = new Vierkant(5,4);
            Console.WriteLine(vierkant1.BerekenOppervlakte());
            // je kan nog vierkant1.Hoogte = doen 

            



            Driehoek driehoek1 = new Driehoek();
            driehoek1.Breedte = 3;
            driehoek1.Hoogte = 10;
            Console.WriteLine(driehoek1.BerekenOppervlakte());


            Console.ReadLine();

        }
    }
}
