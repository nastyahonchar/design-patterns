using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.mediator.members
{
    public interface OrderMember
    {
        void SetMediator(IOrderMediator mediator);
        void Receive(OrderAction action);
        void Send(OrderAction action);
    }
}
