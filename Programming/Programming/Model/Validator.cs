using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Содержит методы для проверки значений.
    /// </summary>
    static class Validator
    {
        /// <summary>
        /// Проверяет аргумент на неотрицательность.
        /// </summary>
        /// <param name="value">Проверяемый аргумент.</param>
        /// <returns>Возвращает true если аргумент неотрицательный, и ArgumentException если нет.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool AssertOnPositiveValue(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException(nameof(value), "Число не может быть отрицательным");
            }
            return true;
        }
        /// <summary>
        /// Проверяет аргумент на неотрицательность.
        /// </summary>
        /// <param name="value">Проверяемый аргумент.</param>
        /// <returns>Возвращает true если аргумент неотрицательный, и ArgumentException если нет.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool AssertOnPositiveValue(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException(nameof(value), "Число не может быть отрицательным");
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
        public static bool AssertValueInRange(int value, int min, int max)
        {
            if (!(value >= min && value <= max))
            {
                throw new ArgumentException(nameof(value), "Число не входит в заданный диапазон");
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
            if (!(value >= min && value <= max))
            {
                throw new ArgumentException(nameof(value), "Число не входит в заданный диапазон");
            }
            return true;
        }
    }
}
