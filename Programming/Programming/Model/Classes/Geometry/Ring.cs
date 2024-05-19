using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о кольце.
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Значение центра кольца.
        /// </summary>
        public Point2D Center;
        /// <summary>
        /// Значение внешнего радиуса.
        /// </summary>
        private double outerRadius;
        /// <summary>
        /// Значение внутреннего радиуса.
        /// </summary>
        private double innerRadius;
        /// <summary>
        /// Возвращает и задает значение внешнего радиуса.
        /// </summary>
        public double OuterRadius
        {
            get { return outerRadius;  }
            set { if (Validator.AssertOnPositiveValue(value) && Validator.AssertValueInRange(value, innerRadius, 1000000)) outerRadius = value; }
        }
        /// <summary>
        /// Возвращает и задает значение внутреннего радиуса.
        /// </summary>
        public double InnerRadius
        {
            get { return innerRadius; }
            set { if (Validator.AssertOnPositiveValue(value) && Validator.AssertValueInRange(value, 0, outerRadius)) innerRadius = value; }
        }
        /// <summary>
        /// Возвращает площадь кольца.
        /// </summary>
        public double Area
        {
            get { return 3.14 * (Math.Pow(OuterRadius, 2) - Math.Pow(InnerRadius, 2)); } 
        }
    }
}
