using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsRevisited.decorator
{
    public class DecoratorRunner
    {
        public static void Run()
        {
            Console.WriteLine("--------Decorator--------");
            var simple = BookDecorators.SimpleBook();
            Console.WriteLine(simple.Description);
            Console.WriteLine(simple.Price);

            var decorated = BookDecorators.WithDiscount(
                            BookDecorators.WithSpecialEdition(
                                BookDecorators.SimpleBook));

            var result = decorated();
            Console.WriteLine(result.Description);
            Console.WriteLine(result.Price);
        }
    }
}
