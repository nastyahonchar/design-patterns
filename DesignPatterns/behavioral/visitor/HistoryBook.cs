using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.visitor
{
    public class HistoryBook : Book
    {
        public HistoryBook(string title, decimal price) : base(title, price) { }

        public override void Accept(IBookVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
