using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _10_Polymorfismus
{
    internal class Dog : Animal
    {
        // Určuje, zda je pes vycvičený
        public bool IsTrained { get; set; }

        // Konstruktor
        public Dog(string name, bool isTrained = false) : base(name, 4)
        {
            IsTrained = isTrained;
        }

        // Přepsaná metoda pro vydání zvuku
        public override string MakeSound()
        {
            return $"Haf Haf";
        }

        // Metoda specifická pro psa
        public string Guard()
        {
            return $"{Name} hlídá.";
        }
    }
}
