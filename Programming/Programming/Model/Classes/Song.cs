using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о песне.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Вовзаращает или задает название.
        /// </summary>
        private string Name { get; set; }
        /// <summary>
        /// Вовзаращает или задает альбом.
        /// </summary>
        private string Album { get; set; }
        /// <summary>
        /// Продолжительность.
        /// </summary>
        private int duration;
        /// <summary>
        /// Вовзаращает или задает продолжительность.
        /// </summary>
        public int Duration
        {
            get { return duration; }
            set { if (Validator.AssertOnPositiveValue(value)) { duration = value; } }
        }
        /// <summary>
        /// Создает экземпляр класса.
        /// </summary>
        public Song()
        {
            Name = "None";
            Album = "None";
            Duration = 0;
        }
        /// <summary>
        /// Создает экземпляр класса.
        /// </summary>
        public Song(string _name, string _album, int _duration)
        {
            Name = _name;
            Album = _album;
            Duration = _duration;
        }
    }
}
