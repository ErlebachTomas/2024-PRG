namespace AnimalFarm.Models
{
    internal class Tiger : Animal, ICarnivore
    {
        public Tiger(double energy, string id = "Bezejmennný") : base(id)
        {
            Energy = energy;
        }

        public double Energy { get; protected set; }

        public override string ToString()
        {
            return "Tygr " + Id;
        }

        public double Consume(Animal animal)
        {
            if (animal is IConsumable)
            {
                Energy += 0.2 * (animal as IConsumable)!.Energy;
            }
            return Energy;
        }
    }
}
