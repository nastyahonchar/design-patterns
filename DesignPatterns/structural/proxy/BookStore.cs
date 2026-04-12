using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.proxy
{
    public class BookStore : IBookStore
    {
        public void ViewBook(string userName, string bookTitle)
        {
            Console.WriteLine($"{userName} is viewing the book: {bookTitle}");
        }
    }
}
