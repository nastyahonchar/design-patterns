using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.chain_of_responsibility
{
    public class StoreManager
    {
        private List<IRequestHandler> handlers;

        public StoreManager(List<IRequestHandler> handlers)
        {
            this.handlers = handlers;
        }

        public void Process(Request req)
        {
            handlers
                .OrderBy(h => h.Priority)
                .FirstOrDefault(h => h.CanHandle(req))
                ?.Handle(req);
        }
    }
}
