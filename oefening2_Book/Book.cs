using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening2_Book
{
    class Book
    {

        public int ISBN { get; set; }
        public string Title { get; set; }

        public string Author { get; set; }

        private double price;

        public virtual double Price
        {
            get { return price; }
            set { price = value; }
        }

        //constructors - 1 overloaded , 1 default 
        public Book(int isbn, string title, string author)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
        }

        public Book()
        {
            
        }


        public static Book TelOp(Book book1, Book book2)
        {
            Book omnibusbook = new Book();
            omnibusbook.Price = (book1.Price + book2.Price) / 2;
            omnibusbook.Title = $"Omnibus van {book1.Author}, {book2.Author}";
            return omnibusbook;
            
        }

        public override string ToString()
        {
            return $"{Title} - {Author} ({ISBN}) {Price}";
        }

        public override bool Equals(object obj)
        {
            Book temp = (Book)obj; //cast object parameter to a book object
            return ISBN.Equals(temp.ISBN);
        }


    }
}
