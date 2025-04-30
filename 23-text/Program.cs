// --- Řetězce ---
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;


char[] letters = { 'H', 'e', 'l', 'l', 'o' };
string greeting = new string(letters);

string s = "kč";
int a = 12;

Console.WriteLine(a + s); // 12kč
Console.WriteLine(string.Format("stojí to {0} {1}", a, s));

Console.WriteLine("první řádek \n druhý řádek");

Console.WriteLine(@"Verbatim řetězec
    může být klidně na víc řádek a nejsou
    v nich interpretovány únikové sekvence, 
    ""uvozovky"" je potřeba zdvojit.");

Console.WriteLine("""
                  Raw řetězce jsou nový způsob, 
                  jak psát víceřádkové řetězce 
                  obsahující také "uvozovky".
                  """);

StringBuilder sb = new StringBuilder();
sb.Append("Ahoj");
sb.Append(" ");
sb.Append("s");
sb.Append("věte");
string s2 = sb.ToString();

// --- Metody řetězců ---
string text = "Tento program vypisuje výsledky na obrazovku.";
Console.WriteLine(text.Substring(6, 7));        // program
Console.WriteLine(text.Contains("výsledky"));    // True
Console.WriteLine(text.IndexOf("vypisuje"));     // 14
Console.WriteLine(text.Replace("výsledky", "data")); // Tento program vypisuje data na obrazovku.
Console.WriteLine(text.Remove(text.IndexOf(" na"), " na obrazovku".Length)); // Tento program vypisuje výsledky.

// --- Rozdělení řetězce na slova ---
string[] rozdelena = text.Split(' ');
foreach (var slovo in rozdelena)
{
    Console.WriteLine($"<{slovo}>");
}

// --- Další metody pro práci s textem ---
string veta2 = "  Šílená čivava  ";
Console.WriteLine(veta2.ToLower()); // šílená čivava
Console.WriteLine(veta2.ToUpper()); // ŠÍLENÁ ČIVAVA
Console.WriteLine(veta2.Trim()); // Šílená čivava

// --- Datum a čas ---
DateTime datum = new DateTime(2024, 4, 25);
Console.WriteLine(datum.ToString("d", CultureInfo.GetCultureInfo("cs-CZ"))); // 25. 4. 2024
Console.WriteLine(datum.ToString("D", CultureInfo.GetCultureInfo("cs-CZ"))); // čtvrtek 25. dubna 2024
Console.WriteLine(datum.ToString("D", CultureInfo.GetCultureInfo("en-US"))); // Thursday, April 10, 2008

// --- Práce s regulárními výrazy ---
string text2 = "Kontakt: jan.novak@email.cz a adresa je 120 00 Praha 2. Záložní email: info@firma.org a staré PSČ 73535.";

// Najdi česká PSČ
MatchCollection psc = Regex.Matches(text2, @"\b\d{3}\s?\d{2}\b");
foreach (Match match in psc)
{
    Console.WriteLine($"Nalezené PSČ: {match.Value}");
}

//Libovolné jedno číslo (0–9)
string vstup1 = "Číslo: 7";
string vzor1 = @"\d";
Console.WriteLine("Obsahuje číslo: " + Regex.IsMatch(vstup1, vzor1)); // true

// Najdi konkrétní slovo "pes"
string veta3 = "Můj pes je hodný. Pes je nejlepší přítel člověka.";
MatchCollection nalezenoPes = Regex.Matches(veta3, @"pes", RegexOptions.IgnoreCase);
foreach (Match match in nalezenoPes)
{
    Console.WriteLine($"Nalezeno slovo 'pes' na pozici: {match.Index}");
}

// Najdi řádek začínající písmenem "P"
string viceRadku = "Pes běží.\nPták letí.\nKočka spí.";
MatchCollection radkyP = Regex.Matches(viceRadku, @"^P.*", RegexOptions.Multiline);
foreach (Match match in radkyP)
{
    Console.WriteLine($"Řádek začínající P: {match.Value}");
}


