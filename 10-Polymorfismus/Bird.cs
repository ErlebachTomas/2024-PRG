using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Polymorfismus
{
    internal class Bird : Animal
    {  

        public Bird(string name, double wingSpan) : base(name, 2){}
             
        public override string MakeSound()
        {
            return  "Cvrlik Cvrlik";
        }
    }
}
