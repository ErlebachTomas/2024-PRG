// -------------------- Nullable pole --------------------
int[] pole = new int[5];
pole = null; // pole je nyní null

// int[] pole = { 5, 10, null }; // chyba
int?[] poleSNull = { 5, 10, null }; // zde již pole může obsahovat null

// int c = null; // nelze 
int? c = null; // int?  
Console.WriteLine(c.HasValue); // false pokud je null

foreach (int? prvek in poleSNull)
{
    if (prvek.HasValue)
    {       
        Console.WriteLine(prvek); // vypíše neulové prvky
    }
}

// -------------------- Příklad 1: ošetření vyjimky --------------------
int a = 10;
int b = 0;
try
{
    int vysledek = a / b;
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Chyba: Nelze dělit nulou.");
    Console.WriteLine($"Detail chyby: {ex.Message}");
}
Console.WriteLine("program pokračuje dál");

// -------------------- Příklad 2: vyhození vyjimky --------------------
static void printValAtIndex(int[] pole, int index)
{
    if (pole == null)
    {
        throw new ArgumentNullException("Pole nesmí být null.");
    }
    if (index < 0)
    {
        throw new ArgumentOutOfRangeException("index", "Chyba: Index nemůže být záporný.");
    }
    if (index >= pole.Length)
    {
        throw new IndexOutOfRangeException("Chyba: Index je mimo rozsah pole.");
    }
    Console.WriteLine($"Hodnota na indexu {index}: {pole[index]}");
}

int[] cisla = { 10, 20, 30, 40, 50 };
try
{
    printValAtIndex(cisla, -1);
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"ArgumentOutOfRangeException: {ex.Message}");
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine($"IndexOutOfRangeException: {ex.Message}");
}

// -------------------- Příklad 3: Vlastní výjimka  --------------------
void ProvedNeco(int number)
{
    if (number > 20)
    {
        throw new MojeVyjimka("Číslo nesmí být větší než 20");
    }
    Console.WriteLine("Operace proběhla úspěšně.");
}

try
{
    ProvedNeco(2000);
}
catch (MojeVyjimka vyjimka)
{
    Console.WriteLine("Moje výjimka: " + vyjimka.Message);
}
finally
{
    Console.WriteLine("Operace dokončena");
}

public class MojeVyjimka : Exception
{
    public MojeVyjimka(string text) : base(text) { }
}