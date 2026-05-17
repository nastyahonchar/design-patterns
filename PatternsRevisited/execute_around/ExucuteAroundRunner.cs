using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsRevisited.execute_around
{
    public class ExecuteAroundRunner
    {
        public static void Run()
        {
            Console.WriteLine("--------Execute Around--------");
            BookSession.Use(session => session
                .Browse()
                .AddToCart("Clean Code")
                .Checkout(250m));
        }
    }
}
