using Lab8.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class CityBuildingsControl : UserControl
    {
        public CityBuildingsControl()
        {
            InitializeComponent();
            if (File.Exists("data.txt"))
            {
                data.AddRange(File.ReadAllLines("data.txt"));

                for (int i = 0; i < data.Count / 4; i++)
                {
                    Building building = new Building();
                    building.Name = data[i * 4];
                    building.Type = (BuildingType)Enum.Parse(typeof(BuildingType), data[1 + i * 4]);
                    building.Address = data[i * 4 + 2];
                    building.Rate = Convert.ToDouble(data[i * 4 + 3]);
                    buildings.Add(building);
                }

                UpdateListBox();
            }
            else
            {
                using StreamWriter writer = new StreamWriter("data.txt");
            }
            typeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            typeComboBox.Items.AddRange(Enum.GetNames(typeof(BuildingType)));
            nameListBox.SelectedIndex = -1;
            typeComboBox.SelectedIndex = 0;

            
        }

        private List<string> data = new List<string>(5);
        private List<Building> buildings = new List<Building>(5);
        private Building _selectedBuilding;

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nameListBox.SelectedIndex != -1)
            {
                _selectedBuilding.Type = (BuildingType)Enum.Parse(typeof(BuildingType), typeComboBox.Text);
            }
            UpdateListBox();
            FileUpdate();
        }

        private void SortByCategoryAndName()
        {
            buildings = buildings.OrderBy(b => b.Type).ThenBy(b => b.Name).ToList();
        }

        private void UpdateListBox()
        {
            int temp = buildings.IndexOf(_selectedBuilding);
            SortByCategoryAndName();
            nameListBox.Items.Clear();
            foreach (var building in buildings)
            {
                nameListBox.Items.Add($"{building.Type} - {building.Name}");
            }
            nameListBox.SelectedIndex = temp;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Building building = new Building();
            buildings.Add(building);

            FileUpdate();
            UpdateListBox();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (nameListBox.SelectedIndex != -1)
            {
                int num = nameListBox.SelectedIndex;
                buildings.RemoveAt(num);
                nameListBox.Items.RemoveAt(num);
                nameListBox.SelectedIndex = -1;
                rateTextBox.Text = "";
                addressTextBox.Text = "";
                renameTextBox.Text = "";

                FileUpdate();
            }
        }

        private void FileUpdate()
        {
            File.Delete("data.txt");
            using (StreamWriter writer = new StreamWriter("data.txt"))
            {
                foreach (var building in buildings)
                {
                    writer.WriteLine(building.Name);
                    writer.WriteLine(Convert.ToString(building.Type));
                    writer.WriteLine(building.Address);
                    writer.WriteLine(Convert.ToString(building.Rate));
                }
            }
            
            
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            int num = nameListBox.SelectedIndex;
            if (num != -1)
            {
                try
                {
                    addressTextBox.BackColor = Color.White;
                    buildings[num].Address = addressTextBox.Text;
                }
                catch (Exception ex)
                {
                    addressTextBox.BackColor = Color.Red;
                }
            }
            FileUpdate();
        }

        private void rateTextBox_TextChanged(object sender, EventArgs e)
        {
            int num = nameListBox.SelectedIndex;
            if (num != -1)
            {
                try
                {
                    rateTextBox.BackColor = Color.White;
                    buildings[num].Rate = Convert.ToDouble(rateTextBox.Text);
                }
                catch
                {
                    rateTextBox.BackColor = Color.Red;
                }
                FileUpdate();
            }
        }

        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num = nameListBox.SelectedIndex;
            if (num != -1)
            {
                _selectedBuilding = buildings[num];
                addressTextBox.Text = _selectedBuilding.Address;
                rateTextBox.Text = _selectedBuilding.Rate.ToString();
                renameTextBox.Text = _selectedBuilding.Name;
                typeComboBox.SelectedItem = _selectedBuilding.Type.ToString();
            }
        }

        private void renameTextBox_TextChanged(object sender, EventArgs e)
        {
            int num = nameListBox.SelectedIndex;

            if (num != -1)
            {
                try
                {
                    renameTextBox.BackColor = Color.White;
                    buildings[num].Name = renameTextBox.Text;
                    nameListBox.Items[num] = $"{buildings[num].Type} - {buildings[num].Name}";
                }
                catch
                {
                    renameTextBox.BackColor = Color.Red;
                }
            }
            FileUpdate();
        }

        private void retypeLabel_Click(object sender, EventArgs e)
        {
            // пустой метод
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            UpdateListBox();
        }
    }
}
