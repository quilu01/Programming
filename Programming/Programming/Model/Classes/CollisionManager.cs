using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    static class CollisionManager
    {
        static bool IsCollision(Rectangles rectangle1, Rectangles rectangle2)
        {
            if (Math.Abs(rectangle1.Center.X - rectangle2.Center.X) < Math.Abs(rectangle1.Widht - rectangle2.Widht) && Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y) < Math.Abs(rectangle1.Lenght - rectangle2.Lenght)) { return true; }
            return false;
        }
        static bool IsCollision(Ring ring1, Ring ring2 )
        {
            double c = Math.Sqrt(Math.Pow(Math.Abs(ring1.Center.X - ring2.Center.X), 2) + Math.Pow(Math.Abs(ring1.Center.Y - ring2.Center.Y), 2));
            if (c < (ring1.OuterRadius + ring2.OuterRadius)) { return true; }
            return false;
        }
    }
}
