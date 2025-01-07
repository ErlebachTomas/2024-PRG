using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm.Models
{
    public abstract class Animal
    {
        public string Id { get; }

        public Animal(string id = "Bezejmennný")
        {
            Id = id;
        }

        public override string ToString()
        {
            return $"Zvíře {Id}";
        }
    }
}
