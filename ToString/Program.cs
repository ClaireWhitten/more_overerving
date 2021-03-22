using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToString
{
    class Program
    {
        static void Main(string[] args)
        {
            //pokemon to string
            Pokemon pokemon1 = new Pokemon("Pikkachu", 100, 25);
            Console.WriteLine(pokemon1);


    
            List<BookMark> bookmarks = new List<BookMark>();


           //bookmark
            bookmarks.Add(new BookMark());
           Console.WriteLine("Naam:");
           bookmarks[0].Naam = Console.ReadLine();
           Console.WriteLine("URL:");
           bookmarks[0].URL = Console.ReadLine();


            //hidden bookmark
            bookmarks.Add(new HiddenBookMark());
            Console.WriteLine("Naam:");
            bookmarks[1].Naam = Console.ReadLine();
            Console.WriteLine("URL:");
            bookmarks[1].URL = Console.ReadLine();


            //to string both
            for (int i = 0; i < bookmarks.Count; i++)
            {
                Console.WriteLine(bookmarks[i]);

            }


            /*
            Console.WriteLine("Kies een nummer om de site te openen");
            int answer = Convert.ToInt32(Console.ReadLine());
            HiddenBookMark correctBookmark = bookmarks[answer - 1];
            correctBookmark.OpenSite(correctBookmark.URL);
            */
            

            Console.ReadLine();
        }
    }
}
