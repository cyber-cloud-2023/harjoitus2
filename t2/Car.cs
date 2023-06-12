using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2
{
    internal class Car
    {
        public String Brand { get; set; }
        public float Speed { get; set; }    
        public void Accelerate(double value)
        {
            Speed = Speed + value;
            //tai 
            //Speed += value;
        }
    }
}
