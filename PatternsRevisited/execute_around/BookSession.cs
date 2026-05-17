using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsRevisited.execute_around
{
    public class BookSession
    {
        private BookSession() =>
            Console.WriteLine("Opening book session...");

        public static void Use(Action<BookSession> block)
        {
            var session = new BookSession();
            try
            {
                block(session);
            }
            finally
            {
                session.Close();
            }
        }

        public BookSession Browse()
        {
            Console.WriteLine("Browsing books...");
            return this;
        }

        public BookSession AddToCart(string title)
        {
            Console.WriteLine($"Added '{title}' to cart.");
            return this;
        }

        public BookSession Checkout(decimal amount)
        {
            Console.WriteLine($"Checkout completed. Total: {amount}");
            return this;
        }

        private void Close() =>
            Console.WriteLine("Closing book session, cleaning up...");
    }
}
