using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о полетах.
    /// </summary>
    public class Flights
    {
        /// <summary>
        /// Возвраащет или задает точку отправления.
        /// </summary>
        public string DeparturePoint { get; set; }
        /// <summary>
        /// Возвращает или задает точку прибытия.
        /// </summary>
        public string DestinationPoint { get; set; }
        /// <summary>
        /// Время полета.
        /// </summary>
        private int duration;
        /// <summary>
        /// Возрващает или задает время полета. Только положительные значения.
        /// </summary>
        public int Duration
        {
            get { return duration; }
            set { if (Validator.AssertOnPositiveValue(value)) { duration = value; } }
        }
        /// <summary>
        /// Создает экземпляр класса.
        /// </summary>
        public Flights()
        {
            DeparturePoint = "None";
            DestinationPoint = "None";
            Duration = 0;
        }
        /// <summary>
        /// Создает экземпляр класса
        /// </summary>
        /// <param name="_depPoint">Точка отправления.</param>
        /// <param name="_desPoint">Точка прибытия.</param>
        /// <param name="_duration">Время. Только положительные значения.</param>
        public Flights(string _depPoint, string _desPoint, int _duration)
        {
            DestinationPoint = _desPoint;
            DeparturePoint = _depPoint;
            Duration = _duration;
        }
    }
}
