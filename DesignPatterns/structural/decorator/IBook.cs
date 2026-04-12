using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.decorator
{
    public interface IBook
    {
        void GetDescription();
        int GetPrice();
    }
}
