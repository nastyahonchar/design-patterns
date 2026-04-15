using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.visitor
{
    public interface IBookVisitor
    {
        void Visit(FictionBook book);
        void Visit(ScienceBook book);
        void Visit(HistoryBook book);
    }
}
