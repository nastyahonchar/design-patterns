using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.chain_of_responsibility
{
    public interface IRequestHandler
    {
        bool CanHandle(Request req);
        int Priority { get; }
        void Handle(Request req);
        string Name { get; }
    }
}
