using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.creational.prototype
{
    public class Book : IPrototype
    {
        private string title;
        private int pages;

        public Book(string title, int pages)
        {
            this.title = title;
            this.pages = pages;
        }

        public IPrototype Clone()
        {
            return new Book(title, pages);
        }

        public override string ToString()
        {
            return $"Book: {title}, Pages: {pages}";
        }

        public override bool Equals(object obj)
        {
            if (obj is not Book other)
                return false;

            return title == other.title && pages == other.pages;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(title, pages);
        }
    }
}
