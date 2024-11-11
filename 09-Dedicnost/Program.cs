using _09_Dedicnost;

Person osoba = new Person("Jan", "Kovář", 25);
Console.WriteLine(osoba.FullName);

// Vytvoření objektu typu Student
Student student = new Student("P2B", "Petra", "Novotná", 17);
Console.WriteLine(student.getInfo());

// Vytvoření pole učitelů
Teacher[] teachers =
[
            new Teacher("Petr", "Svoboda", 30, "B102", "Ing."),
            new Teacher("Jana", "Malá", 41, "C201", "Mgr.", "Ph.D."),
            new Teacher("Eva", "Horáková", 45, "D401") 
];

// Procházení pole a volání metody DetailedInfo pro každého učitele
foreach (var teacher in teachers)
{
    Console.WriteLine(teacher.DetailedInfo());
}