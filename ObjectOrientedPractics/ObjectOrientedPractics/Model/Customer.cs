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
        public List<Order> Orders { get; set; }
        
        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"./>
        /// </summary>
        /// <param name="fullname">ФИО клиента.</param>
        /// <param name="address">Адрес клиента.</param>
        public Customer(string fullname, Address address)
        {
            _id = IdGenerator.CustomerId;
            Cart = new Cart();
            Orders = new List<Order>(5);
            Fullname = fullname;
            Address = address;
        }
        public Customer()
        {
            _id = IdGenerator.CustomerId;
            Fullname = "Иван Иванович Иванов";
            Address Address = new Address();
            Cart = new Cart();
            Orders = new List<Order>(5);
        }
    }

}
