using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит значения о времени.
    /// </summary>
    public class Time
    {
        /// <summary>
        /// Часы.
        /// </summary>
        private int hour;
        /// <summary>
        /// Минуты.
        /// </summary>
        private int minute;
        /// <summary>
        /// Секунды.
        /// </summary>
        private int second;
        /// <summary>
        /// Вовзаращает или задает часы.
        /// </summary>
        public int Hour
        {
            get { return hour; }
            set { if (value >= 0 && value < 61) { hour = value; } }
        }
        /// <summary>
        /// Вовзаращает или задает минуты.
        /// </summary>
        public int Minute
        {
            get { return minute; }
            set { if (value >= 0 && value < 61) { minute = value; } }
        }
        /// <summary>
        /// Вовзаращает или задает секунды.
        /// </summary>
        public int Second
        {
            get { return second; }
            set { if (value >= 0 && value < 61) { second = value; } }
        }
        /// <summary>
        /// Создает экземпляр класса.
        /// </summary>
        public Time()
        {
            Hour = 0;
            Minute = 0;
            Second = 0;
        }
        /// <summary>
        /// Создает экземпляр класса.
        /// </summary>
        public Time(int _hour, int _minute, int _second)
        {
            Hour = _hour;
            Minute = _minute;
            Second = _second;
        }
    }
}
