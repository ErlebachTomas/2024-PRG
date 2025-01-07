

namespace AnimalFarm.Models
{
    internal interface IHerbivore
    {
        double Energy { get; }
        double Consume(Plant plant);
    }
}
