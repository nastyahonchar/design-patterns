using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.state
{
    public class ShippedOrderState : IOrderState
    {
        private Order order;

        public ShippedOrderState(Order order)
        {
            this.order = order;
        }

        public void OnEnterState()
        {
            Console.WriteLine("Order has been shipped.");
        }

        public void Handle()
        {
            Console.WriteLine("Order is on the way to the customer.");
        }
    }
}
