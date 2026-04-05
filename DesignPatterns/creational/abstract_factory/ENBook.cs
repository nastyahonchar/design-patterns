using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.creational.abstract_factory
{
    public class ENBook : IBook
    {
        public string GetInfo()
        {
            return "This is an English book";
        }
    }
}
