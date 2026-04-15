using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.template_method
{
    public class OnlineOrder : OrderProcess
    {
        protected override string SelectBook()
        {
            return "Clean Code";
        }

        protected override void ProcessPayment(string book)
        {
            Console.WriteLine($"Paying online for {book} using card...");
        }

        protected override void Deliver(string book)
        {
            Console.WriteLine($"Delivering {book} via courier.");
        }
    }
}
