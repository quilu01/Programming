using ObjectOrientedPractics.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Описание клиентов.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Id клиента.
        /// </summary>
        public readonly int _id;
        /// <summary>
        /// ФИО клиента.
        /// </summary>
        private string _fullname;
        
        private static int _idCount = -1;
        /// <summary>
        /// Возвраащает и задает ФИО клиента.
        /// </summary>

        public string Fullname
        {
            get { return _fullname; }
            set { if (ValueValidator.AssertStringOnLength(value, 200, Fullname)) _fullname = value; }
        }
        /// <summary>
        /// Возвращает и задает адрес клиента.
        /// </summary>
        public Address Address { get; set; }
        public Cart Cart { get; set; }
        public int IdCount
        {
            get { _idCount++; return _idCount;  }
        }
        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"./>
        /// </summary>
        /// <param name="fullname">ФИО клиента.</param>
        /// <param name="address">Адрес клиента.</param>
        public Customer(string fullname, Address address)
        {
            _id = IdCount;
            Cart = new Cart();
            Fullname = fullname;
            Address = address;
        }
        public Customer()
        {
            _id = IdCount;
            Fullname = "Иван Иванович Иванов";
            Address Address = new Address();
            Cart = new Cart();
        }
    }

}
