using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Lab8.Model
{
    /// <summary>
    /// Хранит информацию о строении.
    /// </summary>
    public class Building
    {
        /// <summary>
        /// Тип строения
        /// </summary>
        public BuildingType Type { get; set; }

        /// <summary>
        /// Название строения
        /// </summary>
        private string _name;
        
        public string Name
        {
            get { return _name; }
            set { if (Validator.StringLenght(value, 200)) { _name = value; } }
        }
        /// <summary>
        /// Адрес строения
        /// </summary>
        private string _address;
        
        public string Address
        {
            get { return _address; }
            set { if (Validator.StringLenght(value, 100)) { _address = value;} }
        }
        /// <summary>
        /// Рейтинг строения
        /// </summary>
        private double _rate;
        
        public double Rate
        {
            get { return _rate; }
            set { if (Validator.AssertValueInRange(value, 0, 5)) { _rate = value; } }
        }
        public Building()
        {
            Name = "------------------";
            Address = "None";
            Rate = 0;
            Type = BuildingType.Municipal;
            
        }
        public Building(string name, BuildingType type,  string address, double rate)
        {
            Name = name;
            Type = type;
            Address = address;
            Rate = rate;
        }
        
    }
}
