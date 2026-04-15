using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.iterator
{
    public class BookIterator : IIterator<Book>
    {
        private Catalog catalog;
        private int index;
        private Genre genre;

        public BookIterator(Catalog catalog, Genre genre)
        {
            this.catalog = catalog;
            this.genre = genre;
            index = -1;
        }

        public bool HasNext()
        {
            return FindNextIndex() != -1;
        }

        public Book Next()
        {
            index = FindNextIndex();
            if (index != -1)
            {
                return catalog.GetBooks()[index];
            }
            return null;
        }

        private int FindNextIndex()
        {
            var books = catalog.GetBooks();
            var temp = index;

            while (true)
            {
                temp++;

                if (temp >= books.Count)
                {
                    return -1;
                }

                if (genre == Genre.ANY || books[temp].Genre == genre)
                {
                    return temp;
                }
            }
        }
    }
}
