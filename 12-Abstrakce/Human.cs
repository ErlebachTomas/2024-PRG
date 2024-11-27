using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Abstrakce
{
    internal class Human : IMeasurablePower, IComparable<Human>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Power { get; set; }

        public int CompareTo(Human? other)
        {
            if (this.Age > other.Age) return 1;
            if (this.Age < other.Age) return -1;
            return 0;
        }
    }
}
