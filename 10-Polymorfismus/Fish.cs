using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfismus
{
    internal class Fish : Animal
    {
        public string Color { get; set; }
        public Fish(string name, string color) : base(name, 0)
        {
            Color = color;
        }

        public override string Info()
        {
            return $"Jsem {base.Name} a nemám žádné nohy";
        }
    }
}
