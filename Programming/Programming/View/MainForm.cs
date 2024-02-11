
namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
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
            seasonComboBox.Items.AddRange(Enum.GetNames(typeof(Seasons)));
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void parsingGroupBox_Enter(object sender, EventArgs e)
        {

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