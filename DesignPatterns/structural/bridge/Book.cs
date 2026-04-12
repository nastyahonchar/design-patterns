using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.bridge
{
    public abstract class Book
    {
        protected IFormat format;

        protected Book(IFormat format)
        {
            this.format = format;
        }

        public abstract void Read();

        public void Open()
        {
            format.Open();
        }

        public void Close()
        {
            format.Close();
        }
    }
}
