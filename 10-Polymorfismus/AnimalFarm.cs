using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Polymorfismus
{
    internal class AnimalFarm
    {
        private List<Animal> animals = new List<Animal>();

        public List<Animal> GetAnimals() { return animals; }
        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }
        public void RemoveAnimal(Animal animal)
        {
            animals.Remove(animal);
        }           
        public void AllMakeSound()
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.MakeSound());
            }
        }       
        public void ShowAllInfo()
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Info());
            }
        }

    }
}
