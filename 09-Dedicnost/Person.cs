using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Dedicnost
{
    internal class Person
    {
        protected string _firstName;
        protected string _lastName;

        private int age;

        public Person(string firstName, string lastName, int age) {

            if (age <= 0)
            {
                throw new ArgumentException("Věk musí být kladné číslo");
            }

            _firstName = firstName;
            _lastName = lastName;
            this.age = age;


        }

        public bool IsAdult
        {
            get { return age >= 18; }
        }

        public string FullName
        {
            get { return $"{_firstName} {_lastName}"; }
        }

    }
}
