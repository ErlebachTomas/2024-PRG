int a;  // deklarace
a = 10; // inicializace
int b = 10; // deklarace +  inicializace

string c = "Ahoj";

string jmenoStudenta = "Karel Novák"; // camelCase 
const string JMENO_STUDENTA = "konstanta"; // konstanta s velké písmeno s potržítky 
//class Stundent() { } // třídy začínají velkým písmenem

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


void Vypis()
{
    Console.WriteLine("jen vypis");
}



//Console.WriteLine(Sctani(10, 10));

int x = 10;
int y = 10;

Sctani(x, y); // 30
Console.WriteLine("hodnota x: " + x);// 10 

int Sctani(int x, int y)
{

    x = 20; // pouze změna lokální proměné 
    return x + y;

}

int ScitaniSReferenci(ref int x, ref int y)
{
    x = 20; // změna globální proměnné
    return x + y;
}

ScitaniSReferenci(ref x, ref y); // 30
Console.WriteLine("hodnota x: " + x); // 20



int? cisloNeboNull = 5;

if (cisloNeboNull == null)
{

    Console.WriteLine("proměnná je null");
}
else
{
    Console.WriteLine("proměnná má hodnotu:" + cisloNeboNull);
}

string? vstup = Console.ReadLine();

// int ciselnyVstup = int.Parse(vstup);
int ciselnyVstup;
bool uspech = int.TryParse(vstup, out ciselnyVstup);

if (uspech)
{

    Console.WriteLine(ciselnyVstup);
}
else
{
    Console.WriteLine("nebylo zadané platné číslo");
}


Barva barva = Barva.Modra;
Console.WriteLine(barva);
Console.WriteLine((int)barva);



// Výčtový typ
enum Barva
{
    Cervena,
    Modra = 5,
    Zelena
}
