using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.strategy
{
    public class Order
    {
        private IPaymentStrategy paymentStrategy;

        public Order(IPaymentStrategy strategy)
        {
            paymentStrategy = strategy;
        }

        public void ChangeStrategy(IPaymentStrategy strategy)
        {
            paymentStrategy = strategy;
        }

        public void Checkout(decimal amount)
        {
            paymentStrategy.Pay(amount);
        }
    }
}
