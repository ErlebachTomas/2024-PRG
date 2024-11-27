using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Abstrakce
{
    internal abstract class Vehicle
    {
        public int Power { get; set; }
        public int Capacity { get; set; }
        public string Color { get; set; }

        public abstract void Move();
       
    }
}
