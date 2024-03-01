using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    static class Validator
    {
        public static bool AssertOnPositiveValue(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException(nameof(value), "Число не может быть отрицательным");
            }
            return true;
        }
        public static bool AssertOnPositiveValue(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException(nameof(value), "Число не может быть отрицательным");
            }
            return true;
        }
        public static bool AssertValueInRange(int value, int min, int max)
        {
            if (!(value >= min && value <= max))
            {
                throw new ArgumentException(nameof(value), "Число не входит в заданный диапазон");
            }
            return true;
        }
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
