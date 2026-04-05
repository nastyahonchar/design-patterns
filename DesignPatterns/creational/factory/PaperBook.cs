using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.creational.factory
{
    public class PaperBook : Book
    {
        public string GetDescription()
        {
            return "This is a paper book.";
        }
    }
}
