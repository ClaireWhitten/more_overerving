using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening2_Book
{
    class CoffeeTableBook : Book
    {
        private double price; 
        public override double Price
        {
            get { return price; } 
            set
            {
                if (value >= 35 && value <= 100)
                    price = value; 
            }
        }

        public CoffeeTableBook(int isbn, string title, string author) : base(isbn, title, author)
        {

        }

        public CoffeeTableBook() : base()
        {

        }


    }
}
