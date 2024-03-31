
using Programming.Model.Classes;
using Programming.Model.Classes.Geometry;
using System.Drawing.Text;
using System.Numerics;

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
                _rectangles[i] = new Rectangles(rnd.Next(0, 100), rnd.Next(0, 100), "", rnd.Next(0, 100), rnd.Next(0, 100));
                rectanglesListBox.Items.Add($"Rectangle {i + 1}");

                _movies[i] = new Movie();
                _movies[i].Rate = rnd.NextDouble() * 10;
                movieListBox.Items.Add($"Movie {i + 1}");
            }
            
            rectanglesPanelListBox.SelectedIndex = -1;

        }
        private List<Rectangles> _listRectangles = new List<Rectangles>(10);
        private Rectangles _currentListRectangle;
        private Rectangles[] _rectangles = new Rectangles[5];
        private Rectangles _currentRectangle;
        Random rnd = new Random();
        private Movie[] _movies = new Movie[5];
        private Movie _currentMovie;
        private List<Panel> _rectanglePanels = new List<Panel>(10);
        
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
            lenghtTextBox.Text = _currentRectangle.Height.ToString();
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
                _currentRectangle.Height = Convert.ToInt32(lenghtTextBox.Text);
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
                _currentRectangle.Widht = Convert.ToInt32(widhtTextBox.Text);
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

        private void IdRectangleLabel_Click(object sender, EventArgs e)
        {

        }

        private void flatAddButton_Click(object sender, EventArgs e)
        {
            _listRectangles.Add(RectangleFactory.New(CanvasPanel.Size.Width, CanvasPanel.Size.Height));
            rectanglesPanelListBox.Items.Add($"(ID: {_listRectangles[^1].Id}, X: {_listRectangles[^1].Center.X}, Y: {_listRectangles[^1].Center.Y}, Widht: {_listRectangles[^1].Widht}, Height: {_listRectangles[^1].Height})");
            Panel panel = new Panel();
            panel.Location = new Point(_listRectangles[^1].Center.X, _listRectangles[^1].Center.Y);
            panel.Height = (int)_listRectangles[^1].Height;
            panel.Width = (int)_listRectangles[^1].Widht;
            panel.BackColor = Color.FromArgb(127, 127, 255, 127);
            _rectanglePanels.Add(panel);
            CanvasPanel.Controls.Add(panel);
            RefreshPanel();
        }

        private void RectanglePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flatDeleteButton_Click(object sender, EventArgs e)
        {
            if (rectanglesPanelListBox.SelectedIndex != -1)
            {
                _listRectangles.RemoveAt(rectanglesPanelListBox.SelectedIndex);
                _rectanglePanels.RemoveAt(rectanglesPanelListBox.SelectedIndex);
                CanvasPanel.Controls.RemoveAt(rectanglesPanelListBox.SelectedIndex);
                rectanglesPanelListBox.Items.RemoveAt(rectanglesPanelListBox.SelectedIndex);
                rectanglesPanelListBox.SelectedIndex = -1;
                IdPanelTextBox.Text = "0";
                XPanelTextBox.Text = "0";
                YPanelTextBox.Text = "0";
                WidhtPanelTextBox.Text = "0";
                LenghtPanelTextBox.Text = "0";

            }
            RefreshPanel();
        }

        private void rectanglesPanelListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rectanglesPanelListBox.SelectedIndex != -1)
            {
                _currentListRectangle = _listRectangles[rectanglesPanelListBox.SelectedIndex];
                IdPanelTextBox.Text = Convert.ToString(_currentListRectangle.Id);
                XPanelTextBox.Text = Convert.ToString(_currentListRectangle.Center.X);
                YPanelTextBox.Text = Convert.ToString(_currentListRectangle.Center.Y);
                WidhtPanelTextBox.Text = Convert.ToString(_currentListRectangle.Widht);
                LenghtPanelTextBox.Text = Convert.ToString(_currentListRectangle.Height);
            }
        }

        private void XPanelTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentListRectangle.Center.X = Convert.ToInt32(XPanelTextBox.Text);
                
                XPanelTextBox.BackColor = Color.White;
            }
            catch
            {
                XPanelTextBox.BackColor = Color.LightPink;
            }
            RefreshPanel();
        }

        private void RefreshPanel()
        {
            
            for (int i = 0; i < _listRectangles.Count;i++)
            {
                bool CollisionFlag = true;
                for (int j = 0; j < _listRectangles.Count; j++)
                {
                    if (i == j) { continue; }
                    if (CollisionManager.IsCollision(_listRectangles[i], _listRectangles[j]))
                    {
                        _rectanglePanels[i].BackColor = Color.FromArgb(127, 255, 127, 127);
                        _rectanglePanels[j].BackColor = Color.FromArgb(127, 255, 127, 127);
                        CollisionFlag = false;
                    }
                }
                if (CollisionFlag)
                {
                    _rectanglePanels[i].BackColor = Color.FromArgb(127, 127, 255, 127);
                }
            }
            CanvasPanel.Controls.Clear();
            for (int i = 0; i < _listRectangles.Count; i++)
            {
                Panel panel = new Panel();
                panel.Location = new Point(_listRectangles[i].Center.X, _listRectangles[i].Center.Y);
                panel.Width = (int)_listRectangles[i].Widht;
                panel.Height = (int)_listRectangles[i].Height;
                panel.BackColor = _rectanglePanels[i].BackColor;
                _rectanglePanels.Add(panel);
                CanvasPanel.Controls.Add(panel);
                rectanglesPanelListBox.Items[i] = $"(ID: {_listRectangles[i].Id}, X: {_listRectangles[i].Center.X}, Y: {_listRectangles[i].Center.Y}, Widht: {_listRectangles[i].Widht}, Height: {_listRectangles[i].Height})";
            }
        }

        private void YPanelTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentListRectangle.Center.Y = Convert.ToInt32(YPanelTextBox.Text);
                
                YPanelTextBox.BackColor = Color.White;
            }
            catch
            {
                YPanelTextBox.BackColor = Color.LightPink;
            }
            RefreshPanel();
        }

        private void WidhtPanelTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentListRectangle.Widht = Convert.ToInt32(WidhtPanelTextBox.Text);
                
                WidhtPanelTextBox.BackColor = Color.White;
            }
            catch
            {
                WidhtPanelTextBox.BackColor = Color.LightPink;
            }
            RefreshPanel();
        }

        private void LenghtPanelTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentListRectangle.Height = Convert.ToInt32(LenghtPanelTextBox.Text);
                
                LenghtPanelTextBox.BackColor = Color.White;
            }
            catch
            {
                LenghtPanelTextBox.BackColor = Color.LightPink;
            }
            RefreshPanel();
        }
    }
}