namespace Programming.Panels
{
    partial class MoviesListControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            movieRateTextBox = new TextBox();
            movieRateLabel = new Label();
            movieFindButton = new Button();
            movieGenreTextBox = new TextBox();
            movieGenreLabel = new Label();
            movieReleaseTextBox = new TextBox();
            movieReleaseLabel = new Label();
            movieDurationTextBox = new TextBox();
            movieDurationLabel = new Label();
            movieNameTextBox = new TextBox();
            movieNameLabel = new Label();
            movieListBox = new ListBox();
            SuspendLayout();
            // 
            // movieRateTextBox
            // 
            movieRateTextBox.Location = new Point(162, 264);
            movieRateTextBox.Name = "movieRateTextBox";
            movieRateTextBox.Size = new Size(146, 27);
            movieRateTextBox.TabIndex = 11;
            movieRateTextBox.TextChanged += movieRateTextBox_TextChanged;
            // 
            // movieRateLabel
            // 
            movieRateLabel.AutoSize = true;
            movieRateLabel.Location = new Point(162, 241);
            movieRateLabel.Name = "movieRateLabel";
            movieRateLabel.Size = new Size(46, 20);
            movieRateLabel.TabIndex = 10;
            movieRateLabel.Text = "Rate: ";
            // 
            // movieFindButton
            // 
            movieFindButton.Location = new Point(162, 301);
            movieFindButton.Name = "movieFindButton";
            movieFindButton.Size = new Size(146, 29);
            movieFindButton.TabIndex = 9;
            movieFindButton.Text = "Find";
            movieFindButton.UseVisualStyleBackColor = true;
            movieFindButton.Click += movieFindButton_Click;
            // 
            // movieGenreTextBox
            // 
            movieGenreTextBox.Location = new Point(162, 208);
            movieGenreTextBox.Name = "movieGenreTextBox";
            movieGenreTextBox.Size = new Size(146, 27);
            movieGenreTextBox.TabIndex = 8;
            movieGenreTextBox.TextChanged += movieGenreTextBox_TextChanged;
            // 
            // movieGenreLabel
            // 
            movieGenreLabel.AutoSize = true;
            movieGenreLabel.Location = new Point(162, 185);
            movieGenreLabel.Name = "movieGenreLabel";
            movieGenreLabel.Size = new Size(55, 20);
            movieGenreLabel.TabIndex = 7;
            movieGenreLabel.Text = "Genre: ";
            // 
            // movieReleaseTextBox
            // 
            movieReleaseTextBox.Location = new Point(162, 155);
            movieReleaseTextBox.Name = "movieReleaseTextBox";
            movieReleaseTextBox.Size = new Size(146, 27);
            movieReleaseTextBox.TabIndex = 6;
            movieReleaseTextBox.TextChanged += movieReleaseTextBox_TextChanged;
            // 
            // movieReleaseLabel
            // 
            movieReleaseLabel.AutoSize = true;
            movieReleaseLabel.Location = new Point(162, 132);
            movieReleaseLabel.Name = "movieReleaseLabel";
            movieReleaseLabel.Size = new Size(103, 20);
            movieReleaseLabel.TabIndex = 5;
            movieReleaseLabel.Text = "Release Date: ";
            // 
            // movieDurationTextBox
            // 
            movieDurationTextBox.Location = new Point(162, 102);
            movieDurationTextBox.Name = "movieDurationTextBox";
            movieDurationTextBox.Size = new Size(146, 27);
            movieDurationTextBox.TabIndex = 4;
            movieDurationTextBox.TextChanged += movieDurationTextBox_TextChanged;
            // 
            // movieDurationLabel
            // 
            movieDurationLabel.AutoSize = true;
            movieDurationLabel.Location = new Point(162, 79);
            movieDurationLabel.Name = "movieDurationLabel";
            movieDurationLabel.Size = new Size(74, 20);
            movieDurationLabel.TabIndex = 3;
            movieDurationLabel.Text = "Duration: ";
            // 
            // movieNameTextBox
            // 
            movieNameTextBox.Location = new Point(162, 49);
            movieNameTextBox.Name = "movieNameTextBox";
            movieNameTextBox.Size = new Size(146, 27);
            movieNameTextBox.TabIndex = 2;
            movieNameTextBox.TextChanged += movieNameTextBox_TextChanged;
            // 
            // movieNameLabel
            // 
            movieNameLabel.AutoSize = true;
            movieNameLabel.Location = new Point(162, 26);
            movieNameLabel.Name = "movieNameLabel";
            movieNameLabel.Size = new Size(56, 20);
            movieNameLabel.TabIndex = 1;
            movieNameLabel.Text = "Name: ";
            // 
            // movieListBox
            // 
            movieListBox.FormattingEnabled = true;
            movieListBox.ItemHeight = 20;
            movieListBox.Location = new Point(6, 26);
            movieListBox.Name = "movieListBox";
            movieListBox.Size = new Size(150, 304);
            movieListBox.TabIndex = 0;
            movieListBox.SelectedIndexChanged += movieListBox_SelectedIndexChanged;
            // 
            // MoviesListControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(movieRateTextBox);
            Controls.Add(movieRateLabel);
            Controls.Add(movieFindButton);
            Controls.Add(movieGenreTextBox);
            Controls.Add(movieGenreLabel);
            Controls.Add(movieReleaseTextBox);
            Controls.Add(movieReleaseLabel);
            Controls.Add(movieDurationTextBox);
            Controls.Add(movieDurationLabel);
            Controls.Add(movieNameTextBox);
            Controls.Add(movieNameLabel);
            Controls.Add(movieListBox);
            Name = "MoviesListControl";
            Size = new Size(316, 317);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox movieRateTextBox;
        private Label movieRateLabel;
        private Button movieFindButton;
        private TextBox movieGenreTextBox;
        private Label movieGenreLabel;
        private TextBox movieReleaseTextBox;
        private Label movieReleaseLabel;
        private TextBox movieDurationTextBox;
        private Label movieDurationLabel;
        private TextBox movieNameTextBox;
        private Label movieNameLabel;
        private ListBox movieListBox;
    }
}
