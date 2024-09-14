// =========================================================
// Základy programování v C#
// =========================================================

// Tento program demonstruje základní konstrukce jazyka C#,


// -----------------------------------------
// 1. Proměnné a datové typy
// -----------------------------------------

// Deklarace a inicializace proměnných
int cislo = 10;           // Celé číslo
string text = "Ahoj";     // Řetězec znaků

/* C# je staticky typovaný jazyk - typ proměnné je určen při kompilaci
Následující přiřazení by způsobilo chybu: */

// cislo = "Ahoj";        // Nelze přiřadit řetězec do proměnné typu int

// -----------------------------------------
// 2. Vstup a výstup
// -----------------------------------------

Console.WriteLine("Jak se jmenuješ?");
string jmeno = Console.ReadLine();                // Přečte vstup od uživatele
Console.WriteLine("Ahoj " + jmeno);               // Vypíše pozdrav s vloženým jménem

// -----------------------------------------
// 3. Převod vstupu na číslo
// -----------------------------------------

Console.WriteLine("Zadej číslo:");
string vstup = Console.ReadLine();
int cisloOdUzivatele;
bool uspech = int.TryParse(vstup, out cisloOdUzivatele);

if (uspech)
{
    Console.WriteLine("Zadal jsi číslo: " + cisloOdUzivatele);
}
else
{
    Console.WriteLine("Neplatný vstup. Zadal jsi nečíselnou hodnotu.");
}

// -----------------------------------------
// 4. Podmíněné příkazy (if-else)
// -----------------------------------------

int a = 5;

if (a > 0)
{
    Console.WriteLine("a je kladné číslo");
}
else if (a == 0)
{
    Console.WriteLine("a je nula");
}
else
{
    Console.WriteLine("a je záporné číslo");
}

// -----------------------------------------
// 5. Podmíněné příkazy (switch)
// -----------------------------------------

int b = 2;

switch (b)
{
    case 0:
        Console.WriteLine("Nula");
        break;
    case 1:
        Console.WriteLine("Jedna");
        break;
    case 2:
        Console.WriteLine("Dva");
        break;
    default:
        Console.WriteLine("Neznámé číslo");
        break;
}

// -----------------------------------------
// 6. Cyklus for
// -----------------------------------------

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Hodnota i: " + i);
}

// -----------------------------------------
// 7. Cyklus while
// -----------------------------------------

int iWhile = 0;

while (iWhile < 5)
{
    Console.WriteLine(iWhile);
    iWhile++;
}

// -----------------------------------------
// 8. Cyklus do-while
// -----------------------------------------

int iDoWhile = 10;

do
{
    Console.WriteLine(iDoWhile); // 'do' zaručuje, že blok kódu bude proveden alespoň jednou
    iDoWhile++;
}
while (iDoWhile < 5);

// -----------------------------------------
// 9. Řídicí příkazy (break a continue)
// -----------------------------------------

// Použití break
for (int j = 0; j < 10; j++)
{
    if (j == 5)
    {
        break;                                     // Ukončí cyklus, když j je 5
    }
    Console.WriteLine("j: " + j);
}
// Výstup: 0,1,2,3,4

// Použití continue
for (int k = 0; k < 5; k++)
{
    if (k == 2)
    {
        continue;                                  // Přeskočí 2
    }
    Console.WriteLine("k: " + k);
}
// Výstup: 0,1,3,4

// -----------------------------------------
// 10. Pole a cyklus foreach
// -----------------------------------------

string[] jmena = { "Adam", "Blanka", "Cyril" };

foreach (string osoba in jmena)
{
    Console.WriteLine(osoba);
}

