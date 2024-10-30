﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enumerations;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        public OrdersTab()
        {
            InitializeComponent();
            statusComboBox.Items.AddRange(Enum.GetNames(typeof(OrderStatus)));
        }
        public List<Customer> Customers { get; set; }
        private List<Order> _orders = new List<Order>(5);
        
        private Order _currentOrder;
       
        public void RefreshData()
        {
            double amount = 0;
            if (Customers != null)
            {
                dataGridView.Rows.Clear();
                foreach (var customer in Customers)
                {
                    for (int i = 0; i < customer.Orders.Count; i++)
                    {
                        var order = customer.Orders[i];
                        _orders.Add(order);
                        amount += order.Amount;
                        string address = $"{customer.Address.Index} {customer.Address.Country} {customer.Address.City} {customer.Address.Street} {customer.Address.Building} {customer.Address.Apartament}";
                        dataGridView.Rows.Add(order.Id, order.Date.ToString(), customer.Fullname, address, order.Amount, order.Status);
                    }
                }
                
            }
            amountLabel.Text = amount.ToString();
        }
        private void statusTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentOrder != null)
            {
                _currentOrder.Status = (OrderStatus)Enum.Parse(typeof(OrderStatus), (string)statusComboBox.SelectedItem);
                dataGridView.SelectedRows[0].Cells[5].Value = _currentOrder.Status;
            }
        }
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dataGridView.SelectedRows.Count != 0)
            {
                itemsListBox.Items.Clear();
                _currentOrder = _orders[dataGridView.SelectedRows[0].Index];
                addressControl1.Address = _currentOrder.Address;
                idTextBox.Text = _currentOrder.Id.ToString();
                createdTextBox.Text = _currentOrder.Date.ToString();
                statusComboBox.SelectedIndex = (int)_currentOrder.Status;
                for (int i = 0; i < _currentOrder.Cart.Items.Count; i++)
                {
                    
                    itemsListBox.Items.Add(_currentOrder.Cart.Items[i].Name);
                }
            }
        }
    }
}