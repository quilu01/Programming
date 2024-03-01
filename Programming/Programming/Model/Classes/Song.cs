using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Song
    {
        private string Name { get; set; }
        private string Album { get; set; }
        private int duration;
        public int Duration
        {
            get { return duration; }
            set { if (Validator.AssertOnPositiveValue(value)) { duration = value; } }
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
}
