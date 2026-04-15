using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.memento
{
    public class OrderHistory
    {
        private Stack<IOrderMemento> history = new Stack<IOrderMemento>();

        public void Save(IOrderMemento memento)
        {
            history.Push(memento);
        }

        public IOrderMemento Undo()
        {
            return history.Pop();
        }
    }
}
