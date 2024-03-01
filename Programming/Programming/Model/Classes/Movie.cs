using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Movie
    {
        public string Name { get; set; }
        private int duration;
        public int Duration
        {
            get { return duration; }
            set { if (Validator.AssertOnPositiveValue(value)) { duration = value; } }
        }
        private int releaseDate;
        public int ReleaseDate
        {
            get { return releaseDate; }
            set { if (Validator.AssertValueInRange(value, 1989, 2025)) { releaseDate = value; } }
        }
        public string Genre { get; set; }
        private double rate;
        public double Rate
        {
            get { return rate; }
            set { if (value >= 0.0 && value <= 10.0) { rate = value; } }
        }
        public Movie()
        {
            Name = "None";
            ReleaseDate = 2000;
            Genre = "None";
            Duration = 0;
            Rate = 0;
        }
        public Movie(string _name, int _duration, int _releaseDate, string _genre, double _rate)
        {
            Name = _name;
            Duration = _duration;
            ReleaseDate = _releaseDate;
            Genre = _genre;
            Rate = _rate;
        }
    }
}
