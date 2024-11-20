using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_interface
{
    internal interface IReadable // rozhraní 
    {
        string Content { get; }
        int Pages { get; }
    }
}
