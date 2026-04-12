using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.facade
{
    public class CartService : StoreService
    {
        public override void Process()
        {
            Console.WriteLine(Name() + " checks cart.");
        }

        public override string Name()
        {
            return "Cart service";
        }
    }
}
