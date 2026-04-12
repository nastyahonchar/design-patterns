using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.proxy
{
    public interface IBookStore
    {
        void ViewBook(string userName, string bookTitle);
    }
}
