using Polymorfismus;

Dog alik = new Dog("Alík", true);
Cat micka = new Cat("Micka", 4);
Fish nemo = new Fish("Nemo", "oranžová");
Bird tweety = new Bird("Tweety");

Animal[] animals = { alik, micka, nemo };
AnimalFarm farma = new AnimalFarm(animals);
farma.showInfo();

AnimalFarm druhaFarma = new AnimalFarm(5);
druhaFarma.AddAnimal(tweety);
druhaFarma.showInfo();




