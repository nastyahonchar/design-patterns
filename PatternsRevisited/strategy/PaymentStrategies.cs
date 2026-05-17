using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsRevisited.strategy
{
    public static class PaymentStrategies
    {
        public static readonly Action<decimal> CardPayment =
            amount => Console.WriteLine($"Paid {amount} using card.");

        public static readonly Action<decimal> CashPayment =
            amount => Console.WriteLine($"Paid {amount} in cash.");

        public static readonly Action<decimal> PayPalPayment =
            amount => Console.WriteLine($"Paid {amount} via PayPal.");
    }

    public record Order(decimal Amount, Action<decimal> PaymentStrategy)
    {
        public Order WithStrategy(Action<decimal> strategy) =>
            new Order(Amount, strategy);

        public void Checkout() => 
            PaymentStrategy(Amount);
    }
}
