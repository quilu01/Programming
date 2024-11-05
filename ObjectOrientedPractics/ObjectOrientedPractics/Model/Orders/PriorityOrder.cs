﻿using ObjectOrientedPractics.Model.Enumerations;
using ObjectOrientedPractics.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Orders
{
    public class PriorityOrder : Order
    {
        private int _desiredTime;
        private DateTime _desiredDate;
        public int DesiredTime;
        public DateTime DesiredDate;
        public PriorityOrder(Customer customer, double total) : base(customer, total)
        {
            DesiredTime = 0;
            DesiredDate = DateTime.Today.Date;
            MessageBox.Show(Id.ToString());
        }
    }
}