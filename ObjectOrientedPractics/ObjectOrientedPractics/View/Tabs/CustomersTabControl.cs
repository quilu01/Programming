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
using ObjectOrientedPractics.View.Controls;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTabControl : UserControl
    {
        public CustomersTabControl()
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
                _customers = value;
                Refresh();
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
                
                fullnameTextBox.Text = _currentCustomer.Fullname;
                idTextBox.Text = _currentCustomer._id.ToString();
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
    }
}
