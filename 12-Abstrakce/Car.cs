using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Abstrakce
{
    internal class Car : Vehicle, IMeasurablePower
    {
        public string SPZ { get; set; }
        public int Speed { get; set; }

        public override void Move()
        {
            Console.WriteLine($"Auto s SPZ {SPZ} se pohybuje rychlostí {Speed} km/h.");
        }
    }
}
