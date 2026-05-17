using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsRevisited.decorator
{
    public record BookInfo(string Description, int Price);

    public static class BookDecorators
    {
        public static BookInfo SimpleBook() =>
            new BookInfo("Simple book", 100);

        public static Func<BookInfo> WithSpecialEdition(Func<BookInfo> book) =>
            () =>
            {
                var b = book();
                return new BookInfo(
                    b.Description + "\n+ special edition",
                    b.Price + 50
                );
            };

        public static Func<BookInfo> WithDiscount(Func<BookInfo> book) =>
            () =>
            {
                var b = book();
                return new BookInfo(
                    b.Description + "\n+ discount applied",
                    b.Price - 10
                );
            };
    }
}
