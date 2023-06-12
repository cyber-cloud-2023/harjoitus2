using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2
{
    internal class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public void Welcome(String message)
        {
            Console.WriteLine(message+" " + Age + " vuotias " + Name);
        }
    }
}
