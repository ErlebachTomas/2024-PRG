using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Polymorfismus
{
    internal class Fish :Animal
    {
        // Barva šupin ryby
        public string Color { get; set; }

     
        public Fish(string name, string color) : base(name, 0)
        {
            this.Color = color;
        }
        public override string Info() {

            return $"jsem {base.Name} a nemám žádné nohy";
        }

    }
}
