using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening2_Book
{
    class TextBook : Book
    {
        public int GradeLevel { get; set; }

        private double price; 
        public override double Price
        {
            get { return price; } 
            set
            {
                if (value >= 20 && value <= 80)
                  price = value; 
            }
        }

        public TextBook(int isbn, string title, string author) : base(isbn, title, author)
        {

        }

        public TextBook() : base()
        {

        }

    }
}
