using Programming.Model.Classes;
using Programming.Model.Classes.Geometry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming
{
    public partial class RectangleCollisionControl : UserControl
    {
        public RectangleCollisionControl()
        {
            InitializeComponent();
            rectanglesPanelListBox.SelectedIndex = -1;
        }
        private List<Rectangles> _listRectangles = new List<Rectangles>(10);
        private Rectangles _currentListRectangle;
        Random rnd = new Random();
        private List<Panel> _rectanglePanels = new List<Panel>(10);

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

            for (int i = 0; i < _listRectangles.Count; i++)
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
        private void RectanglePanel_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
