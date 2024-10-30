using ObjectOrientedPractics.Model.Enumerations;
using ObjectOrientedPractics.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ObjectOrientedPractics.Model
{
    public class Order
    {
        private readonly int _id;
        
        private readonly DateTime _date;
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        
        public Address Address { get; set; }
        public Cart Cart { get; set; }
        public double Amount { get; set; }

        public Order (Customer customer)
        {
            Id = IdGenerator.OrderId;
            Date = DateTime.Now;
            Address = customer.Address;
            Cart = customer.Cart;
            Amount = Cart.Amount;
            Status = OrderStatus.New;
        }

    }
}
