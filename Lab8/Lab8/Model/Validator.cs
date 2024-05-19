using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Model
{
    public class Validator
    {
        /// <summary>
        /// Проверка на длину строки.
        /// </summary>
        /// <param name="string_">Проверяемая строка.</param>
        /// <param name="lenght">Максимальная длина.</param>
        /// <returns>Возвращает ArgumentException, если длина строки превышает заданную, и true если нет.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool StringLenght(string string_, int lenght)
        {
            if (string_.Length > lenght)
            {
                throw new ArgumentException();
            }
            return true;
        }
        /// <summary>
        /// Проверяет аргумент на вхождение в заданный диапазон.
        /// </summary>
        /// <param name="value">Проверяемый аргумент.</param>
        /// <param name="min">Нижняя граница.</param>
        /// <param name="max">Верхняя граница.</param>
        /// <returns>Возвращает true если аргумент входит, и ArgumentException если нет.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool AssertValueInRange(double value, double min, double max)
        {
            if (!(value >= min && value <= max)) {
                throw new ArgumentException();
            }
            return true ;
        }
    }
}
