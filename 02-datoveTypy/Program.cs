int a;  // deklarace
a = 10; // inicializace
int b = 10; // deklarace +  inicializace

string c = "Ahoj";

//Pojmenování promněných

string jmenoStudenta = "Karel Novák"; // camelCase ( první slovo začíná malým písmenem a další slova velkým )
const string JMENO_STUDENTA = "konstanta"; // konstanta s velké písmeno s potržítky 
//class Stundent() { } // třídy začínají velkým písmenem (PascalCase)

uint nezaporneCislo = 4; // -4 chyba
sbyte maleCislo = 5; // 100 chyba

int cislo;
cislo = maleCislo;

long velkeCislo;
velkeCislo = cislo; // implicitní konverze menší -> větší

cislo = (int)velkeCislo; // explicitní konverze větší -> menší

cislo = int.MaxValue;
// Console.WriteLine(cislo);
// Console.WriteLine(long.MaxValue);


try
{
    int aa = checked(cislo + 1);
}
catch (OverflowException)
{
    Console.WriteLine("došlo k přetečení");
}

/**
 *  metoda bez návratové hodnoty (void) jen vypíše text 
 */
void Vypis()
{
    Console.WriteLine("jen vypis");
}


int x = 10;
int y = 10;

Sctani(x, y); // 30
Console.WriteLine("hodnota x: " + x);// 10 

int Sctani(int x, int y)
{
    // // zde se mění pouze lokální proměnná x, nemá vliv na hodnotu x mimo tuto metodu
    x = 20; // pouze změna lokální proměné 
    return x + y;

}

int ScitaniSReferenci(ref int x, ref int y)
{
    // // změna proměnné x ovlivní i původní proměnnou, protože je předána odkazem (ref)
    x = 20; // změna hodnoty proměnné
    return x + y;
}

ScitaniSReferenci(ref x, ref y); // 30
Console.WriteLine("hodnota x: " + x); // 20



int? cisloNeboNull = 5; // proměnná typu int? může obsahovat buď celé číslo, nebo null
cisloNeboNull = null; // přiřazení hodnoty null

if (cisloNeboNull == null) // kontrola, zda je proměnná null
{

    Console.WriteLine("proměnná je null");
}
else
{
    Console.WriteLine("proměnná má hodnotu:" + cisloNeboNull);
}

string? vstup = Console.ReadLine(); // načtení vstupu od uživatele, vstup může být null

// int ciselnyVstup = int.Parse(vstup); // // int.Parse by vyhodil výjimku, pokud by vstup nebylo platné číslo
int ciselnyVstup;
bool uspech = int.TryParse(vstup, out ciselnyVstup); // bezpečnější způsob, který vrací true/false, zda se vstup podařilo převést na číslo

if (uspech) 
{

    Console.WriteLine(ciselnyVstup);
}
else
{
    Console.WriteLine("nebylo zadané platné číslo");
}


Barva barva = Barva.Modra; // vytvoření proměnné barva typu výčtu Barva s hodnotou Modra
Console.WriteLine(barva); // výpis názvu barvy (Modra)
Console.WriteLine((int)barva); // výpis číselné reprezentace hodnoty výčtu (5)

// Výčtový typ (enum)
 enum Barva
{
    Cervena, // implicitně 0
    Modra = 5, // explicitně přiřazená hodnota 5
    Zelena
}
