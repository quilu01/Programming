using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Orders;
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
                UpdateDiscountsCheckedListBox();
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
                    Order order = new Order(_currentCustomer, CreateOrder());
                    _currentCustomer.Orders.Add(order);
                    
                }
                else
                {
                    PriorityOrder order = new PriorityOrder(_currentCustomer, CreateOrder());
                    _currentCustomer.Orders.Add(order);
                }
                _currentCustomer.Cart = new Cart();

                cartListBox.Items.Clear();
            }
            AmountRefresh();
            UpdateDiscountAndTotalAmount();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            _currentCustomer?.Cart.Items.Clear();
            cartListBox.Items.Clear();
            AmountRefresh();

        }

        private void discountsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDiscountAndTotalAmount();
        }
        /// <summary>
        /// Обновляет список доступных скидок в CheckedListBox.
        /// Устанавливает флажки для всех скидок.
        /// </summary>
        private void UpdateDiscountsCheckedListBox()
        {
            discountsCheckedListBox.Items.Clear();
            if (_currentCustomer == null) return;
            for (int i = 0; i < _currentCustomer.Discounts.Count; i++)
            {
                discountsCheckedListBox.Items.Add(_currentCustomer.Discounts[i].Info);
            }
            CheckAllItems();
            UpdateDiscountAndTotalAmount();
        }
        /// <summary>
        /// Устанавливает флажки для всех элементов в списке скидок.
        /// </summary>
        private void CheckAllItems()
        {
            for (int i = 0; i < discountsCheckedListBox.Items.Count; i++)
            {
                discountsCheckedListBox.SetItemChecked(i, true);
            }
        }
        /// <summary>
        /// Обновляет сумму скидки и итоговую сумму заказа.
        /// </summary>
        private void UpdateDiscountAndTotalAmount()
        {
            int discountAmount = 0;
            discountAmountLabel.Text = "0";
            totalLabel.Text = "0";
            if (_currentCustomer == null) return;
            foreach (int index in discountsCheckedListBox.CheckedIndices)
            {
                discountAmount += (int)_currentCustomer.Discounts[index].Calculate(_currentCustomer.Cart.Items);
            }
            discountAmountLabel.Text = discountAmount.ToString();
            totalLabel.Text = (_currentCustomer.Cart.Amount - discountAmount).ToString();
        }
        public int CreateOrder()
        {
            int discountAmount = 0;
            discountAmountLabel.Text = "0";
            totalLabel.Text = "0";
            if (_currentCustomer == null) return 0;
            foreach (int index in discountsCheckedListBox.CheckedIndices)
            {
                discountAmount += (int)_currentCustomer.Discounts[index].Apply(_currentCustomer.Cart.Items);
            }

            foreach (IDiscount discount in _currentCustomer.Discounts)
            {
                discount.Update(_currentCustomer.Cart.Items);
            }
            UpdateDiscountsCheckedListBox();
            return discountAmount;
        }
    }
}
