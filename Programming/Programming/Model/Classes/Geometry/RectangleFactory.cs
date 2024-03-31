using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    public class RectangleFactory
    {
        
        public static Rectangles New(int CanvasWidht, int CanvasHeight)
        {
            Random rnd = new Random();
            int widht = rnd.Next(20, 100);
            int height = rnd.Next(20, 100);
            return new Rectangles(widht, height, "None", rnd.Next(15, CanvasWidht - widht * 2 - 15), rnd.Next(15, CanvasHeight - height * 2 - 15));
        }
    }
}
