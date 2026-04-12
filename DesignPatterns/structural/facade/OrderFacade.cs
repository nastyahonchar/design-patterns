using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.facade
{
    public class OrderFacade
    {
        private readonly List<StoreService> services;

        public OrderFacade()
        {
            services = new List<StoreService>
            {
                new CartService(),
                new PaymentService(),
                new DeliveryService()
            };
        }

        public void PlaceOrder()
        {
            StartServices();
            ProcessOrder();
            FinishServices();
        }

        private void StartServices()
        {
            services.ForEach(s => s.Start());
        }

        private void ProcessOrder()
        {
            services.ForEach(s => s.Process());
        }

        private void FinishServices()
        {
            services.ForEach(s => s.Stop());
        }
    }
}
