using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t5
{
    internal class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }

        //Muodostimet
        public Book() { }
        public Book(string n, string a, int p) { 
            Name = n;
            Author = a;
            PublicationYear = p;
        }
    }
}
