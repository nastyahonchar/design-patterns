using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.mediator.members
{
    public abstract class OrderMemberBase : OrderMember
    {
        protected IOrderMediator mediator;

        public void SetMediator(IOrderMediator mediator)
        {
            this.mediator = mediator;
        }

        public void Receive(OrderAction action)
        {
            Console.WriteLine($"{this} received: {action}");
        }

        public void Send(OrderAction action)
        {
            Console.WriteLine($"{this} sends: {action}");
            mediator?.Notify(this, action);
        }

        public abstract override string ToString();
    }
}
