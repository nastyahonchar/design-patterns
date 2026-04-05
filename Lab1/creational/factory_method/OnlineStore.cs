using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.creational.factory_method
{
    public class OnlineStore : BookStore
    {
        private static readonly Dictionary<BookType, Book> books;

        static OnlineStore()
        {
            books = new Dictionary<BookType, Book>();

            foreach (BookType type in System.Enum.GetValues(typeof(BookType)))
            {
                books[type] = new OnlineBook(type);
            }
        }

        public Book CreateBook(BookType type)
        {
            return books[type];
        }

        public override string ToString()
        {
            return "Online Store";
        }
    }
}
