using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfismus
{
    internal class Dog : Animal
    {
        public bool IsTrained { get; set; }

        public Dog(string name, bool isTrained= false) 
            : base(name, 4)
        {
            IsTrained = isTrained;
        }
    }
}
