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
    public partial class RectanglesListControl : UserControl
    {
        public RectanglesListControl()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                _rectangles[i] = new Rectangles(rnd.Next(0, 100), rnd.Next(0, 100), "", rnd.Next(0, 100), rnd.Next(0, 100));
                rectanglesListBox.Items.Add($"Rectangle {i + 1}");

                
            }
        }
        private Rectangles[] _rectangles = new Rectangles[5];
        private Rectangles _currentRectangle;
        Random rnd = new Random();
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
    }
}
