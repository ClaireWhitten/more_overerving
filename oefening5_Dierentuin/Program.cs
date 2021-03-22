using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening5_Dierentuin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dier> Dieren = new List<Dier>();

            AddDieren(Dieren);

        
        }



        static void AddDieren(List<Dier> Dieren)
        {
            while (true)
            {
                Console.Clear();
                showList(Dieren);
                Console.WriteLine("\nWelke dieren moeten toegevoegd worden? (Druk \"q\" te stoppen.)\n");
                Console.WriteLine("1.Hond\n2.Cat\n3.Muis");
                string keuze = Console.ReadLine();
                if (keuze == "q")
                {
                    break;
                }
                switch (keuze)
                {
                    case "1":
                        Console.Write("\n Kies een gewicht voor de hond:");
                        Dieren.Add(new Hond(Convert.ToInt32(Console.ReadLine())));
                        break;
                    case "2":
                        Console.Write("\nKies een gewicht voor de cat:");
                        Dieren.Add(new Cat(Convert.ToInt32(Console.ReadLine())));
                        break;
                    case "3":
                        Console.Write("\nKies een gewicht voor de muis:");
                        Dieren.Add(new Muis(Convert.ToInt32(Console.ReadLine())));
                        break;

                }

            }
            KeuzeMenu(Dieren);
        }

        static void KeuzeMenu(List<Dier> Dieren)
        {
            Console.Clear();
            showList(Dieren);
            Console.WriteLine("\nKies een optie:\n");
            Console.WriteLine("1. Dier Verwijderen \n2. Diergewicht Gemiddelde \n3. Dier Praten \n4. Opnieuw Beginnen");
            string keuze = Console.ReadLine();
            switch (keuze)
            {
                case "1": DierVerwijderen(Dieren); break;
                case "2": GemiddeldeGewicht(Dieren); break;
                case "3": DierPraten(Dieren); break;
                case "4": 
                    Dieren.Clear();
                    AddDieren(Dieren);
                    break;
            }
        }

        static void DierVerwijderen(List<Dier> Dieren)
        {
            Console.Clear();
            Console.WriteLine("Hoeveel dieren will je verwijderen?");
            int hoeveel = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < hoeveel; i++)
            {
               if (hoeveel <= Dieren.Count)
                {
                    Dieren.RemoveAt(Dieren.Count-1);
                } else
                {
                    Console.WriteLine("Te veel. Je kan deze aantal niet verwijderen.");
                }
            }
            Console.ReadLine();
            KeuzeMenu(Dieren);
        }

        static void GemiddeldeGewicht(List<Dier> Dieren)
        {
            Console.Clear();
            double totaalgewicht = 0;
            foreach (var dier in Dieren)
            {
                totaalgewicht = totaalgewicht + dier.Gewicht;
            }
            Console.WriteLine($"Het gemiddelde gewicht van alle dieren is {Math.Round(totaalgewicht/Dieren.Count, 2)}kg.");
            Console.ReadLine();
            KeuzeMenu(Dieren);
        }

        static void DierPraten(List<Dier> Dieren)
        {
            Console.Clear();
            foreach (var dier in Dieren)
            {
                dier.Zegt();
            }
            Console.ReadLine();
            KeuzeMenu(Dieren);
        }

        static void showList(List<Dier> Dieren)
        {
            Console.Write("Huidige List:   ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var dier in Dieren)
            {
                Console.Write($"{dier.GetType().Name} ({dier.Gewicht}kg)   ");
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
