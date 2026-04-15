using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.template_method
{
    public class Customer
    {
        private OrderProcess orderProcess;

        public Customer(OrderProcess orderProcess)
        {
            this.orderProcess = orderProcess;
        }

        public void MakeOrder()
        {
            orderProcess.ProcessOrder();
        }

        public void ChangeOrderProcess(OrderProcess orderProcess)
        {
            this.orderProcess = orderProcess;
        }
    }
}
