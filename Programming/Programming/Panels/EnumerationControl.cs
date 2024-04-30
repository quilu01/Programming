using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.Panels
{
    public partial class EnumerationControl : UserControl
    {
        public EnumerationControl()
        {
            InitializeComponent();
            string path = @"C:\Users\nikita\source\repos\Programming\Programming\Programming\Model\Enums\";
            string[] enumNames = Directory.GetFiles(path);
            for (int i = 0; i < enumNames.Length; i++)
            {
                enumNames[i] = Path.GetFileName(enumNames[i]);
                enumNames[i] = enumNames[i].Substring(0, enumNames[i].Length - 3);
            }
            enumerationListBox.Items.AddRange(enumNames);
            enumerationListBox.SelectedIndex = 0;
        }
        private void enumerationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (enumerationListBox.SelectedItem)
            {
                case "Color":
                    valuesListBox.Items.Clear();
                    valuesListBox.Items.AddRange(Enum.GetNames(typeof(colorValue)));
                    break;
                case "EducationForm":
                    valuesListBox.Items.Clear();
                    valuesListBox.Items.AddRange(Enum.GetNames(typeof(EducationForm)));
                    break;
                case "Genre":
                    valuesListBox.Items.Clear();
                    valuesListBox.Items.AddRange(Enum.GetNames(typeof(Genre)));
                    break;
                case "Manufactures":
                    valuesListBox.Items.Clear();
                    valuesListBox.Items.AddRange(Enum.GetNames(typeof(Manufactures)));
                    break;
                case "Seasons":
                    valuesListBox.Items.Clear();
                    valuesListBox.Items.AddRange(Enum.GetNames(typeof(Seasons)));
                    break;
                case "Weekday":
                    valuesListBox.Items.Clear();
                    valuesListBox.Items.AddRange(Enum.GetNames(typeof(Weekday)));
                    break;
            }
        }

        private void valuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueTextBox.Text = Convert.ToString(valuesListBox.SelectedIndex);
        }
    }
}
