
using Programming.Model.Classes;
using System.Drawing.Text;

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
            seasonComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            for (int i = 0; i < 5; i++)
            {
                _rectangles[i] = new Rectangles(rnd.NextDouble() * 100, rnd.NextDouble() * 100, "", rnd.Next(0, 100), rnd.Next(0, 100));
                rectanglesListBox.Items.Add($"Rectangle {i + 1}");

                _movies[i] = new Movie();
                _movies[i].Rate = rnd.NextDouble() * 10;
                movieListBox.Items.Add($"Movie {i + 1}");
            }

        }
        private Rectangles[] _rectangles = new Rectangles[5];
        private Rectangles _currentRectangle;
        Random rnd = new Random();
        private Movie[] _movies = new Movie[5];
        private Movie _currentMovie;

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

        private void rectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[rectanglesListBox.SelectedIndex];
            lenghtTextBox.Text = _currentRectangle.Lenght.ToString();
            widhtTextBox.Text = _currentRectangle.Widht.ToString();
            colorTextBox.Text = _currentRectangle.Color;
            centerXTextBox.Text = _currentRectangle.Center.X.ToString();
            centerYTextBox.Text = _currentRectangle.Center.Y.ToString();
            idTextBox.Text = _currentRectangle.Id.ToString();
        }

        private void lenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Lenght = Convert.ToDouble(lenghtTextBox.Text);
                lenghtTextBox.BackColor = Color.White;
            }
            catch
            {
                lenghtTextBox.BackColor = Color.LightPink;
            }
        }

        private void widhtTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Widht = Convert.ToDouble(widhtTextBox.Text);
                widhtTextBox.BackColor = Color.White;
            }
            catch
            {
                widhtTextBox.BackColor = Color.LightPink;
            }
        }

        private void colorTextBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Color = colorTextBox.Text.ToString();
                colorTextBox.BackColor = Color.White;
            }
            catch
            {
                colorTextBox.BackColor = Color.LightPink;
            }
        }
        private int FindRectangleWithMaxWidth()
        {
            double max = 0;
            int index = 0;
            for (int i = 0; i < _rectangles.Length; i++)
            {
                if (max < _rectangles[i].Widht)
                {
                    max = _rectangles[i].Widht;
                    index = i;
                }
            }
            return index;
        }

        private void rectangleFindButton_Click(object sender, EventArgs e)
        {
            rectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth();
        }

        private void movieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovie = _movies[movieListBox.SelectedIndex];
            movieNameTextBox.Text = _currentMovie.Name;
            movieDurationTextBox.Text = _currentMovie.Duration.ToString();
            movieGenreTextBox.Text = _currentMovie.Genre;
            movieRateTextBox.Text = _currentMovie.Rate.ToString();
            movieReleaseTextBox.Text = _currentMovie.ReleaseDate.ToString();
        }

        private void movieNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Name = movieNameTextBox.Text;
                movieNameTextBox.BackColor = Color.White;
            }
            catch
            {
                movieNameTextBox.BackColor = Color.LightPink;
            }
        }

        private void movieDurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Duration = Convert.ToInt32(movieDurationTextBox.Text);
                movieDurationTextBox.BackColor = Color.White;
            }
            catch
            {
                movieDurationTextBox.BackColor = Color.LightPink;
            }
        }

        private void movieReleaseTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.ReleaseDate = Convert.ToInt32(movieReleaseTextBox.Text);
                movieReleaseTextBox.BackColor = Color.White;
            }
            catch
            {
                movieReleaseTextBox.BackColor = Color.LightPink;
            }
        }

        private void movieGenreTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Genre = movieGenreTextBox.Text;
                movieGenreTextBox.BackColor = Color.White;
            }
            catch
            {
                movieGenreTextBox.BackColor = Color.LightPink;
            }
        }

        private void movieRateTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Rate = Convert.ToDouble(movieRateTextBox.Text);
                movieRateTextBox.BackColor = Color.White;
            }
            catch
            {
                movieRateTextBox.BackColor = Color.LightPink;
            }
        }

        private void movieFindButton_Click(object sender, EventArgs e)
        {
            movieListBox.SelectedIndex = FindMovieWithMaxRate();
        }

        private int FindMovieWithMaxRate()
        {
            double max = 0;
            int index = 0;
            for (int i = 0; i < _movies.Length; i++)
            {
                if (max < _movies[i].Rate)
                {
                    max = _movies[i].Rate;
                    index = i;
                }
            }
            return index;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}