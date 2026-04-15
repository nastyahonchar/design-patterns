using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.state
{
    public class NewOrderState : IOrderState
    {
        private Order order;

        public NewOrderState(Order order)
        {
            this.order = order;
        }

        public void OnEnterState()
        {
            Console.WriteLine("Order is created and waiting for processing.");
        }

        public void Handle()
        {
            Console.WriteLine("Order is not shipped yet.");
        }
    }
}
