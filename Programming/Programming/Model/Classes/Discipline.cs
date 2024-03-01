using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Discipline
    {
        private string Name { get; set; }
        private string TeacherName { get; set; }
        private int finalGrade;
        public int FinalGrade
        {
            get { return finalGrade; }
            set { if (Validator.AssertValueInRange(value, 1, 6)) { finalGrade = value; } }
        }
        public Discipline()
        {
            Name = "None";
            TeacherName = "None";
            FinalGrade = 1;
        }
        public Discipline(string _name, string _teacherName, int _finalGrade)
        {
            Name = _name;
            TeacherName = _teacherName;
            FinalGrade = _finalGrade;
        }
    }
}
