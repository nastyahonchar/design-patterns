using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.creational.factory_method
{
    public interface BookStore
    {
        Book CreateBook(BookType type);
    }
}
