using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Time
    {
        private int hour;
        private int minute;
        private int second;
        public int Hour
        {
            get { return hour; }
            set { if (value >= 0 && value < 61) { hour = value; } }
        }
        public int Minute
        {
            get { return minute; }
            set { if (value >= 0 && value < 61) { minute = value; } }
        }
        public int Second
        {
            get { return second; }
            set { if (value >= 0 && value < 61) { second = value; } }
        }
        public Time()
        {
            Hour = 0;
            Minute = 0;
            Second = 0;
        }
        public Time(int _hour, int _minute, int _second)
        {
            Hour = _hour;
            Minute = _minute;
            Second = _second;
        }
    }
}
