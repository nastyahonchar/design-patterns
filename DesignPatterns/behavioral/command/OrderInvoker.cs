using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.command
{
    public class OrderInvoker
    {
        private ICommand command;

        public OrderInvoker(ICommand command)
        {
            this.command = command;
        }

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void Invoke()
        {
            command.Execute();
        }
    }
}
