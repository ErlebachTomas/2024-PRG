using _11_interface;

Reader tonda = new Reader( "Antonín");
Book bab = new Book { Name = "Babička", Content = "Něco s nějakou starou paní." };
Book lotr = new Book { Name = "Pán prstenů", Content = "Něco s nějakým prstenem a trpaslíkama." };
Magazine blesk = new Magazine { Content = "Agáta Hanychová zase něco provedla" };

// Použití metody Read k přečtení obsahu různých typů
Console.WriteLine(tonda.Read(blesk));
Console.WriteLine(tonda.Read(bab));

// Porovnání dvou knih na základě počtu stran
Console.WriteLine(bab.CompareTo(lotr));

/*
 IComparable - poskytuje možnost porovnávání dvou objektů (<, >)
 IEquitable - umožňuje porovnávat objekty pro rovnost (==, !=)
 IEnumerable - umožňuje procházet kolekce pomocí foreach
 IDisposable - umožňuje explicitní uvolnění zdrojů
 IEnumerator - slouží k iteraci přes kolekce
*/

IReadable[] readings = { bab, lotr, blesk };
foreach (IReadable reading in readings)
{
    Console.WriteLine(tonda.Read(reading));
}

