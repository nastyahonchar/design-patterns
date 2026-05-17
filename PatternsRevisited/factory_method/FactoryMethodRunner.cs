using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsRevisited.factory_method
{
    public class FactoryMethodRunner
    {
        public static void Run()
        {
            Console.WriteLine("--------Factory Method--------");
            var onlineBook = BookFactory.OnlineStore(BookType.EBOOK);
            Console.WriteLine(onlineBook.Description);

            var physicalBook = BookFactory.PhysicalStore(BookType.PAPER);
            Console.WriteLine(physicalBook.Description);
        }
    }
}

