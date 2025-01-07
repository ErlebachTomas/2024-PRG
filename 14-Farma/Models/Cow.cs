

namespace AnimalFarm.Models
{
    internal class Cow : Animal, IHerbivore, IConsumable
    {
        public Cow(double energy, string id = "Bezejmennná") : base(id)
        {
            Energy = energy;
        }

        public double Energy { get; protected set; }

        public override string ToString()
        {
            return "Kráva " + Id;
        }

        public double Consume(Plant plant)
        {
            if (plant is IConsumable)
            {
                Energy += 0.1 * (plant as IConsumable)!.Energy;
            }
            return Energy;
        }
    }
}
