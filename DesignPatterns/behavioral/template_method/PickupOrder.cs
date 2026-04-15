using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.template_method
{
    public class PickupOrder : OrderProcess
    {
        protected override string SelectBook()
        {
            return "Design Patterns";
        }

        protected override void ProcessPayment(string book)
        {
            Console.WriteLine($"Paying for {book} at the store...");
        }

        protected override void Deliver(string book)
        {
            Console.WriteLine($"Order ready for pickup: {book}");
        }
    }
}
