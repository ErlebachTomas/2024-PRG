using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfismus
{
    internal class Cat : Animal
    {
        public Cat(string name, int numberOflegs = 4) : base(name, numberOflegs)
        {
        }
        public string MakeSound()
        {
            return $"Mňau Mňau";
        }
    }
}
