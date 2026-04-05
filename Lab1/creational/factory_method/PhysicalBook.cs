using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.creational.factory_method
{
    public class PhysicalBook : Book
    {
        private BookType type;

        public PhysicalBook(BookType type)
        {
            this.type = type;
        }

        public string GetInfo()
        {
            return "Physical book: " + type.ToString().ToLower();
        }
    }
}

