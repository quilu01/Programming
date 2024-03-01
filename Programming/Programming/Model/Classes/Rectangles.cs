using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Rectangles
    {
        private static int _allRectanglesCount = 0;
        private double widht;
        private double lenght;
        private readonly int id;
        
        public int Id { get { return id; } set { AllRectanglesCount(); } }
        public string Color { get; set; }
        public Point2D Center;
        
        public static int AllRectanglesCount() { return _allRectanglesCount; }

        public double Widht
        {
            get { return widht; }
            set { if (Validator.AssertOnPositiveValue(value)) { widht = value; } }
        }

        public double Lenght
        {
            get { return lenght; }
            set { if (Validator.AssertOnPositiveValue(value)) { lenght = value; } }
        }
        public Rectangles()
        {
            Widht = 10;
            Lenght = 10;
            Color = "None";
            Center = new Point2D(0, 0);
            _allRectanglesCount += 1;
            id = AllRectanglesCount();
        }
        public Rectangles(double _widht, double _lenght, string _color, int _x, int _y)
        {
            Widht = _widht;
            Lenght = _lenght;
            Color = _color;
            Center = new Point2D(_x, _y);
            _allRectanglesCount += 1;
            id = AllRectanglesCount();
        }
    }
}
