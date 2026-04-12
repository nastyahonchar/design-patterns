using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.bridge
{
    public interface IFormat
    {
        void Open();
        void Use();
        void Close();
    }
}
