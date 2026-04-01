using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.creational.abstract_factory
{
    public class ENDescription : IDescription
    {
        public string GetDescription()
        {
            return "Description in English";
        }
    }
}
