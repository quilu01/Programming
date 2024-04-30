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
    public partial class WeekdayControl : UserControl
    {
        public WeekdayControl()
        {
            InitializeComponent();
        }
        private void parsingButton_Click(object sender, EventArgs e)
        {

            if (Enum.IsDefined(typeof(Weekday), parsingTextBox.Text))
            {
                Weekday weekday = (Weekday)Enum.Parse(typeof(Weekday), parsingTextBox.Text);
                parsedLabel.Text = $"Это день недели ({parsingTextBox.Text} = {(int)weekday + 1})";
            }
            else
            {
                parsedLabel.Text = "Нет такого дня недели";
            }
        }
    }
}
