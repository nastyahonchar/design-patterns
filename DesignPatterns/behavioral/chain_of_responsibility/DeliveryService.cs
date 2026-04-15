using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.chain_of_responsibility
{
    public class DeliveryService : IRequestHandler
    {
        public bool CanHandle(Request req)
        {
            return req.Type == RequestType.DELIVERY;
        }

        public int Priority => 2;

        public void Handle(Request req)
        {
            req.MarkHandled();
            Console.WriteLine($"{Name} processed {req}");
        }

        public string Name => "Delivery Service";
    }
}
