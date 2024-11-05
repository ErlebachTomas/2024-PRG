using _08_OOP;

Kruh kruh = new Kruh(5);
// Výpočet a zobrazení obsahu kruhu kruh1
double obsah = kruh.Obsah;
Console.WriteLine($"Obsah kruhu s poloměrem {kruh.Polomer} je {obsah}");

kruh.ZmenitVelikost(2); // volání veřejné metody

Kruh.VypocitatObvod(5); // volání statické metody