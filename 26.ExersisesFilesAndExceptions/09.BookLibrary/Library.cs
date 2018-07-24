using System.Collections.Generic;
using System.Linq;

namespace _09.BookLibrary
{
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
        public decimal PriceSum => this.Books.Sum(a => a.Price);
    }
}
