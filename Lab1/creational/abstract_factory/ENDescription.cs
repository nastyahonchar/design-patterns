using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.creational.abstract_factory
{
    public class ENDescription : IDescription
    {
        public string GetDescription()
        {
            return "Description in English";
        }
    }
}
