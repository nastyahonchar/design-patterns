using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.chain_of_responsibility
{
    public class SupportService : IRequestHandler
    {
        public bool CanHandle(Request req)
        {
            return req.Type == RequestType.RETURN;
        }

        public int Priority => 3;

        public void Handle(Request req)
        {
            req.MarkHandled();
            Console.WriteLine($"{Name} processed {req}");
        }

        public string Name => "Support Service";
    }
}
