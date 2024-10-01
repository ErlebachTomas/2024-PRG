/*  Podprogramy */
// 1) (volitelně) modifikátor (private, public, internal, protected, static, virtual, override, abstract...)
// 2) návratový_typ (int, string, bool, void, double, float, char, ...)
// 3) NázevMetody (CamelCase)
// 4) (volitelně) parametry (int a, int b, string text, ...)

/*
[modifikátory] návratový_typ NázevMetody([parametry])
{
    // Tělo metody
    return [hodnota]; // pokud má návratovou hodnotu
} 
 */

/// Bezparametrická funkce
/// Pouze vypíše pozdrav do konzole. Nepotřebujeme vracet žádnou hodnotu. 
static void Print()
{    
    Console.WriteLine("Ahoj, světe!"); // Výpis zprávy do konzole
}

/// Čistá funkce: Vrací výsledek pouze na základě předaných parametrů
static int Addition(int a, int b)
{
    return a + b; // Vrátíme součet parametrů a a b
}
/// funkce s implicitním parametrem (pokud nepředám x, použije se defaultní hodnota parametru)
static int Increase(int a, int x = 1)
{
    return a + x; 
}
// Jakmile se v podprogramu provede "return", veškerý kód za ním se již neprovede.
void CheckValue(int num)
{
    if (num < 0)
    {
        Console.WriteLine("Číslo je záporné.");
        return; // Ukončí metodu, kód za tímto řádkem se neprovede
    }
    Console.WriteLine("Číslo je kladné nebo nula.");
}

/// Funkce s "ref" parametrem: Umožňuje změnit hodnotu parametru
static void Increment(ref int value)
{
    
    value += 1; // Zvýšíme hodnotu o 1
}

/// Funkce s "out": umožňuje vrátit více hodnot
static void SplitNumber(int number, out int tens, out int units)
{  
    tens = number / 10;   // Vypočítáme desítky    
    units = number % 10; // Vypočítáme jednotky
}
/* ------------------------------------------------- */
// Použití:

Print(); // volání funkce 
int result = Addition(1, 1); // použití funkce s parametry a uložení výsledku

// Použití metody s out parametry
int number = 42;
int tens, units;
SplitNumber(number, out tens, out units);
Console.WriteLine($"Číslo: {number}, desítky: {tens}, jednotky: {units}");

// Použití metody s 'ref' parametrem 
int counter = 0;
Increment(ref counter);
Console.WriteLine("Hodnota čítače: " + counter);



