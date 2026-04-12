using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.facade
{
    public class PaymentService : StoreService
    {
        public override void Process()
        {
            Console.WriteLine(Name() + " processes payment.");
        }

        public override string Name()
        {
            return "Payment service";
        }
    }
}
