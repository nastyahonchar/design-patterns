using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.bridge
{
    public class PaperFormat : IFormat
    {
        public void Open()
        {
            Console.WriteLine("Opening paper book.");
        }

        public void Use()
        {
            Console.WriteLine("Reading paper book.");
        }

        public void Close()
        {
            Console.WriteLine("Closing paper book.");
        }
    }
}
