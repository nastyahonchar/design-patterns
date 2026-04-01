using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.creational.factory
{
    public class BookFactory
    {
        public static Book CreateBook(BookType type)
        {
            switch (type)
            {
                case BookType.EBOOK:
                    return new EBook();
                case BookType.PAPER:
                    return new PaperBook();
                case BookType.AUDIO:
                    return new AudioBook();
                default:
                    throw new ArgumentException("Unknown BookType");
            }
        }
    }
}
