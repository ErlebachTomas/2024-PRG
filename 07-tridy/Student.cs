namespace _07_tridy
{
    class Student
    {
        // Privátní datové členy (fields) - dostupné pouze uvnitř třídy
        private string _firstName;    // Jméno studenta
        private string _lastName;     // Příjmení studenta

        // Veřejná vlastnost s privátním setterem - věk lze měnit pouze uvnitř třídy
        public int Age { get; private set; }
        // Veřejná vlastnost s inicializátorem pouze pro čtení (init)
        public string StudentID { get; init; }  // Hodnotu lze nastavit pouze při vytvoření instance

        public string ClassName { get; set; } = "1A";  // Defaultní hodnota "1A"

        // Konstruktor s parametry
        public Student(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public string FirstName
        {
            // Setter s jednoduchou validací (nepovolíme jméno "Anonym")
            set
            {
                if (value != "Anonym")
                    _firstName = value;
            }
            // Getter pro získání hodnoty
            get
            {
                return _firstName;
            }
        }          

        // Vlastnost pouze pro čtení - kombinace jména a příjmení
        public string FullName
        {
            get
            {
                return _firstName + " " + _lastName;
            }
        }
           
        // Metoda pro nastavení věku s validací
        public void SetAge(int age)
        {
            if (age > 0 && age < 120)
                Age = age;
        }

        // Přetížená metoda pro nastavení věku z řetězce
        public void SetAge(string age)
        {
            if (int.TryParse(age, out int parsedAge))
            {
                SetAge(parsedAge);
            }
        }

        // Metoda pro získání věku
        public int GetAge()
        {
            return Age;
        }
    }
}


