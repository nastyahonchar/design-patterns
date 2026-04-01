using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.creational.abstract_factory
{
    public class UAFactory : IBookFactory
    {
        public IBook CreateBook()
        {
            return new UABook();
        }

        public IDescription CreateDescription()
        {
            return new UADescription();
        }
    }
}
