using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.flyweight
{
    public class Ebook : IBook
    {
        public void Read()
        {
            Console.WriteLine("Reading ebook (Book=" + GetHashCode() + ")");
        }
    }
}
