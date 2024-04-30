using Programming.Model.Classes;
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
    public partial class MoviesListControl : UserControl
    {
        public MoviesListControl()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {


                _movies[i] = new Movie();
                _movies[i].Rate = rnd.NextDouble() * 10;
                movieListBox.Items.Add($"Movie {i + 1}");
            }
        }
        Random rnd = new Random();
        private Movie[] _movies = new Movie[5];
        private Movie _currentMovie;
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
    }
}
