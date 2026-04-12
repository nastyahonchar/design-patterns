using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.composite
{
    public class Category : CatalogComponent
    {
        public string Name { get; }

        public Category(string name)
        {
            Name = name;
        }

        public override void Print()
        {
            Console.WriteLine($"Category: {Name}");
            base.Print();
        }
    }
}
