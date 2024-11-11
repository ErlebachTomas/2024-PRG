using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Dedicnost
{
    internal class Teacher : Person
    {
       
        public Teacher(string firstName, string lastName, int age, string room, string? titleBefore = null, string? titleAfter = null)
            : base(firstName, lastName, age)
        {
            Room = room;
            TitleBefore = titleBefore;
            TitleAfter = titleAfter;
        }

        // Vlastnost pro číslo kabinetu
        public string Room { get; set; }

        // Volitelný titul před jménem
        public string? TitleBefore { get; set; }

        // Volitelný titul za jménem
        public string? TitleAfter { get; set; }

        // Metoda pro výpis informace o tom, kde učitel sídlí
        public string DetailedInfo()
        {
            string name = $"{TitleBefore ?? ""} {base._lastName} {TitleAfter ?? ""}".Trim();
            return $"{name} sídlí v kabinetu {Room}";
           
           
        }


    }
}
