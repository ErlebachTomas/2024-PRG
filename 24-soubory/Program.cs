// --- Výpis CLI argumentů ---
Console.WriteLine("--- CLI argumenty ---");
for (int i = 0; i < args.Length; i++)
    Console.WriteLine($"{i}: {args[i]}");
// Argumenty předávané programu lze nastavit v menu Debug\ProcessData Debug Properties
Console.ReadLine();

// --- Práce se soubory ---
// Absolutní cesta
string absolutniCesta = @"C:\Users\User\Documents\file.txt";
// Relativní cesta (vůči aktuálnímu adresáři aplikace)
string relativniCesta = @"data\file.txt";
string aktualniAdresar = Environment.CurrentDirectory;
Console.WriteLine("Aktuální adresář: " + aktualniAdresar);
Console.ReadLine();

Console.WriteLine("Soubory v adresáři:");
foreach (var f in Directory.GetFiles(aktualniAdresar))
    Console.WriteLine(" - " + f);

// --- Vytvoření prázdného souboru ----
string cesta = "test.txt";
bool jeAbsolutni = Path.IsPathRooted(cesta); // Je cesta k souboru absolutní nebo relativní?

// Kontrola existence souboru
if (!File.Exists(cesta))
{
   
    File.Create(cesta).Close(); // Vytvoří prázdný soubor
    Console.WriteLine("Soubor nebyl nalezen, byl vytvořen nový prázdný soubor.");
}
else
{
    Console.WriteLine("Soubor již existuje.");
}
// Text k zápisu
string text = "Toto je testovací obsah souboru. \n Další řádek.";

// --- Zápis textu do souboru ---
File.WriteAllText(cesta, text);
Console.WriteLine("Soubor vytvořen a text zapsán.");

// --- Zjištění informací o souboru ---
DateTime casVytvoreni = File.GetCreationTime(cesta);
long velikost = new FileInfo(cesta).Length;
string pripona = Path.GetExtension(cesta);
Console.WriteLine($"Čas vytvoření: {casVytvoreni}");
Console.WriteLine($"Velikost souboru: {velikost} bajtů");
Console.WriteLine($"Přípona souboru: {pripona}");

// --- Čtení obsahu ze souboru ---
string nactenyText = File.ReadAllText(cesta);
Console.WriteLine($"Přečtený text: {nactenyText}");


// --- Proudové operace, čtení souboru  ---

// Přečtení celého souboru najednou a vložení do řetězce
StreamReader sr = new StreamReader(cesta);
string obsah = sr.ReadToEnd();
sr.Close();
Console.WriteLine(obsah);

// Automatické uzavření souboru při použití klauzule using
// Načtení souboru po řádcích
using (StreamReader sr2 = new StreamReader(cesta))
{
    string line;
    while ((line = sr2.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}

// --- Smazání souboru ---
File.Delete(cesta);
Console.WriteLine("Soubor byl smazán.");