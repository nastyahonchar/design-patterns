using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.memento
{
    public class Order
    {
        private OrderStatus status;
        private decimal total;

        public Order(OrderStatus status, decimal total)
        {
            this.status = status;
            this.total = total;
        }

        public void Update(OrderStatus newStatus, decimal newTotal)
        {
            status = newStatus;
            total = newTotal;
        }

        public IOrderMemento Save()
        {
            return new OrderMemento(status, total);
        }

        public void Restore(IOrderMemento memento)
        {
            var state = (OrderMemento)memento;
            status = state.Status;
            total = state.Total;
        }

        public override string ToString()
        {
            return $"Status: {status}, Total: {total}";
        }

        private class OrderMemento : IOrderMemento
        {
            public OrderStatus Status { get; }
            public decimal Total { get; }

            public OrderMemento(OrderStatus status, decimal total)
            {
                Status = status;
                Total = total;
            }
        }
    }
}
