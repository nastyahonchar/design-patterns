using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.command
{
    public class CancelOrderCommand : ICommand
    {
        private OrderCanceler canceler;

        public CancelOrderCommand(OrderCanceler canceler)
        {
            this.canceler = canceler;
        }

        public void Execute()
        {
            canceler.Cancel();
        }
    }
}
