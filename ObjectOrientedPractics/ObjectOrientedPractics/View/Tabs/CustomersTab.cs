using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.View.Controls;
using ObjectOrientedPractics.Model.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        public CustomersTab()
        {
            InitializeComponent();
        }
        private List<Customer> _customers;
        private Customer _currentCustomer;
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                if (value != null)
                {
                    _customers = value;
                    Refresh();
                }
            }
        }
        private List<IDiscount> _discounts;
        public List<IDiscount> Discounts
        {
            get
            {
                return _discounts;
            }
            set
            {
                _discounts = value;
                UpdateDiscounts();
            }
        }
        private void Refresh()
        {
            customersListBox.Items.Clear();
            for (int i = 0; i < _customers.Count; i++)
            {
                customersListBox.Items.Add(_customers[i].Fullname);
            }
        }

        private void customersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customersListBox.SelectedIndex != -1)
            {

                _currentCustomer = _customers[customersListBox.SelectedIndex];
                addressControl.Address = _currentCustomer.Address;
                priorityCheckBox.Checked = _currentCustomer.IsPriority;
                fullnameTextBox.Text = _currentCustomer.Fullname;
                idTextBox.Text = _currentCustomer._id.ToString();
                Discounts = _currentCustomer.Discounts;
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Address = new Address();
            _customers.Add(customer);
            customersListBox.Items.Add(customer.Fullname);
            _currentCustomer = customer;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                _customers.Remove(_currentCustomer);
                customersListBox.Items.RemoveAt(customersListBox.SelectedIndex);
                customersListBox.SelectedIndex = -1;
                Refresh();
            }
            catch
            {

            }
        }

        private void fullnameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentCustomer.Fullname = fullnameTextBox.Text;
                fullnameTextBox.BackColor = Color.White;
                Refresh();
            }
            catch
            {
                fullnameTextBox.BackColor = Color.LightPink;
            }
        }

        private void addressControl_Load(object sender, EventArgs e)
        {

        }

        private void priorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (_currentCustomer != null)
            {
                if (priorityCheckBox.Checked)
                {
                    _currentCustomer.IsPriority = true;
                }
                else
                {
                    _currentCustomer.IsPriority = false;
                }
            }
        }

        private void discountsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addDiscountButton_Click(object sender, EventArgs e)
        {
            if (Discounts == null) return;
            using (DiscountsForm discountForm = new DiscountsForm())
            {
                if (discountForm.ShowDialog() == DialogResult.OK)
                {
                    Discounts.Add(discountForm.PercentDiscount);
                    discountsListBox.Items.Add(discountForm.PercentDiscount.Info);
                }
            }
        }

        private void removeDiscountButton_Click(object sender, EventArgs e)
        {
            if (Discounts == null || discountsListBox.SelectedItem == null) return;
            if (discountsListBox.SelectedIndex == 0)
            {
                MessageBox.Show("Нельзя удалить накопительную скидку!");
                return;
            }
            Discounts.RemoveAt(discountsListBox.SelectedIndex);
            discountsListBox.Items.Remove(discountsListBox.SelectedItem);
        }
        private void UpdateDiscounts()
        {
            discountsListBox.Items.Clear();
            if (Discounts == null) return;
            for (int i = 0; i < Discounts.Count; i++)
            {
                discountsListBox.Items.Add(Discounts[i].Info);
            }
        }
    }
}
