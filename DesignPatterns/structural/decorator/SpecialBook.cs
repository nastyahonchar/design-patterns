using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.decorator
{
    public class SpecialBook : IBook
    {
        private readonly IBook book;

        public SpecialBook(IBook book)
        {
            this.book = book;
        }

        public void GetDescription()
        {
            book.GetDescription();
            Console.WriteLine("+ special edition (colored edges, premium cover)");
        }

        public int GetPrice()
        {
            return book.GetPrice() + 50;
        }
    }
}
