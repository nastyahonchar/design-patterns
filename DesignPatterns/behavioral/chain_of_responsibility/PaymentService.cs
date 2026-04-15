using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.chain_of_responsibility
{
    public class PaymentService : IRequestHandler
    {
        public bool CanHandle(Request req)
        {
            return req.Type == RequestType.PAYMENT;
        }

        public int Priority => 1;

        public void Handle(Request req)
        {
            req.MarkHandled();
            Console.WriteLine($"{Name} processed {req}");
        }

        public string Name => "Payment Service";
    }
}
