using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    internal class Person
    {
        private String name;
        private int age;
   
        public void SetName(String value)
        {
            name= value;
        }
        public String GetName()
        {
            return name;
        }
        public int GetAge()
        {
            return age;
        }
        public void SetAge(int value)
        {
            age = value;
        }
    }
}
