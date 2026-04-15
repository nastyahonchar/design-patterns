using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.visitor
{
    public class AvailabilityVisitor : IBookVisitor
    {
        public void Visit(FictionBook book)
        {
            Console.WriteLine($"{book.Title}: available for sale");
        }

        public void Visit(ScienceBook book)
        {
            Console.WriteLine($"{book.Title}: available for sale");
        }

        public void Visit(HistoryBook book)
        {
            Console.WriteLine($"{book.Title}: temporarily out of stock");
        }
    }
}
