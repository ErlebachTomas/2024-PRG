﻿List<Student> seznamStudentu = new List<Student>();

seznamStudentu.Add(new Student { Jmeno = "Jan", Prijmeni = "Novák", Trida = "1A", Bydliste = "Praha" });
seznamStudentu.Add(new Student { Jmeno = "Eva", Prijmeni = "Svobodová", Trida = "1B", Bydliste = "Brno" });
seznamStudentu.Add(new Student { Jmeno = "Petr", Prijmeni = "Dvořák", Trida = "2A", Bydliste = "Ostrava" });
seznamStudentu.Add(new Student { Jmeno = "Kateřina", Prijmeni = "Procházková", Trida = "2B", Bydliste = "Plzeň" });
seznamStudentu.Add(new Student { Jmeno = "Lukáš", Prijmeni = "Novotný", Trida = "3A", Bydliste = "Liberec" });
seznamStudentu.Add(new Student { Jmeno = "Barbora", Prijmeni = "Kovářová", Trida = "3B", Bydliste = "Ústí nad Labem" });
seznamStudentu.Add(new Student { Jmeno = "Tomáš", Prijmeni = "Marek", Trida = "3B", Bydliste = "Hradec Králové" });
seznamStudentu.Add(new Student { Jmeno = "Veronika", Prijmeni = "Malá", Trida = "4B", Bydliste = "České Budějovice" });
seznamStudentu.Add(new Student { Jmeno = "Martin", Prijmeni = "Pospíšil", Trida = "5A", Bydliste = "Pardubice" });
seznamStudentu.Add(new Student { Jmeno = "Anna", Prijmeni = "Nováková", Trida = "5B", Bydliste = "Karlovy Vary" });
seznamStudentu.Add(new Student { Jmeno = "David", Prijmeni = "Šimek", Trida = "6A", Bydliste = "Zlín" });
seznamStudentu.Add(new Student { Jmeno = "Tereza", Prijmeni = "Králová", Trida = "6B", Bydliste = "Olomouc" });

foreach (Student x in seznamStudentu)
{
    Console.WriteLine(x); // Výpis všech studentů v seznamu.
}

Console.WriteLine();
foreach (Student x in seznamStudentu.Where(x => x.Bydliste == "Liberec"))
{
    Console.WriteLine(x); // Výpis studentů, kteří bydlí v Liberci.
}

Console.WriteLine();
foreach (Student x in seznamStudentu.OrderBy(x => x.Prijmeni))
{
    Console.WriteLine(x); // Výpis studentů seřazených podle příjmení vzestupně.
}

Console.WriteLine();
foreach (Student x in seznamStudentu.OrderByDescending(x => x.Prijmeni).ThenBy(x => x.Jmeno))
{
    Console.WriteLine(x); // Výpis studentů seřazených podle příjmení sestupně a v případě shody podle jména vzestupně.
}

Console.WriteLine();
foreach (Student x in seznamStudentu.OrderBy(x => x.Prijmeni).Take(5))
{
    Console.WriteLine(x); // Výpis prvních pěti studentů ze seznamu.
}

Console.WriteLine();
foreach (var x in seznamStudentu.GroupBy(x => x.Trida))
{
    Console.WriteLine(x.Key + " " + x.Count()); // Výpis tříd a počtu studentů v každé třídě.
}


Console.WriteLine();
foreach (var x in seznamStudentu.Select(x => new Jmeno { Text = x.Jmeno }))
{
    Console.WriteLine(x.Text); 
}

Console.WriteLine();
foreach (var x in seznamStudentu
    .GroupBy(x => x.Trida) // Seskupení studentů podle třídy.
    .Select(x => new TridaSouhrn { Trida = x.Key, Count = x.Count() }) // Vytvoření objektu se třídou a počtem studentů.
    .Where(x => x.Count > 1) // Filtrování tříd, kde je více než jeden student.
    .OrderBy(x => x.Count) // Seřazení podle počtu studentů vzestupně.
    .Take(3) // Výběr prvních tří položek.
    )
{
    Console.WriteLine(x.Trida + " " + x.Count); 
}

class Student
{
    public string Jmeno { get; set; }
    public string Prijmeni { get; set; }
    public string Trida { get; set; }
    public string Bydliste { get; set; }
    public override string ToString()
    {
        return Jmeno + " " + Prijmeni + "/" + Bydliste + "/" + Trida;
    }
}

class Jmeno
{
    public string Text { get; set; }
}

class TridaSouhrn
{
    public string Trida { get; set; }
    public int Count { get; set; }
}
