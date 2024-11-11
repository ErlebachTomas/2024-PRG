using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Dedicnost
{
    internal class Student : Person
    {
        public string ClassName { get; set; }
        public Student(string className, string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
            ClassName = className;
        }

        public string getInfo()
        {
            string status = IsAdult ? "je plnoletá/plnoletý" : "není plnoletá/plnoletý";
            return $"{FullName} chodí do třídy {ClassName} a {status}.";
        }


    }
}
