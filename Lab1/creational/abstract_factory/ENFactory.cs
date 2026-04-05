using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.creational.abstract_factory
{
    public class ENFactory : IBookFactory
    {
        public IBook CreateBook()
        {
            return new ENBook();
        }

        public IDescription CreateDescription()
        {
            return new ENDescription();
        }
    }
}
