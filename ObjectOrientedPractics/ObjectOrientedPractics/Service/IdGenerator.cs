using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Service
{
    public class IdGenerator
    {
        private static int _itemId = 0;
        private static int _customerId = 0;
        private static int _orderId = 0;
        public static int ItemId
        {
            get { return _itemId++; }
        }
        public static int CustomerId { get { return _customerId++; } }
        public static int OrderId { get { return _orderId++; } }
    }
}
