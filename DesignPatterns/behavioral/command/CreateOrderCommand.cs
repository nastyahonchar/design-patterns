using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.command
{
    public class CreateOrderCommand : ICommand
    {
        private OrderCreator creator;

        public CreateOrderCommand(OrderCreator creator)
        {
            this.creator = creator;
        }

        public void Execute()
        {
            creator.Create();
        }
    }
}
