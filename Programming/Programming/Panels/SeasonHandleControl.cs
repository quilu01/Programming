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
    public partial class SeasonHandleControl : UserControl
    {
        public SeasonHandleControl()
        {
            InitializeComponent();
            seasonComboBox.Items.AddRange(Enum.GetNames(typeof(Seasons)));
            seasonComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void seasonButton_Click(object sender, EventArgs e)
        {

            switch (seasonComboBox.SelectedItem)
            {
                case "Summer":
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case "Autumn":
                    this.BackColor = Color.Orange;
                    break;
                case "Winter":
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case "Spring":
                    this.BackColor = Color.Green;
                    break;
            }
        }
    }
}
