using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.visitor
{
    public class DescriptionVisitor : IBookVisitor
    {
        public void Visit(FictionBook book)
        {
            Console.WriteLine($"{book.Title}: Fiction book full of imagination and adventure.");
        }

        public void Visit(ScienceBook book)
        {
            Console.WriteLine($"{book.Title}: Scientific book with educational content.");
        }

        public void Visit(HistoryBook book)
        {
            Console.WriteLine($"{book.Title}: Historical book describing past events.");
        }
    }
}
