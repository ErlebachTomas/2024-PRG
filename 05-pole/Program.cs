// Ukázka práce s poli v C#

// Deklarace a inicializace pole o velikosti 7 s defaultními hodnotami (nuly)
int[] emptyArr = new int[7];
printArray2(emptyArr);
// Inicializace pole s předdefinovanými hodnotami
int[] numbers2 = { 1, 2, 3, 4, 5, 6, 7 };
printArray(numbers2);
// Změna hodnoty na indexu 3
numbers2[3] = 100;
printArray(numbers2);

// Výpis délky pole
Console.WriteLine("Délka pole: " + numbers2.Length);

// Řazení pole vzestupně
Array.Sort(numbers2);

// Otočení pole
Array.Reverse(numbers2);

// Zjištění, zda pole obsahuje hodnotu 6
Console.WriteLine("Obsahuje pole hodnotu 6? " + numbers2.Contains(6));

// Zjištění indexu hodnoty 9 (není v poli, vrátí -1)
Console.WriteLine("Index hodnoty 9: " + Array.IndexOf(numbers2, 9));

// Maximální délka pole
Console.WriteLine("Maximální délka pole: " + Array.MaxLength);

// Vyplnění pole hodnotou 1
Array.Fill(emptyArr, 1);

// Vynásobení hodnot pole numbers2 hodnotou 5
int[] numbers3 = MultiplyValues(numbers2, 5);

// Deklarace a inicializace dvourozměrného pole (matice)
int[,] map = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

foreach (int x in map)
{
    Console.Write(x + ","); // Výpis hodnot matice
}
Console.WriteLine("Počet dimenzí matice: " + map.Rank);

// Výpis hodnot matice pomocí cyklů
Console.WriteLine("Výpis hodnot matice pomocí cyklů:");
for (int i = 0; i < map.GetLength(0); i++)
{
    Console.Write("[ ");
    for (int j = 0; j < map.GetLength(1); j++)
    {
        Console.Write(map[i, j] + " ");
    }
    Console.Write("]");
}
Console.WriteLine();

// Deklarace a inicializace zubatého pole (jagged array)
/*
 int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
        jaggedArray[1] = new int[] { 0, 2, 4, 6 };
        jaggedArray[2] = new int[] { 11, 22 };
*/
int[][] jaggedArray =
[
    [1, 3, 5, 7, 9],
    [0, 2, 4, 6],
    [11, 22],
];

// Změna hodnoty v zubatém poli
jaggedArray[0][1] = 77;

// Výpis hodnot zubatého pole
Console.WriteLine("zubaté pole:");
foreach (int[] row in jaggedArray)
{
    foreach (int value in row)
    {
        Console.Write(value + " ");
    }
}
Console.WriteLine();

// Výpis hodnot zubatého pole pomocí cyklů
for(int i = 0; i < jaggedArray.Length; i++)
{
    Console.Write("[ ");
    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.Write(jaggedArray[i][j] + " ");
    }
    Console.Write("]");
}


// Ukázka reference na stejné pole
int[] arr1 = { 1, 2, 3, 4, 5 };
int[] arr2 = arr1; // arr2 odkazuje na stejné pole jako arr1
arr2[2] = 100;
Console.WriteLine("Hodnota na indexu 2 v arr1: " + arr1[2]); // Výsledek bude 100

// Ukázka vytvoření kopie pole
int[] a = {5, 6, 7, 8, 9 };
int[] b = (int[])a.Clone(); // Vytvoření kopie pole
b[2] = 100;
Console.WriteLine("Hodnota na indexu 2 v a: " + a[2]); // Výsledek bude 7

void printArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i < numbers.Length - 1)
        {
            Console.Write(numbers[i] + ", "); // Výpis hodnot pole
        } else
        {
            Console.WriteLine(numbers[i]);
        }       
    } 
}

void printArray2(int[] numbers)
{
    foreach (int i in numbers) {
        Console.Write(i + ", ");
    }
    Console.WriteLine();
}

int[] MultiplyValues(int[] arr, int value)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= value;
    }
    return arr;
}

void MultiplyValues2(ref int[] arr, int value)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= value;
    }
}
