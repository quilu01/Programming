using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Ring
    {
        public Point2D Center;
        private double outerRadius;
        private double innerRadius;
        
        public double OuterRadius
        {
            get { return outerRadius;  }
            set { if (Validator.AssertOnPositiveValue(value) && Validator.AssertValueInRange(value, innerRadius, 1000000)) outerRadius = value; }
        }
        public double InnerRadius
        {
            get { return innerRadius; }
            set { if (Validator.AssertOnPositiveValue(value) && Validator.AssertValueInRange(value, 0, outerRadius)) innerRadius = value; }
        }
        public double Area
        {
            get { return 3.14 * (Math.Pow(OuterRadius, 2) - Math.Pow(InnerRadius, 2)); } 
        }
    }
}
