using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_interface { 

internal class Book : IReadable, IComparable<Book>
{
  
    public string Name { get; set; }  
    public string Content { get; set; }

    public int Pages { get { return Content.Split(" ").Count(); } }

    // Metoda pro porovnání knih na základě počtu stran
    public int CompareTo(Book? other)
    {
        return Pages.CompareTo(other.Pages);
    }
}
}
