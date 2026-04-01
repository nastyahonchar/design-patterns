using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.creational.factory
{
    public class AudioBook : Book
    {
        public string GetDescription()
        {
            return "This is an audio book.";
        }
    }
}
