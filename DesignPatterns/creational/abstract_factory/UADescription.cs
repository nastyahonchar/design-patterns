using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.creational.abstract_factory
{
    public class UADescription : IDescription
    {
        public string GetDescription()
        {
            return "Опис українською мовою";
        }
    }
}
