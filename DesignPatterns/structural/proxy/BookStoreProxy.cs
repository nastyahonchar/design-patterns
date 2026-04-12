using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.proxy
{
    public class BookStoreProxy : IBookStore
    {
        private readonly BookStore bookStore = new BookStore();
        private readonly HashSet<string> premiumUsers;

        public BookStoreProxy(HashSet<string> premiumUsers)
        {
            this.premiumUsers = premiumUsers;
        }

        public void ViewBook(string userName, string bookTitle)
        {
            if (premiumUsers.Contains(userName))
            {
                bookStore.ViewBook(userName, bookTitle);
            }
            else
            {
                Console.WriteLine($"{userName} cannot view '{bookTitle}' — premium access only!");
            }
        }
    }
}
