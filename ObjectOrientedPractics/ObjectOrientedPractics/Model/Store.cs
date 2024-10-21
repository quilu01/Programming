using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Store
    {
        private List<Item> _items;
        private List<Customer> _customers;

        public List<Item> Items { get; set; }
        public List<Customer> Customers { get; set; }

        public Store()
        {
            Items = new List<Item>();
            Customers = new List<Customer>();
        }
    }
}
