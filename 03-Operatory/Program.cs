// operace
int i = 0;
i++; // 1
i += 1; // 2
i = i + 1; // 3

int a = 10; 
int b = 3;
// Predekrementace (--a): Decrementuje 'a' před použitím ve výrazu
int c1 = --a + b; // a = 9, c1 = 9 + 3 = 12
Console.WriteLine($"Predekrementace: a = {a}, c1 = {c1}");

// Resetování 'a' pro další příklad
a = 10;
// Postdekrementace (a--): Decrementuje 'a' po použití ve výrazu
int c2 = a-- + b; // c2 = 10 + 3 = 13, a = 9
Console.WriteLine($"Postdekrementace: a = {a}, c2 = {c2}");


int mod = 3 % 4; // modulo (zbytek po dělení)

// Asociativita a komutativita
// Asociativita: (a + b) + c == a + (b + c)
// Komutativita: a + b == b + a

// Priorita operací 
int c = 4 * 8 / 2 + 7 - 8 / (4 % 5);
// 1) Závorky
//    4 % 5 = 4
// 2) Násobení a dělení
//    4 * 8 = 32
//    32 / 2 = 16
//    8 / 4 = 2
// 3) sčítání a odčítání zleva doprava:
//    16 + 7 - 2 = 21
Console.WriteLine($"c = {c}");


// Bitové operace 

a = 5; b = 3;
int d = a | b; // Bitový OR mezi 'a' a 'b'
// 0101
// 0011
// ----
// 0111 => 7
Console.WriteLine($"Bitový OR (a | b): {d}"); // Výsledek: 7

d = ~a; // Bitová negace 'b' 
d = a & b; // Bitový AND mezi 'a' a 'b'
d = a ^ b; // Bitový XOR mezi 'a' a 'b'


// Booleovské operátory
bool f = true;
bool g = !f; // Logická negace
g = f && true; // Logický AND
g = f || false; // Logický OR


var e = (a == 1 && b == 2) || (b != c2);  // příklad
Console.WriteLine($"Logický OR ((a == 1) || (b != c2)): {e}"); // Výsledek: true

//Ternální oprátor
// podmínka? výrazPokudPravda : výrazPokudNepravda;
int number = 5;
string result = (number > 0) ? "Kladné číslo" : "Záporné číslo nebo nula";
Console.WriteLine(result);


int input = 3;
int o1 = input == 3 ? 1 : 2;
int o2 = input == 3 ? 1 : input == 2 ? 3 : 5;
Console.WriteLine($"o1: {o1}, o2: {o2}");

// Výchozí hodnoty
int m = default; // 0
int? n= default; // null