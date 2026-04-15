using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.state
{
    public class Order
    {
        private IOrderState state;

        public Order()
        {
            state = new NewOrderState(this);
        }

        public void NextState()
        {
            if (state is NewOrderState)
            {
                ChangeState(new ShippedOrderState(this));
            }
            else
            {
                ChangeState(new NewOrderState(this));
            }
        }

        private void ChangeState(IOrderState newState)
        {
            state = newState;
            state.OnEnterState();
        }

        public void Handle()
        {
            state.Handle();
        }
    }
}
