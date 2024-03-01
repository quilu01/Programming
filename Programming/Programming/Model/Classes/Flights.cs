using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Flights
    {
        public string DeparturePoint { get; set; }
        public string DestinationPoint { get; set; }
        private int duration;
        public int Duration
        {
            get { return duration; }
            set { if (Validator.AssertOnPositiveValue(value)) { duration = value; } }
        }
        public Flights()
        {
            DeparturePoint = "None";
            DestinationPoint = "None";
            Duration = 0;
        }
        public Flights(string _depPoint, string _desPoint, int _duration)
        {
            DestinationPoint = _desPoint;
            DeparturePoint = _depPoint;
            Duration = _duration;
        }
    }
}
