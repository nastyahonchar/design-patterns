using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.visitor
{
    public abstract class Book
    {
        public string Title { get; }
        public decimal Price { get; }

        protected Book(string title, decimal price)
        {
            Title = title;
            Price = price;
        }

        public abstract void Accept(IBookVisitor visitor);
    }
}
