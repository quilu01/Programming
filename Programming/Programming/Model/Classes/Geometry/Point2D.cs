using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о координатах.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Значение X.
        /// </summary>
        private int x;
        /// <summary>
        /// Значение Y.
        /// </summary>
        private int y; 
        /// <summary>
        /// Возвращает и задает координату X. Только неотрицательные значения.
        /// </summary>
        public int X
        {
            get { return x;  }
            set
            {
                if (Validator.AssertOnPositiveValue(value)) { x = value; }
            }
        }
        /// <summary>
        /// Возвращает и задает координату Y. Только неотрицательные значения.
        /// </summary>
        public int Y
        {
            get { return y; }
            set
            {
                if (Validator.AssertOnPositiveValue(value)) { y = value; }
            }
        }
        /// <summary>
        /// Создает экземпляр класса <see cref="Point2D"/>
        /// </summary>
        /// <param name="x">Координата X. Только неотрицательное значение.</param>
        /// <param name="y">Координата Y. Только неотрицательное значение.</param>
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }
        
    }
}
