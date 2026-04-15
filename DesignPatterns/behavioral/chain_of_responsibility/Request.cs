using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.chain_of_responsibility
{
    public class Request
    {
        public RequestType Type { get; }
        public string Description { get; }
        public bool Handled { get; private set; }

        public Request(RequestType type, string description)
        {
            Type = type;
            Description = description;
        }

        public void MarkHandled()
        {
            Handled = true;
        }

        public override string ToString()
        {
            return Description;
        }
    }
}
