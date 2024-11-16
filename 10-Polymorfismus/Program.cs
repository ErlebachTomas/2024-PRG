// Vytvoření instancí zvířat
using _10_Polymorfismus;

Cat myCat = new Cat("Mia");
Dog myDog = new Dog("Buddy", true);
Bird myBird = new Bird("Tweety", 2);
Fish myFish = new Fish("Nemo", "oranžová");

// Vytvoření AnimalFarm a přidání zvířat
AnimalFarm farm = new AnimalFarm();
farm.AddAnimal(myCat);
farm.AddAnimal(myDog);
farm.AddAnimal(myBird);
farm.AddAnimal(myFish);

// Všechna zvířata vydají svůj zvuk
farm.AllMakeSound();

// Zobrazení informací o všech zvířatech
farm.ShowAllInfo();