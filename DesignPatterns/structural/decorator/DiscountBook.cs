using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.decorator
{
    public class DiscountBook : IBook
    {
        private readonly IBook book;

        public DiscountBook(IBook book)
        {
            this.book = book;
        }

        public void GetDescription()
        {
            book.GetDescription();
            Console.WriteLine("+ discount applied");
        }

        public int GetPrice()
        {
            return book.GetPrice() - 10;
        }
    }
}
