using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.observer
{
    public class Book
    {
        private BookStatus status;
        private List<ISubscriber> subscribers = new List<ISubscriber>();

        public Book()
        {
            status = BookStatus.OUT_OF_STOCK;
        }

        public void Subscribe(ISubscriber sub)
        {
            subscribers.Add(sub);
        }

        public void Unsubscribe(ISubscriber sub)
        {
            subscribers.Remove(sub);
        }

        public void ChangeStatus()
        {
            status = status == BookStatus.OUT_OF_STOCK
                ? BookStatus.AVAILABLE
                : BookStatus.OUT_OF_STOCK;

            Console.WriteLine($"Book status changed to {status}");
            NotifySubscribers();
        }

        private void NotifySubscribers()
        {
            foreach (var sub in subscribers)
            {
                sub.Update(status);
            }
        }
    }
}
