List<int> A = new List<int> { 1, 2, 3, 4, 5, 3, 2 };
List<int> B = new List<int> { 4, 5, 6, 7, 8, 1 };

// ============================
// Intersect() - průnik kolekcí A a B (společné prvky)
// ============================
var prunik = A.Intersect(B);
Console.WriteLine("Intersect() - průnik kolekcí A a B:");
foreach (var cislo in prunik)
{
    Console.Write(cislo + " ");
}
Console.WriteLine("\n");

// ============================
// Union() - sjednocení kolekcí A a B (bez duplicit)
// ============================
var sjednoceni = A.Union(B);
Console.WriteLine("Union() - sjednocení kolekcí A a B (bez duplicit):");
foreach (var cislo in sjednoceni)
{
    Console.Write(cislo + " ");
}
Console.WriteLine("\n");

// ============================
// Except() - rozdíl kolekcí (prvky, které jsou v kolekci A, ale ne v kolekci B)
// ============================
var rozdil = A.Except(B);
Console.WriteLine("Except() - prvky v kolekci A, které nejsou v kolekci B:");
foreach (var cislo in rozdil)
{
    Console.Write(cislo + " ");
}
Console.WriteLine("\n");

// ============================
// All() a Any() - kontrola podmínek v kolekci A
// ============================
bool vsetkyVetsiNezNula = A.All(x => x > 0);
bool existujeVetsiNezDeset = A.Any(x => x > 10);
Console.WriteLine("All() - jsou všechna čísla v kolekci A větší než 0? " + vsetkyVetsiNezNula);
Console.WriteLine("Any() - existuje číslo v kolekci A větší než 10? " + existujeVetsiNezDeset);
Console.WriteLine();

// ============================
// Concat() - spojení kolekcí A a B
// ============================
var spojena = A.Concat(B);
Console.WriteLine("Concat() - spojení kolekcí A a B:");
foreach (var cislo in spojena)
{
    Console.Write(cislo + " ");
}
Console.WriteLine("\n");

// ============================
// Distinct() - odstranění duplicit v kolekci A
// ============================
var unikatni = A.Distinct();
Console.WriteLine("Distinct() - odstranění duplicit v kolekci A:");
foreach (var cislo in unikatni)
{
    Console.Write(cislo + " ");
}
Console.WriteLine("\n");

// ============================
// Skip() - přeskočení prvních 3 prvků v kolekci A
// ============================
var preskoceno = A.Skip(3);
Console.WriteLine("Skip(3) - přeskočení prvních 3 prvků v kolekci A:");
foreach (var cislo in preskoceno)
{
    Console.Write(cislo + " ");
}
Console.WriteLine("\n");

// ============================
// Where() a Select() - filtrování a transformace dat (pouze sudá čísla) v kolekci A
// ============================
var parnaCisla = A
                 .Where(x => x % 2 == 0)
                 .Select(x => "Číslo: " + x);
Console.WriteLine("Where() a Select() - vyfiltrování a úprava dat (pouze sudá čísla) z kolekce A:");
foreach (var s in parnaCisla)
{
    Console.WriteLine(s);
}
Console.WriteLine();

// ============================
// Where() s kombinací podmínek - čísla větší než 2 a sudá v kolekci A
// ============================
var kombinovanePodminky = A.Where(x => x > 2 && x % 2 == 0);
Console.WriteLine("Where() s kombinací podmínek (číslo > 2 a sudé) v kolekci A:");
foreach (var cislo in kombinovanePodminky)
{
    Console.Write(cislo + " ");
}
Console.WriteLine("\n");

// ============================
// Deferred Execution - ukázka odloženého vyhodnocení v kolekci A
// ============================
// Vytvoříme dotaz, který vybere všechna čísla větší než 3.
// Jelikož LINQ dotazy jsou vykonávány až při iteraci, změny v kolekci se projeví.
var deferredQuery = A.Where(x => x > 3);
Console.WriteLine("Deferred Execution - před úpravou dat v kolekci A:");
foreach (var cislo in deferredQuery)
{
    Console.Write(cislo + " ");
}
Console.WriteLine();

// Změníme data v kolekci A
A.Add(10);
A.Add(11);
Console.WriteLine("Deferred Execution - po přidání nových prvků (10 a 11) do kolekce A:");
foreach (var cislo in deferredQuery)
{
    Console.Write(cislo + " ");
}
Console.WriteLine("\n");


// -----------------------------------------------------------

List<Student> seznamStudentu = new List<Student>();

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

// Najdi města, kde bydlí alespoň dva studenti, a vypiš je spolu s počtem studentů.
Console.WriteLine("Města, kde bydlí alespoň dva studenti:");
foreach (var x in seznamStudentu
    .GroupBy(x => x.Bydliste)
    .Select(x => new { Bydliste = x.Key, Count = x.Count() })
    .Where(x => x.Count >= 2)
    .OrderByDescending(x => x.Count))
{
    Console.WriteLine($"{x.Bydliste}: {x.Count} studenti");
}

// Najdi studenta s nejkratším a nejdelším jménem (délka křestního jména).
var nejkratsi = seznamStudentu.OrderBy(x => x.Jmeno.Length).First();
var nejdelsi = seznamStudentu.OrderByDescending(x => x.Jmeno.Length).First();

Console.WriteLine($"Student s nejkratším jménem: {nejkratsi.Jmeno} {nejkratsi.Prijmeni}");
Console.WriteLine($"Student s nejdelším jménem: {nejdelsi.Jmeno} {nejdelsi.Prijmeni}");
Console.WriteLine();
// Filtruj studenty, kteří mají příjmení začínající písmenem „N“.
Console.WriteLine("Studenti s příjmením začínajícím na 'N':");
foreach (var x in seznamStudentu.Where(x => x.Prijmeni.StartsWith("N")))
{
    Console.WriteLine($"{x.Jmeno} {x.Prijmeni}");
}
Console.WriteLine();
// Výpis studentů, kteří mají lichý počet písmen v příjmení
Console.WriteLine("Studenti s lichým počtem písmen v příjmení:");
foreach (var x in seznamStudentu.Where(x => x.Prijmeni.Length % 2 != 0))
{
    Console.WriteLine($"{x.Jmeno} {x.Prijmeni} ({x.Prijmeni.Length} písmen)");
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