using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsRevisited.strategy
{
    public class StrategyRunner
    {
        public static void Run()
        {
            Console.WriteLine("--------Strategy--------");
            var order = new Order(250m, PaymentStrategies.CardPayment);
            order.Checkout();

            var updatedOrder = order.WithStrategy(PaymentStrategies.PayPalPayment);
            updatedOrder.Checkout();
        }
    }
}
