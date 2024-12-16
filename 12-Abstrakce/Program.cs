using _12_Abstrakce;
using System.Security.Cryptography;

Car bourák = new Car { SPZ = "L 44 44", Capacity = 4, Color = "Red", Power = 100, Speed = 200 };
Horse kůň = new Horse { Name = "Blesk", Age = 5, Color = "Black", Power = 10 };
Human petr = new Human { Name = "Petr", Age = 25, Power = 1 };
Human jana = new Human { Name = "Jana", Age = 30, Power = 2 };

// motorbike

// Vozidlo x = new Vozidlo();
Vehicle[] Garáž = { bourák, kůň };
IMeasurablePower[] objekty = { bourák, kůň, petr };
var celkovýVýkon = 0;
foreach (var objekt in objekty)
{
    celkovýVýkon += objekt.Power;
}
Console.WriteLine($"Celkový výkon všech vozidel v garáži je {celkovýVýkon} hp.");
Console.WriteLine($"Petr je {(petr.CompareTo(jana) > 0 ? "starší" : "mladší")} než Jana.");

foreach(var auto in Garáž)
{
    auto.Move();
}