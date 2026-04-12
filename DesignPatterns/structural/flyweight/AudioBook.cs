using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace DesignPatterns.structural.flyweight
{
    public class AudioBook : IBook
    {
        public void Read()
        {
            Console.WriteLine("Listening audiobook (Book=" + GetHashCode() + ")");
        }
    }
}
