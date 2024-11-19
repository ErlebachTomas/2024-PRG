using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfismus
{
    internal class AnimalFarm
    {
        private Animal[] animals;
        private int count;

        public AnimalFarm(Animal[] animals)
        {
            this.animals = animals;
            this.count = animals.Length;
        }

        public AnimalFarm(int size)
        {
            if (size <= 0) throw new ArgumentOutOfRangeException("size musí být větší než nula");

            animals = new Animal[size];
            this.count = 0;
        }  

        public void showInfo()
        {

            for (int i = 0; i < this.count; i++)
            {

                Console.WriteLine(animals[i].Info());
            }

        }

        public void AddAnimal(Animal animal)
        {

            if (this.count >= animals.Length)
            {
                throw new InvalidOperationException("Farma je plná");
            }
            animals[count++] = animal;
        }

        public void RemoveAnimal(Animal animal)
        {
            int index = Array.IndexOf(animals, animal);
            if (index >= 0 && index < count)
            {
                // Posun zvířat na nižší indexy, aby se odstraněné zvíře nahradilo
                for (int i = index; i < count - 1; i++)
                {
                    animals[i] = animals[i + 1];
                }
                animals[count] = null; // Poslední pozici nastavíme na null
                count--; // upravíme počet zvířat
            }

        }
        public int getFarmSize()
        {

            return this.count;
        }

        public Animal getAnimal(int index)
        {
            if (index <= 0 || index > this.count) throw new ArgumentOutOfRangeException("neplatný index");
            return this.animals[index];
        }
    }
}
