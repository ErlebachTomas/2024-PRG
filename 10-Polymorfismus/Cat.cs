using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Polymorfismus
{
    internal class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public override string MakeSound()
        {
            return $"Mňau Mňau";
        }
    }
}
