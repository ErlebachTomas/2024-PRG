using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Abstrakce
{
    internal class Horse : Vehicle, IMeasurablePower 
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override void Move()
        {
            Console.WriteLine($"Kůň {Name} běží.");
        }
    }
}
