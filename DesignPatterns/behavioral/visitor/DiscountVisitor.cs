using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.visitor
{
    public class DiscountVisitor : IBookVisitor
    {
        public void Visit(FictionBook book)
        {
            Console.WriteLine($"{book.Title}: final price = {book.Price * 0.9m} (fiction discount)");
        }

        public void Visit(ScienceBook book)
        {
            Console.WriteLine($"{book.Title}: final price = {book.Price * 0.95m} (science discount)");
        }

        public void Visit(HistoryBook book)
        {
            Console.WriteLine($"{book.Title}: final price = {book.Price * 0.85m} (history discount)");
        }
    }
}
