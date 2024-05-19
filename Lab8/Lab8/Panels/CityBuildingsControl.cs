using Lab8.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            typeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            
            typeComboBox.Items.AddRange(Enum.GetNames(typeof(BuildingType)));
            nameListBox.SelectedIndex = -1;
            typeComboBox.SelectedIndex = 0;
            
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
                    UpdateListBox(); 
                    nameListBox.Items.Add($"{building.Type} - {building.Name}");
                }
            }
            else
            {
                using StreamWriter writer = new StreamWriter("data.txt");
            }
        }
        /// <summary>
        /// Список со строками в файле.
        /// </summary>
        private List<string> data = new List<string>(5);
        /// <summary>
        /// Список строений.
        /// </summary>
        private List<Building> buildings = new List<Building>(5);
        /// <summary>
        /// Выбранное строение.
        /// </summary>
        private Building _selectedBuilding;
        /// <summary>
        /// Метод, срабатывающий при изменении типа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nameListBox.SelectedIndex != -1)
            {
                _selectedBuilding.Type = (BuildingType)Enum.Parse(typeof(BuildingType), typeComboBox.Text);

            }
            UpdateListBox();
            FileUpdate();
            
        }
        /// <summary>
        /// Метод для сортировки списка <see cref="Building"/>.
        /// </summary>
        private void SortByCategoryAndName()
        {
            buildings = buildings.OrderBy(b => b.Type).ThenBy(b => b.Name).ToList();
        }
        /// <summary>
        /// Метод для обновления <see cref="nameListBox"/>
        /// </summary>
        private void UpdateListBox()
        {
            int temp = nameListBox.SelectedIndex;
            SortByCategoryAndName(); 
            nameListBox.Items.Clear();
            foreach (var building in buildings)
            {
                nameListBox.Items.Add($"{building.Type} - {building.Name}");
            }
            nameListBox.SelectedIndex = temp;
        }
        /// <summary>
        /// Метод, срабатывающий при нажатии кнопки <see cref="addButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            Building building = new Building();
            buildings.Add(building);
            
            FileUpdate();
            UpdateListBox();
        }
        /// <summary>
        /// Метод, срабатывающий при нажатии кнопки <see cref="deleteButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            
            int num = nameListBox.SelectedIndex;
            buildings.RemoveAt(num);
            nameListBox.Items.RemoveAt(num);
            nameListBox.SelectedIndex = -1;
            rateTextBox.Text = "";
            addressTextBox.Text = "";
            renameTextBox.Text = "";
            UpdateListBox();
            FileUpdate();
        }
        /// <summary>
        /// Метод, срабатывающий при обновлении данных.
        /// </summary>
        private void FileUpdate()
        {
            File.Delete("data.txt");
            using (StreamWriter writer = new StreamWriter("data.txt"))
            {
                for (int i = 0; i < buildings.Count; i++)
                {
                    writer.WriteLine(buildings[i].Name);
                    writer.WriteLine(Convert.ToString(buildings[i].Type));
                    writer.WriteLine(buildings[i].Address);
                    writer.WriteLine(Convert.ToString(buildings[i].Rate));
                }
            }
        }
        /// <summary>
        /// Метод, срабатывающий при изменении <see cref="addressTextBox"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            int num = nameListBox.SelectedIndex;
            try
            {
                addressTextBox.BackColor = Color.White;
                buildings[num].Address = addressTextBox.Text;
            }
            catch (Exception ex)
            {
                addressTextBox.BackColor = Color.Red;
            }
            FileUpdate();
        }
        /// <summary>
        /// Метод, срабатывающий при изменении <see cref="rateTextBox"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rateTextBox_TextChanged(object sender, EventArgs e)
        {
            int num = nameListBox.SelectedIndex;
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
        /// <summary>
        /// Метод, срабатывающий при изменении <see cref="nameListBox"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Метод, срабатывающий при изменении <see cref="renameTextBox"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void renameTextBox_TextChanged(object sender, EventArgs e)
        {
            int num = nameListBox.SelectedIndex;
            try
            {
                if (num != -1)
                {
                    renameTextBox.BackColor = Color.White;
                    buildings[num].Name = renameTextBox.Text;
                    nameListBox.Items[num] = $"{buildings[num].Type} - {buildings[num].Name}"; 
                }
            }
            catch
            {
                renameTextBox.BackColor = Color.Red;
            }
            FileUpdate();
            UpdateListBox();
        }

        private void retypeLabel_Click(object sender, EventArgs e)
        {

        }

        
    }
}
