using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.bridge
{
    public class FantasyBook : Book
    {
        public FantasyBook(IFormat format) : base(format) { }

        public override void Read()
        {
            Console.WriteLine("Reading fantasy book.");
            format.Use();
        }
    }
}
