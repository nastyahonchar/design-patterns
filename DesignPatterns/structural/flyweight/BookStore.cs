using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.flyweight
{
    public class BookStore
    {
        private readonly List<IBook> shelf1;
        private readonly List<IBook> shelf2;

        public BookStore(List<IBook> shelf1, List<IBook> shelf2)
        {
            this.shelf1 = shelf1;
            this.shelf2 = shelf2;
        }

        public void ReadBooks()
        {
            foreach (var book in shelf1)
            {
                book.Read();
            }

            foreach (var book in shelf2)
            {
                book.Read();
            }
        }
    }
}
