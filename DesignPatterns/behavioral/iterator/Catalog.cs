using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.iterator
{
    public class Catalog
    {
        private List<Book> books;

        public Catalog(List<Book> books)
        {
            this.books = books;
        }

        public IIterator<Book> GetIterator(Genre genre)
        {
            return new BookIterator(this, genre);
        }

        public List<Book> GetBooks()
        {
            return new List<Book>(books);
        }
    }
}
