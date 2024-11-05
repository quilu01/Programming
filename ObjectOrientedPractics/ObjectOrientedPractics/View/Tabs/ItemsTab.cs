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
using ObjectOrientedPractics.Model.Enumerations;
using ObjectOrientedPractics.Service;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        public ItemsTab()
        {
            InitializeComponent();
            categoryComboBox.Items.AddRange(Enum.GetNames(typeof(Category)));
            sortComboBox.Items.AddRange(["Name", "Cost (Ascending)", "Cost (Descending)"]);
            sortComboBox.SelectedIndex = 0;
        }
        private List<Item> _items;

        private bool _isRefreshed = false;
        private List<Item> sortedItems;
        public List<Item> Items
        {
            get { return _items; }
            set
            {
                if (value != null)
                {

                    _items = value;
                    Refresh();
                }
            }
        }
        private Item _currentItem;
        private void selectedItemGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void Refresh()
        {
            if (Items == null) return;
            if (_isRefreshed)
            {
                _isRefreshed = false;
                return;
            }
            var filteredItems = DataTools.Filter(Items, (item) => item.Name.Contains(findTextBox.Text, StringComparison.OrdinalIgnoreCase));


            switch (sortComboBox.SelectedIndex)
            {
                case 1:
                    sortedItems = DataTools.Sort(filteredItems, (item1, item2) => item1.Cost > item2.Cost);
                    break;
                case 2:
                    sortedItems = DataTools.Sort(filteredItems, (item1, item2) => item1.Cost < item2.Cost);
                    break;
                default:
                    sortedItems = DataTools.Sort(filteredItems, (item1, item2) => string.Compare(item1.Name, item2.Name, StringComparison.OrdinalIgnoreCase) > 0);
                    break;
            }
            itemsListBox.Items.Clear();

            for (int i = 0; i < sortedItems.Count; i++)
            {
                itemsListBox.Items.Add(sortedItems[i].Name);
            }
            _isRefreshed = true;

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                Item item = new Item();
                _items.Add(item);
                _isRefreshed = false;
                Refresh();
            }
            catch (Exception ex)
            {

            }
        }

        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex != -1)
            {

                _currentItem = _items[_items.IndexOf(sortedItems[itemsListBox.SelectedIndex])];
                nameTextBox.Text = _currentItem.Name;
                idTextBox.Text = _currentItem._id.ToString();
                descriptionTextBox.Text = _currentItem.Info;
                costTextBox.Text = _currentItem.Cost.ToString();
                categoryComboBox.SelectedIndex = (int)_currentItem.Category;
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex != -1)
            {
                _items.Remove(_currentItem);
                itemsListBox.Items.RemoveAt(itemsListBox.SelectedIndex);
                itemsListBox.SelectedIndex = -1;
                _isRefreshed = false;
                Refresh();
            }

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
                _isRefreshed = false;
                Refresh();
                nameTextBox.BackColor = Color.White;
            }
            catch
            {
                nameTextBox.BackColor = Color.LightPink;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Category = (Category)Enum.Parse(typeof(Category), (string)categoryComboBox.SelectedItem);

            }
            catch
            {

            }
        }

        private void findTextBox_TextChanged(object sender, EventArgs e)
        {
            _isRefreshed = false;
            Refresh();
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isRefreshed = false;
            Refresh();
        }
    }
}
