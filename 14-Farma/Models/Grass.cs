

namespace AnimalFarm.Models
{
    internal class Grass : Plant, IConsumable
    {
        public Grass(double energy)
        {
            Energy = energy;
        }

        public double Energy { get; }

        public override string ToString()
        {
            return "Tráva";
        }
    }
}
