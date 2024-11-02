using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Service
{
    /// <summary>
    /// Валидация значений.
    /// </summary>
    static class ValueValidator
    {
        /// <summary>
        /// Проверяет, является ли длина строки меньше заданного значения. Если нет, то выбрасывает исключение.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="maxLenght">Максимальная длина.</param>
        /// <param name="propertyName">Название свойства, в котором был вызван метод.</param>
        /// <returns>Возвращает true если меньше, и ArgumentException если больше.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool AssertStringOnLength(string value, int maxLenght, string propertyName)
        {
            propertyName = nameof(propertyName);
            if (value.Length >= maxLenght)
            {
                throw new ArgumentException($"{propertyName} должен быть меньше {maxLenght}символов");
            }
            else
            {
                return true;
            }
        }
        public static bool AssertOnValue(int  value, int maxValue, string propertyName)
        {
            propertyName = nameof(propertyName);
            if (value < 0 || value > maxValue)
            {
                throw new ArgumentException($"{propertyName} должен быть меньше {maxValue}");
            }
            else
            {
                return true;
            }
        }
        public static bool AssertOnPositiveValue(int value, string propertyName)
        {
            if (value >= 0)
            {
                return true;
            }
            else
            {
                throw new ArgumentException($"{propertyName} должен быть больше 0");
            }
        }
    }
}
