using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        public AddressControl()
        {
            InitializeComponent();
        }
        private static Address _address;
        public Address Address
        {
            get { return _address; }
            set
            {
                if (value != null) 
                {
                    _address = value;
                    postIndexTextBox.Text = _address.Index.ToString();
                    countryTextBox.Text = _address.Country;
                    cityTextBox.Text = _address.City;
                    streetTextBox.Text = _address.Street;
                    buildingTextBox.Text = _address.Building;
                    apartamentTextBox.Text = _address.Apartament;
                    
                }
                
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void countryLabel_Click(object sender, EventArgs e)
        {

        }

        private void postIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Index = Convert.ToInt32(postIndexTextBox.Text);
                postIndexTextBox.BackColor = Color.White;
            }
            catch
            {
                postIndexTextBox.BackColor = Color.Red;
            }
        }

        private void countryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Country = countryTextBox.Text;
                countryTextBox.BackColor = Color.White;
            }
            catch
            {
                countryTextBox.BackColor = Color.Red;
            }
        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.City = cityTextBox.Text;
                cityTextBox.BackColor = Color.White;
            }
            catch
            {
                cityTextBox.BackColor = Color.Red;
            }
        }

        private void streetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Street = streetTextBox.Text;
                streetTextBox.BackColor = Color.White;
            }
            catch
            {
                countryTextBox.BackColor = Color.Red;
            }
        }

        private void buildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Building = buildingTextBox.Text;
                buildingTextBox.BackColor = Color.White;
            }
            catch
            {
                buildingTextBox.BackColor = Color.Red;
            }
        }

        private void apartamentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Apartament = apartamentTextBox.Text;
                apartamentTextBox.BackColor = Color.White;
            }
            catch
            {
                apartamentTextBox.BackColor = Color.Red;
            }
        }
    }
}
