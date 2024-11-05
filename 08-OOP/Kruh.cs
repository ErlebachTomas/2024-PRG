using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_OOP
{
    internal class Kruh
    {

        // Atribut poloměru
        private double _polomer;

        // Vlastnost poloměru
        public double Polomer
        {
            get { return _polomer; }

            set
            {
                if (value > 0)
                {
                    _polomer = value;
                }
                else
                {
                    throw new ArgumentException("Poloměr musí být kladné číslo.");
                }
            }

        }
        // Konstruktor s volitelným parametrem poloměru
        public Kruh(double polomer = 1.0)
        {
            Polomer = polomer;
        }

        // Vlastnost pouze pro výpočet obsahu
        public double Obsah
        {
            get { return Math.PI * _polomer * _polomer; }
        }

        // Metoda pro změnu poloměru (mění stav objektu)
        public void ZmenitVelikost(double koeficient)
        {
            _polomer *= koeficient;
        }        
       
        // funkce pro výpočet obvodu
        public static double VypocitatObvod(double polomer)
        {
            return 2 * Math.PI * polomer;
        }

        public double Obvod
        {
            get { return VypocitatObvod(_polomer); }
        }       
    }
}
