using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.adapter
{
    public class CourierDeliveryAdapter : IDelivery
    {
        private readonly CourierDelivery courierDelivery = new CourierDelivery();

        public void Deliver()
        {
            courierDelivery.Ship();
        }
    }
}
