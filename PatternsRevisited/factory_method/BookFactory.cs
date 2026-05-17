using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsRevisited.factory_method
{
    public record BookInfo(string Description);

    public enum BookType { EBOOK, PAPER, AUDIO }

    public static class BookFactory
    {
        public static Func<BookType, BookInfo> OnlineStore =
            type => new BookInfo($"Online book: {type.ToString().ToLower()}");

        public static Func<BookType, BookInfo> PhysicalStore =
            type => new BookInfo($"Physical book: {type.ToString().ToLower()}");
    }
}
