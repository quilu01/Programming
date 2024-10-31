using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        public CartsTab()
        {
            InitializeComponent();
        }
        private List<Customer> _customers;
        private List<Item> _items;
        private Item _currentItem;
        private Item _currentCartItem;
        private Customer _currentCustomer;
        public List<Customer> Customers { get; set; }
        
        public List<Item> Items { get; set; }
        
        public void RefreshData()
        {
            itemsListBox.Items.Clear();
            customerComboBox.Items.Clear();
            if (Customers != null)
            {
                for (int i = 0; i < Customers.Count; i++)
                {
                    customerComboBox.Items.Add(Customers[i].Fullname);
                }
            }
            if (Items != null)
            {
                for (int i = 0; i < Items.Count; i++)
                {
                    itemsListBox.Items.Add(Items[i].Name);
                }
            }
        }
        private void AmountRefresh()
        {
            amountLabel.Text = _currentCustomer.Cart.Amount.ToString();
        }

        private void customerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customerComboBox.SelectedIndex != -1)
            {
                _currentCustomer = Customers[customerComboBox.SelectedIndex];
                cartListBox.Items.Clear();
                if (_currentCustomer.Cart.Items != null)
                {
                    for (int i = 0; i < _currentCustomer.Cart.Items.Count; i++)
                    {
                        cartListBox.Items.Add(_currentCustomer.Cart.Items[i].Name);
                    }
                }
            }
            else
            {
                cartListBox.Items.Clear();
            }
        }

        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex != -1)
            {
                _currentItem = Items[itemsListBox.SelectedIndex];
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (_currentItem != null && _currentCustomer != null)
            {
                _currentCustomer.Cart.Items.Add(_currentItem);
                cartListBox.Items.Add(_currentItem.Name);
                AmountRefresh();
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (_currentCartItem != null)
            {
                _currentCustomer.Cart.Items.Remove(_currentCartItem);
                cartListBox.Items.Remove(cartListBox.SelectedItem);
                AmountRefresh();
            }
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer != null && _currentCustomer.Cart.Items.Count > 0)
            {
                if (_currentCustomer.IsPriority == false)
                {
                    Order order = new Order(_currentCustomer);
                    _currentCustomer.Orders.Add(order);
                    MessageBox.Show("not priority");
                }
                else
                {
                    PriorityOrder order = new PriorityOrder(_currentCustomer);
                    _currentCustomer.Orders.Add(order);
                }
                _currentCustomer.Cart = new Cart();

                cartListBox.Items.Clear();
            }
            AmountRefresh();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            _currentCustomer?.Cart.Items.Clear();
            cartListBox.Items.Clear();
            AmountRefresh();

        }
    }
}
