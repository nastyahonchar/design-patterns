using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.bridge
{
    public class EbookFormat : IFormat
    {
        public void Open()
        {
            Console.WriteLine("Opening ebook.");
        }

        public void Use()
        {
            Console.WriteLine("Reading ebook.");
        }

        public void Close()
        {
            Console.WriteLine("Closing ebook.");
        }
    }
}
