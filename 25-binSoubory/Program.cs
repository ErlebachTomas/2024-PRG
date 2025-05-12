using System.Text;

string cesta = "data.csv";

// Zápis do CSV
using (StreamWriter sw = new StreamWriter(cesta))
{
    sw.WriteLine("Jmeno,Prijmeni,Vek");
    sw.WriteLine("Jan,Novak,25");
    sw.WriteLine("Petr,Skala,30");
}

// Načtení a parsování CSV
using (StreamReader sr = new StreamReader(cesta))
{
    string hlavicka = sr.ReadLine();
    Console.WriteLine(hlavicka);
    
    string radek;
    while ((radek = sr.ReadLine()) != null)
    {
       string[] hodnoty = radek.Split(",");
      
        foreach (string hodnota in hodnoty)
        {
            Console.Write(hodnota + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();
Console.WriteLine("Binární data");
string binCesta = "data.bin";
byte[] data = { 0x41, 0x42, 0x43, 0x44 }; // ASCII: 'A', 'B', 'C', 'D'

// Zápis do binárního souboru
using (FileStream fs = new FileStream(binCesta, FileMode.Create, FileAccess.Write))
using (BinaryWriter bw = new BinaryWriter(fs, Encoding.ASCII))
{
    bw.Write(data);
}

// Čtení z binárního souboru
using (FileStream fs = new FileStream(binCesta, FileMode.Open, FileAccess.Read))
using (BinaryReader br = new BinaryReader(fs, Encoding.ASCII))
{
    byte[] nactenaData = br.ReadBytes((int)fs.Length);
   
    foreach (byte b in nactenaData)
    {
        Console.Write((char)b + " ");
    }
}