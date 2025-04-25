using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Testy
{
    public class Calculator
    {
        public double Addition(double a, double b)
        {
            return a + b;
        }


        public double Division(double a, double b)
        {
            if (b == 0)
                throw new ArgumentException("nelze dělit nulou");

            return a / b;
        }
        public double Subtraction(double a, double b)
        {
            return a - b;
        }

        public double Multiplication(double a, double b)
        {
            return a * b;
        }

    }
}
