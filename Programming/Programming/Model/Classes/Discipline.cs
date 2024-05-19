using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные об оценках.
    /// </summary>
    public class Discipline
    {
        /// <summary>
        /// Возвращает или задает имя.
        /// </summary>
        private string Name { get; set; }
        /// <summary>
        /// Возвращает или задает имя учителя.
        /// </summary>
        private string TeacherName { get; set; }
        /// <summary>
        /// Оценка.
        /// </summary>
        private int finalGrade;
        /// <summary>
        /// Возвращает или задает оценку.
        /// </summary>
        public int FinalGrade
        {
            get { return finalGrade; }
            set { if (Validator.AssertValueInRange(value, 1, 6)) { finalGrade = value; } }
        }
        /// <summary>
        /// Создает экземпляр класса.
        /// </summary>
        public Discipline()
        {
            Name = "None";
            TeacherName = "None";
            FinalGrade = 1;
        }
        /// <summary>
        /// Создает экземпляр класса
        /// </summary>
        /// <param name="_name">Имя</param>
        /// <param name="_teacherName">Имя учителя.</param>
        /// <param name="_finalGrade">Оценка.</param>
        public Discipline(string _name, string _teacherName, int _finalGrade)
        {
            Name = _name;
            TeacherName = _teacherName;
            FinalGrade = _finalGrade;
        }
    }
}
