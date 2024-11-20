using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_interface
{
    internal class Reader
    {
        public string Name { get; set; }

        public Reader(string name) { 
            Name = name;
        }
        public string Read(IReadable something)
        {
            return $"přečetl {something.Pages} stran, {something.Content}";
        }
    }
}
