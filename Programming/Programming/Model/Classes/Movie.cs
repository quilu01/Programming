using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о фильме.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Возвращает или задает имя фильма.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Продолжительность. 
        /// </summary>
        private int duration;
        /// <summary>
        /// Возвращает или задает продолжительность. Только неотрицательные значения.
        /// </summary>
        public int Duration
        {
            get { return duration; }
            set { if (Validator.AssertOnPositiveValue(value)) { duration = value; } }
        }
        /// <summary>
        /// Дата выхода.
        /// </summary>
        private int releaseDate;
        /// <summary>
        /// Возвращает или задает дату выхода. Значения в диапазоне 1989 2025.
        /// </summary>
        public int ReleaseDate
        {
            get { return releaseDate; }
            set { if (Validator.AssertValueInRange(value, 1989, 2025)) { releaseDate = value; } }
        }
        /// <summary>
        /// Возвращает или задает жанр.
        /// </summary>
        public string Genre { get; set; }
        /// <summary>
        /// Рейтинг.
        /// </summary>
        private double rate;
        /// <summary>
        /// Возвращает или задает рейтинг. Значения в диапазоне 0 10.
        /// </summary>
        public double Rate
        {
            get { return rate; }
            set { if (value >= 0.0 && value <= 10.0) { rate = value; } }
        }
        /// <summary>
        /// Создает экземпляр класса.
        /// </summary>
        public Movie()
        {
            Name = "None";
            ReleaseDate = 2000;
            Genre = "None";
            Duration = 0;
            Rate = 0;
        }
        /// <summary>
        /// Создает экземпляр класса.
        /// </summary>
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
