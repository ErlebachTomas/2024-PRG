using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_interface
{
    internal class Magazine : IReadable
    {
        public string Content { get; set; }
        public int Pages { get { return Content.Length; } }
    }
}
