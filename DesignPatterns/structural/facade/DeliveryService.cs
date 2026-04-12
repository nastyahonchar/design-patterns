using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.facade
{
    public class DeliveryService : StoreService
    {
        public override void Process()
        {
            Console.WriteLine(Name() + " delivers order.");
        }

        public override string Name()
        {
            return "Delivery service";
        }
    }
}
