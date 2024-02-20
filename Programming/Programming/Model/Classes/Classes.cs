using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Rectangles
    {
        private double widht;
        private double lenght;
        public string Color { get; set; }

        public double Widht
        {
            get { return widht; }
            set { if (value > 0) { widht = value; } }
        }

        public double Lenght
        {
            get { return lenght; }
            set { if (value > 0) { lenght = value; } }
        }
        public Rectangles()
        {
            Widht = 10;
            Lenght = 10;
            Color = "None";
        }
        public Rectangles(double _widht, double _lenght, string _color)
        {
            Widht = _widht;
            Lenght = _lenght;
            Color = _color;
        }
    }

    public class Flights
    {
        public string DeparturePoint { get; set; }
        public string DestinationPoint { get; set; }
        private int duration;
        public int Duration
        {
            get { return duration; }
            set { if (value >= 0 && value < 61) { duration = value; } }
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
    
    public class Movie
    {
        public string Name { get; set; }
        private int duration;
        public int Duration
        {
            get { return duration; }
            set { if (value >= 0) { duration = value; } }
        }
        private int releaseDate;
        public int ReleaseDate
        {
            get { return releaseDate; }
            set { if (value > 1989 && value < 2025) { releaseDate = value; } }
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

    public class Contact
    {
        private string Name { get; set; }
        private string Surname { get; set; }
        private int Number { get; set; }
        public Contact()
        {
            Name = "None";
            Surname = "None";
            Number = 0;
        }
        public Contact(string _name, string _surname, int _number)
        {
            Name = _name;
            Surname = _surname;
            Number = _number;
        }
    }

    public class Song
    {
        private string Name { get; set; }
        private string Album { get; set; }
        private int duration;
        public int Duration
        {
            get { return duration; }
            set { if (value > 0) { duration = value; } }
        }
        public Song()
        {
            Name = "None";
            Album = "None";
            Duration = 0;
        }
        public Song(string _name, string _album, int _duration)
        {
            Name = _name;
            Album = _album;
            Duration = _duration;           
        }
    }

    public class Discipline
    {
        private string Name { get; set; }
        private string TeacherName { get; set; }
        private int finalGrade;
        public int FinalGrade
        {
            get { return finalGrade; }
            set { if (value > 0 && value < 6) { finalGrade = value; } }
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
