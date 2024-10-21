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
    public partial class ItemsTab : UserControl
    {
        public ItemsTab()
        {
            InitializeComponent();
        }
        List<Item> _items = new();
        public Item _currentItem;
        private void selectedItemGroupBox_Enter(object sender, EventArgs e)
        {

        }
        private void Refresh()
        {
            itemsListBox.Items.Clear();
            for (int i = 0; i < _items.Count; i++)
            {
                itemsListBox.Items.Add(_items[i].Name);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                Item item = new Item();
                _items.Add(item);
                itemsListBox.Items.Add(item.Name);
            }
            catch (Exception ex)
            {

            }
        }

        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex != -1)
            { 
                _currentItem = _items[itemsListBox.SelectedIndex];
                nameTextBox.Text = _currentItem.Name;
                idTextBox.Text = _currentItem._id.ToString();
                descriptionTextBox.Text = _currentItem.Info;
                costTextBox.Text = _currentItem.Cost.ToString();
            }
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            
            _items.Remove(_currentItem);
            itemsListBox.Items.RemoveAt(itemsListBox.SelectedIndex);
            itemsListBox.SelectedIndex = -1;
            Refresh();

        }

        private void costTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Cost = Convert.ToDouble(costTextBox.Text);
                costTextBox.BackColor = Color.White;
            }
            catch
            {
                costTextBox.BackColor = Color.LightPink;
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Name = nameTextBox.Text;
                Refresh();
                nameTextBox.BackColor = Color.White;
            }
            catch
            {
                nameTextBox.BackColor= Color.LightPink;
            }
            
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Info = descriptionTextBox.Text;
                descriptionTextBox.BackColor = Color.White;
            }
            catch
            {
                descriptionTextBox.BackColor = Color.LightPink;
            }
        }
    }
}
