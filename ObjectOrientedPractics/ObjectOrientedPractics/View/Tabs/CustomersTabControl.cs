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

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTabControl : UserControl
    {
        public CustomersTabControl()
        {
            InitializeComponent();
        }
        List<Customer> _customers = new();
        public Customer _currentCustomer;
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
            _currentCustomer = _customers[customersListBox.SelectedIndex];
            fullnameTextBox.Text = _currentCustomer.Fullname;
            idTextBox.Text = _currentCustomer._id.ToString();
            addressTextBox.Text = _currentCustomer.Address;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            _customers.Add(customer);
            customersListBox.Items.Add(customer.Fullname);
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

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentCustomer.Address = addressTextBox.Text;
                addressTextBox.BackColor = Color.White;
            }
            catch
            {
                addressTextBox.BackColor = Color.LightPink;
            }
        }
    }
}
