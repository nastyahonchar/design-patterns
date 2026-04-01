using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.creational.factory_method
{
    public class OnlineBook : Book
    {
        private BookType type;

        public OnlineBook(BookType type)
        {
            this.type = type;
        }

        public string GetInfo()
        {
            return "Online book: " + type.ToString().ToLower();
        }
    }
}
