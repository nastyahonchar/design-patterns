using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.facade
{
    public abstract class StoreService
    {
        public void Start()
        {
            Console.WriteLine(Name() + " started.");
        }

        public void Stop()
        {
            Console.WriteLine(Name() + " finished.");
        }

        public abstract void Process();

        public abstract string Name();
    }
}
