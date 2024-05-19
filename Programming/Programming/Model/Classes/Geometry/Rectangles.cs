using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит информацию о прямоугольнике.
    /// </summary>
    public class Rectangles
    {
        /// <summary>
        /// Количество всех прямоугольников.
        /// </summary>
        private static int _allRectanglesCount = 0;
        /// <summary>
        /// Ширина прямоугольника.
        /// </summary>
        private int widht;
        /// <summary>
        /// Длина прямоугольника.
        /// </summary>
        private int height;
        /// <summary>
        /// Уникальный Id.
        /// </summary>
        private readonly int id;
        /// <summary>
        /// Возвращает и задает Id.
        /// </summary>
        public int Id { get { return id; } set { AllRectanglesCount(); } }
        /// <summary>
        /// Возвраащет и задает цвет.
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// Возвращает и задает центр прямоугольника.
        /// </summary>
        public Point2D Center;
        /// <summary>
        /// Возвращает количество всех прямоугольников.
        /// </summary>
        /// <returns></returns>
        public static int AllRectanglesCount() { return _allRectanglesCount; }
        /// <summary>
        /// Возвращает и задает значение ширины. Только неотрицательные значения.
        /// </summary>
        public int Widht
        {
            get { return widht; }
            set { if (Validator.AssertOnPositiveValue(value)) { widht = value; } }
        }
        /// <summary>
        /// Возвращает и задает значение длины. Только неотрицательные значения.
        /// </summary>
        public int Height
        {
            get { return height; }
            set { if (Validator.AssertOnPositiveValue(value)) { height = value; } }
        }
        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangles"/>
        /// </summary>
        public Rectangles()
        {
            Widht = 10;
            Height = 10;
            Color = "";
            Center = new Point2D(0, 0);
            _allRectanglesCount += 1;
            id = AllRectanglesCount();
        }
        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangles"/>
        /// </summary>
        /// <param name="_widht">Значение ширины. Только неотрицательные значения.</param>
        /// <param name="_height">Значение длины. Только неотрицательные значения.</param>
        /// <param name="_color">Значение цвета.</param>
        /// <param name="_x">Значения X.</param>
        /// <param name="_y">Значения Y.</param>
        public Rectangles(int _widht, int _height, string _color, int _x, int _y)
        {
            Widht = _widht;
            Height = _height;
            Color = _color;
            Center = new Point2D(_x+((int)_widht/2), _y+((int)_height/2));
            _allRectanglesCount += 1;
            id = AllRectanglesCount();
        }
    }
}
