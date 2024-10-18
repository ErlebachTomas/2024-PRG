using _07_tridy;

// Vytvoření instance třídy Student s parametry
Student student = new Student("Petr", "Dvořák");

// Získání a zobrazení jména studenta
Console.WriteLine("Jméno studenta: " + student.FirstName);

// Nastavení věku a zobrazení
student.SetAge(25);
Console.WriteLine("Věk studenta: " + student.GetAge());

