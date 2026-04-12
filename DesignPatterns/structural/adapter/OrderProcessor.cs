using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.adapter
{
    public class OrderProcessor
    {
        private readonly IDelivery delivery;

        public OrderProcessor(IDelivery delivery)
        {
            this.delivery = delivery;
        }

        public void ProcessOrder()
        {
            Console.WriteLine("Processing order...");
            delivery.Deliver();
        }
    }
}
