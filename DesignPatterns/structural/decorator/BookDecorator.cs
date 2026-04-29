using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.decorator
{
    public abstract class BookDecorator : IBook
    {
        protected IBook book;

        protected BookDecorator(IBook book)
        {
            this.book = book;
        }

        public virtual void GetDescription()
        {
            book.GetDescription();
        }

        public virtual int GetPrice()
        {
            return book.GetPrice();
        }
    }
}
