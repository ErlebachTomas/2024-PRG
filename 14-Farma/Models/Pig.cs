namespace AnimalFarm.Models
{
    internal class Pig : Animal, ICarnivore, IHerbivore, IConsumable
    {
        public Pig(double energy, string id) : base(id)
        {
            Energy = energy;
        }

        public double Energy { get; protected set; }

        public double Consume(Animal animal)
        {
            if (animal is IConsumable)
            {
                Energy += 0.2 * (animal as IConsumable)!.Energy;
            }
            return Energy;
        }

        public double Consume(Plant plant)
        {
            if (plant is IConsumable)
            {
                Energy += 0.1 * (plant as IConsumable)!.Energy;
            }
            return Energy;
        }

        public override string ToString()
        {
            return "Prase " + Id;
        }
    }
}
