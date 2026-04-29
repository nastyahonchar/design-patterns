using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.decorator
{
    public class SpecialBook : BookDecorator
    {
        public SpecialBook(IBook book) : base(book) { }

        public override void GetDescription()
        {
            base.GetDescription();
            Console.WriteLine("+ special edition");
        }

        public override int GetPrice()
        {
            return base.GetPrice() + 50;
        }
    }
}
