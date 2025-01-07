
namespace AnimalFarm.Models
{
    public interface ICarnivore
    {
        double Energy { get; }
        double Consume(Animal animal);
    }
}
