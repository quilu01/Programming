using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит информацию о контакте.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string name;
        /// <summary>
        /// Возвращает и задает имя контакта. Только буквы.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { if (AssertStringContainsOnlyLetters(value)) { name = value; } }
        }
        /// <summary>
        /// Фамилия контакта.
        /// </summary>
        private string surname;
        /// <summary>
        /// Возвращает и задает фамилию контакта.
        /// </summary>
        public string Surname
        {
            get { return surname; }
            set { if (AssertStringContainsOnlyLetters(value)) { surname = value; } }
        }
        /// <summary>
        /// Возвращает и заадет номер контакта.
        /// </summary>
        private int Number { get; set; }
        /// <summary>
        /// Проверяет, что аргумент имеет только буквы.
        /// </summary>
        /// <param name="value"> Проверяемый параметр.</param>
        /// <returns>Возвращает true если только буквы, и ArgumentException если нет.</returns>
        /// <exception cref="ArgumentException"></exception>
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
        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>
        /// </summary>
        public Contact()
        {
            Name = "None";
            Surname = "None";
            Number = 0;
        }
        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>
        /// </summary>
        /// <param name="_name">Имя. Содержит только буквы.</param>
        /// <param name="_surname">Фамилия. Содержит только буквы.</param>
        /// <param name="_number">Номер телефона.</param>
        public Contact(string _name, string _surname, int _number)
        {
            Name = _name;
            Surname = _surname;
            Number = _number;
        }
    }
}
