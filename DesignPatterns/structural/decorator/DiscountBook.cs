using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.decorator
{
    public class DiscountBook : BookDecorator
    {
        public DiscountBook(IBook book) : base(book) { }

        public override void GetDescription()
        {
            base.GetDescription();
            Console.WriteLine("+ discount applied");
        }

        public override int GetPrice()
        {
            return base.GetPrice() - 10;
        }
    }
}
