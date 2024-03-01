using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Point2D
    {
        private int x;
        private int y; 
        public int X
        {
            get { return x;  }
            private set
            {
                if (Validator.AssertOnPositiveValue(value)) { x = value; }
            }
        }
        public int Y
        {
            get { return y; }
            private set
            {
                if (Validator.AssertOnPositiveValue(value)) { y = value; }
            }
        }
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }
        
    }
}
