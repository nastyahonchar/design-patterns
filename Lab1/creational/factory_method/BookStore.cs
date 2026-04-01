using Lab1.creational.factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.creational.factory_method
{
    public interface BookStore
    {
        Book CreateBook(BookType type);
    }
}
