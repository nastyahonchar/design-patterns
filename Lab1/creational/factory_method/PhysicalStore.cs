using Lab1.creational.factory_method.DesignPatternsLab1.Creational.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.creational.factory_method
{
    public class PhysicalStore : BookStore
    {
        private static readonly Dictionary<BookType, Book> books;

        static PhysicalStore()
        {
            books = new Dictionary<BookType, Book>();

            foreach (BookType type in System.Enum.GetValues(typeof(BookType)))
            {
                books[type] = new PhysicalBook(type);
            }
        }

        public Book CreateBook(BookType type)
        {
            return books[type];
        }

        public override string ToString()
        {
            return "Physical Store";
        }
    }
}
