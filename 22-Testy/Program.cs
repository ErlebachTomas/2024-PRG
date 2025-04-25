using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using static Diagnostika;
using System.Text;

/*
 Do nového testovacího projektu je potřeba 
 přidat odkaz na testovaný projekt.

V kontextovém menu nového projektu 
vybrat Add/Project Reference... a vybrat testovaný projekt. 
*/
Console.WriteLine("Ukázka jednotkových testů, Nabídka Test > Run All Tests");
Console.WriteLine();

/*
 Přes menu \Tools\NuGet Package Manager ...\Manage Packages for Solution ..., najít BenchmarkDotNet
Z příkazové řádky "dotnet add package BenchmarkDotNet" 
 */
var results = BenchmarkRunner.Run<Demo>();
public class Diagnostika
{
    [MemoryDiagnoser]
    public class Demo
    {
        [Benchmark(Baseline = true)]
        public string GetFullStringNormally()
        {
            string output = "";
            for (int i = 0; i < 100; i++)
            {
                output += i + " ";
            }
            return output;
        }
    [Benchmark]
        public string GetFullStringUsingStringBuilder()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                sb.Append(i + " ");
            }
            return sb.ToString();
        }
    }
}