using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.flyweight
{
    public class BookFactory
    {
        private readonly Dictionary<BookType, IBook> books = new Dictionary<BookType, IBook>();

        public IBook CreateBook(BookType type)
        {
            if (!books.ContainsKey(type))
            {
                IBook book = null;

                switch (type)
                {
                    case BookType.EBOOK:
                        book = new Ebook();
                        break;
                    case BookType.PAPER:
                        book = new PaperBook();
                        break;
                    case BookType.AUDIO:
                        book = new AudioBook();
                        break;
                }

                if (book != null)
                {
                    books[type] = book;
                }
            }

            return books[type];
        }
    }
}
