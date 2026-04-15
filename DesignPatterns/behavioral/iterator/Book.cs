using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.iterator
{
    public class Book
    {
        public Genre Genre { get; set; }
        public string Title { get; }

        public Book(Genre genre, string title)
        {
            Genre = genre;
            Title = title;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
