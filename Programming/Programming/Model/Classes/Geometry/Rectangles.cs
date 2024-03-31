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
        private int widht;
        private int height;
        private readonly int id;
        
        public int Id { get { return id; } set { AllRectanglesCount(); } }
        public string Color { get; set; }
        public Point2D Center;
        
        public static int AllRectanglesCount() { return _allRectanglesCount; }

        public int Widht
        {
            get { return widht; }
            set { if (Validator.AssertOnPositiveValue(value)) { widht = value; } }
        }

        public int Height
        {
            get { return height; }
            set { if (Validator.AssertOnPositiveValue(value)) { height = value; } }
        }
        public Rectangles()
        {
            Widht = 10;
            Height = 10;
            Color = "";
            Center = new Point2D(0, 0);
            _allRectanglesCount += 1;
            id = AllRectanglesCount();
        }
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
