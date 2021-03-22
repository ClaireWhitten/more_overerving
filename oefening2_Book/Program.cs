using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening2_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(123456, "Harry Potter", "JK Rowling");
            TextBook textbook1 = new TextBook(123456, "Learn to Code", "Tim Dams");
            CoffeeTableBook coffeetablebook1 = new CoffeeTableBook(789054, "The Girl on the Train","Paula Hawkins");

            book1.Price = 90;
            textbook1.Price = 90; //won't work 
            coffeetablebook1.Price = 20; //won't work

            coffeetablebook1.Price = 40; //works

            Console.WriteLine(book1); 
            Console.WriteLine(textbook1);  //price 0
            Console.WriteLine(coffeetablebook1); 

            



            if (book1.Equals(textbook1)) //check same ISBNs
            {
                Console.WriteLine("De ISBN nummers van deze twee boeken zijn gelijk");
            } else
            {
                Console.WriteLine("De ISBN nummers van deze twee boeken zijn niet gelijk");
            }

            Console.ReadLine();
        }
    }
}
