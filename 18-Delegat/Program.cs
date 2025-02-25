List<int> numbers = new List<int> { 1, 2, 3, 7, 8, 5, 9, 6, 1, 4, 8, 4 };
Console.WriteLine(numbers.CountOdd()); // volani rozsirujici funkce

List<string> list = new List<string>();
list.Add("Hello, Petr");
list.Add("Hello, Jana ");
list.Add("Hello, Lukáš");
list.Add("Welcome, Karel");

foreach (string item in list
    .Where(x => x.StartsWith("H"))
    .OrderBy(x => x)
    ) // Lambda výra pro definici filtru a třídění.
{
    Console.WriteLine(item);
}

Console.WriteLine(CallMathOp(4, 5, Addition));
// Lambda výraz (i, j) => { return (i + j); } nahrazuje předchozí metodu Addition.
Console.WriteLine(CallMathOp(4, 5, (i, j) => { return (i + j); }));
float CallMathOp(float l, float m, BinaryMathOp op)
{
    return op(l, m);
}
// generický delegát Func
float CallOp(float l, float m, Func<float, float, float> op) // parametry + návratová hodnota
{
    return (float)op(l, m);
}
// Metoda, která provádí sčítání dvou čísel.
float Addition(float x, float y) { return x + y; }
// Definice vlastního delegátu
delegate float BinaryMathOp(float a, float b); // : delegát


// ------
// ------
// Ukázky různých zápisů lambda výrazů:
//
// () => {...}             // Lambda výraz bez parametrů
// x => return x * 2        // Lambda výraz s jedním parametrem, kde se výslovně používá klíčové slovo return
// x => (x * 2)             // Lambda výraz s jedním parametrem, kde se návratová hodnota počítá implicitně
// (int x, int y) => { return x * y; }  // Lambda výraz s explicitně definovanými typy parametrů a blokem kódu
// (x, y) => { return x * y; }           // Lambda výraz s odvozenými typy parametrů a blokem kódu
// (x, y) => (x * y)                    // Lambda výraz, který přímo vrací výsledek výpočtu bez blokové syntaxe
// -------
// Přehled předdefinovaných generických delegátů:
//
// Func<T1, T2, ..., TR>   // Reprezentuje funkci, která přijímá vstupy typu T1, T2, ... a vrací hodnotu typu TR
// Action<T1, T2>          // Reprezentuje akci, která přijímá vstupy typu T1, T2 a nevrací žádnou hodnotu
// Predicate<T>            // Reprezentuje metodu, která bere parametr typu T a vrací boolovskou hodnotu (true/false)