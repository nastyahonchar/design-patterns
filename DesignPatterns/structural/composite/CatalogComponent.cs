using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.composite
{
    public abstract class CatalogComponent
    {
        protected readonly List<CatalogComponent> Children = new List<CatalogComponent>();

        public virtual void Add(CatalogComponent component)
        {
            Children.Add(component);
        }

        public virtual void Print()
        {
            Children.ForEach(c => c.Print());
        }
    }
}
