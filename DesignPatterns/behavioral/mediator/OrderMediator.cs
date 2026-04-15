using DesignPatterns.behavioral.mediator.members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.mediator
{
    public class OrderMediator : IOrderMediator
    {
        private List<OrderMember> members = new List<OrderMember>();

        public void AddMember(OrderMember member)
        {
            members.Add(member);
            member.SetMediator(this);
        }

        public void Notify(OrderMember sender, OrderAction action)
        {
            foreach (var member in members)
            {
                if (member != sender)
                {
                    member.Receive(action);
                }
            }
        }
    }
}
