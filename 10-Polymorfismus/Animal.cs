using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfismus
{
    internal class Animal
    {
        public string Name { get; set; }
        
        protected int NumberOflegs;

        public Animal(string name, int numberOflegs)
        {
            Name = name;
            NumberOflegs = numberOflegs;
        }

        public virtual string Info() { 
        
            return $"Jsem {Name} a mám {NumberOflegs} nohy";
        
        }

    }
}
