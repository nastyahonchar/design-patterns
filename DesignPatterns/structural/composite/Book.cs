using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.structural.composite
{
    public class Book : CatalogComponent
    {
        public string Title { get; }
        public string Author { get; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public override void Print()
        {
            Console.WriteLine($"Book: {Title} by {Author}");
        }
    }
}
