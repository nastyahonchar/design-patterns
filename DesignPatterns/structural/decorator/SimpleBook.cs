using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.decorator
{
    public class SimpleBook : IBook
    {
        public void GetDescription()
        {
            Console.WriteLine("Simple book");
        }

        public int GetPrice()
        {
            return 100;
        }
    }
}
