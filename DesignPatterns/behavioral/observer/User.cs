using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.observer
{
    public class User : ISubscriber
    {
        private string name;

        public User(string name)
        {
            this.name = name;
        }

        public void Update(BookStatus status)
        {
            Console.WriteLine($"{name} notified: Book is {status}");
        }
    }
}
