using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_overerving
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DoeDingen();
            }
            catch (ZwartGat e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.ReadLine();


            //Dier mijnDier = new Dier();
            Paard paard = new Paard();
            paard.Leeftijd = 7;
            paard.Naam = "Gert";
            Console.WriteLine(paard.MaakGeluid());
            Console.ReadLine();


            Persoon persoon1 = new Persoon("Vincent", 24);
            Persoon persoon2 = new Persoon("Vincent", 24);
            Persoon persoon3 = new Persoon("Ken", 24);

            if (persoon1.Equals(persoon2))
            {
                Console.WriteLine("Deze objecten zijn gelijk!");
            }
            else
            {
                Console.WriteLine("Deze objecten zijn niet gelijk.");
            }

            //Console.WriteLine(persoon.ToString());
            //Console.WriteLine(persoon.GetType().Name);
            //Console.WriteLine(persoon.GetHashCode());

            Console.ReadLine();
        }
        static void DoeDingen()
        {
            //Deze methode doet dingen
            throw new ZwartGat();
        }

    }
}
