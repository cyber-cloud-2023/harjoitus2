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
        public void Accelerate(float value)
        {
            Speed = Speed + value;
            //tai 
            //Speed += value;
        }
        public void Brake(float value) { 
            Speed=Speed - value;
        }
    }
}
