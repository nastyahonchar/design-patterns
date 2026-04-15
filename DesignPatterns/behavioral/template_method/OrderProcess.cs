using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.template_method
{
    public abstract class OrderProcess
    {
        protected abstract string SelectBook();

        protected abstract void ProcessPayment(string book);

        protected abstract void Deliver(string book);

        public void ProcessOrder()
        {
            var book = SelectBook();
            Console.WriteLine($"Book selected: {book}");

            ProcessPayment(book);
            Deliver(book);
        }
    }
}
