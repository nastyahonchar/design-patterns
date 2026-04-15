using DesignPatterns.behavioral.mediator.members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.mediator
{
    public interface IOrderMediator
    {
        void AddMember(OrderMember member);
        void Notify(OrderMember sender, OrderAction action);
    }
}
