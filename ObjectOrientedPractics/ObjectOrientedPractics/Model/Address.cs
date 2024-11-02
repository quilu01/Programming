using ObjectOrientedPractics.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Address : ICloneable, IEquatable<Address>
    {
        private int _index;
        private string _country;
        private string _city;
        private string _street;
        private string _building;
        private string _apartament;

        public int Index
        {
            get { return _index; }

            set { if (ValueValidator.AssertStringOnLength(value.ToString(), 7, "Index") && value > 99999) { _index = value; } }
        }
        public string Country
        {
            get { return _country; }
            set { if (ValueValidator.AssertStringOnLength(value, 50, "Country")) { _country = value; } }
        }
        public string City
        {
            get { return _city; }
            set { if (ValueValidator.AssertStringOnLength(value, 50, "City")) { _city = value; } }
        }
        public string Street
        {
            get { return _street; }
            set { if (ValueValidator.AssertStringOnLength(value, 50, "Street")) { _street = value; } }
        }
        public string Building
        {
            get { return _building; }
            set { if (ValueValidator.AssertStringOnLength(value, 50, "Building")) { _building = value; } }
        }
        public string Apartament
        {
            get { return _apartament; }
            set { if (ValueValidator.AssertStringOnLength(value, 50, "Apartament")) { _apartament = value; } }
        }
        public Address()
        {
            Index = 123456;
            Country = "Россия";
            City = "Томск";
            Street = "Лыткина";
            Building = "18";
            Apartament = "404";
        }
        public Address(int index, string country, string city, string street, string building, string apartament)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartament = apartament;
        }
        public object Clone()
        {
            return new Address(Index, Country, City, Street, Building, Apartament);
        }

        /// <inheritdoc/>
        public bool Equals(Address? address2)
        {
            if (address2 == null)
                return false;
            if (object.ReferenceEquals(this, address2))
                return true;

            PropertyInfo[] properties = typeof(Address).GetProperties();

            foreach (PropertyInfo property in properties)
            {
                var value1 = property.GetValue(this);
                var value2 = property.GetValue(address2);

                if (value1 == null && value2 == null)
                    continue;
                if (value1 == null || value2 == null || value1 != value2)
                    return false; // Если одно из значений null или они не равны
            }

            return true;
        }
    }
}

