using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Polymorfismus
{
    public abstract class Animal
    {        
        public string Name { get; protected set; }
        protected int NumberOfLegs;
               
        public Animal(string name, int numberOfLegs = 4)
        {
            Name = name;
            NumberOfLegs = numberOfLegs;
        }
        
        public virtual string MakeSound()
        {
            return $"";
        }

       
        public virtual string Info()
        {
            return $"Jsem {Name} a mám {NumberOfLegs} nohy";
        }
    }
}
