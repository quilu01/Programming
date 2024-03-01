using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { if (AssertStringContainsOnlyLetters(value)) { name = value; } }
        }
        private string surname;
        public string Surname
        {
            get { return surname; }
            set { if (AssertStringContainsOnlyLetters(value)) { surname = value; } }
        }
        private int Number { get; set; }

        private bool AssertStringContainsOnlyLetters(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                {
                    throw new ArgumentException(nameof(value), "Некорректное значение");
                }
            }
            return true;
        }
        public Contact()
        {
            Name = "None";
            Surname = "None";
            Number = 0;
        }
        public Contact(string _name, string _surname, int _number)
        {
            Name = _name;
            Surname = _surname;
            Number = _number;
        }
    }
}
