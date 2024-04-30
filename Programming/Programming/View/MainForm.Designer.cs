namespace Programming
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            enumsTabPage = new TabPage();
            weekdayControl1 = new Panels.WeekdayControl();
            enumerationControl1 = new Panels.EnumerationControl();
            seasonGroupBox = new GroupBox();
            parsingGroupBox = new GroupBox();
            classesTabPage = new TabPage();
            moviesListControl1 = new Panels.MoviesListControl();
            rectanglesListControl1 = new Panels.RectanglesListControl();
            moviesGroupBox = new GroupBox();
            rectanglesTabPage = new TabPage();
            rectangleCollisionControl1 = new RectangleCollisionControl();
            seasonButton = new Button();
            seasonLabel = new Label();
            seasonComboBox = new ComboBox();
            parsedLabel = new Label();
            parsingButton = new Button();
            parsingTextBox = new TextBox();
            weekdayParsingLabel = new Label();
            intValueLabel = new Label();
            ValueTextBox = new TextBox();
            valuesListBox = new ListBox();
            valueLabel = new Label();
            enumerationListBox = new ListBox();
            enumerationLabel = new Label();
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
            idTextBox = new TextBox();
            idLabel = new Label();
            centerYTextBox = new TextBox();
            centerYLabel = new Label();
            centerXTextBox = new TextBox();
            centerXLabel = new Label();
            rectangleFindButton = new Button();
            rectanglesListBox = new ListBox();
            colorTextBox = new TextBox();
            colorLabel = new Label();
            widhtTextBox = new TextBox();
            widthLabel = new Label();
            lenghtTextBox = new TextBox();
            lenghtLabel = new Label();
            mainFormBindingSource1 = new BindingSource(components);
            mainFormBindingSource = new BindingSource(components);
            seasonHandleControl1 = new Panels.SeasonHandleControl();
            tabControl1.SuspendLayout();
            enumsTabPage.SuspendLayout();
            classesTabPage.SuspendLayout();
            rectanglesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainFormBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainFormBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(enumsTabPage);
            tabControl1.Controls.Add(classesTabPage);
            tabControl1.Controls.Add(rectanglesTabPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // enumsTabPage
            // 
            enumsTabPage.Controls.Add(seasonHandleControl1);
            enumsTabPage.Controls.Add(weekdayControl1);
            enumsTabPage.Controls.Add(enumerationControl1);
            enumsTabPage.Controls.Add(seasonGroupBox);
            enumsTabPage.Controls.Add(parsingGroupBox);
            enumsTabPage.Location = new Point(4, 29);
            enumsTabPage.Name = "enumsTabPage";
            enumsTabPage.Padding = new Padding(3);
            enumsTabPage.Size = new Size(792, 417);
            enumsTabPage.TabIndex = 0;
            enumsTabPage.Text = "Enums";
            enumsTabPage.UseVisualStyleBackColor = true;
            // 
            // weekdayControl1
            // 
            weekdayControl1.Location = new Point(0, 229);
            weekdayControl1.Name = "weekdayControl1";
            weekdayControl1.Size = new Size(399, 155);
            weekdayControl1.TabIndex = 5;
            // 
            // enumerationControl1
            // 
            enumerationControl1.Location = new Point(0, -17);
            enumerationControl1.Name = "enumerationControl1";
            enumerationControl1.Size = new Size(569, 220);
            enumerationControl1.TabIndex = 3;
            // 
            // seasonGroupBox
            // 
            seasonGroupBox.Location = new Point(0, 0);
            seasonGroupBox.Name = "seasonGroupBox";
            seasonGroupBox.Size = new Size(200, 100);
            seasonGroupBox.TabIndex = 6;
            seasonGroupBox.TabStop = false;
            // 
            // parsingGroupBox
            // 
            parsingGroupBox.Location = new Point(0, 0);
            parsingGroupBox.Name = "parsingGroupBox";
            parsingGroupBox.Size = new Size(200, 100);
            parsingGroupBox.TabIndex = 7;
            parsingGroupBox.TabStop = false;
            // 
            // classesTabPage
            // 
            classesTabPage.Controls.Add(moviesListControl1);
            classesTabPage.Controls.Add(rectanglesListControl1);
            classesTabPage.Controls.Add(moviesGroupBox);
            classesTabPage.Location = new Point(4, 29);
            classesTabPage.Name = "classesTabPage";
            classesTabPage.Size = new Size(792, 417);
            classesTabPage.TabIndex = 1;
            classesTabPage.Text = "Classes";
            classesTabPage.UseVisualStyleBackColor = true;
            // 
            // moviesListControl1
            // 
            moviesListControl1.Location = new Point(372, 3);
            moviesListControl1.Name = "moviesListControl1";
            moviesListControl1.Size = new Size(395, 396);
            moviesListControl1.TabIndex = 4;
            // 
            // rectanglesListControl1
            // 
            rectanglesListControl1.Location = new Point(8, 0);
            rectanglesListControl1.Name = "rectanglesListControl1";
            rectanglesListControl1.Size = new Size(382, 397);
            rectanglesListControl1.TabIndex = 2;
            // 
            // moviesGroupBox
            // 
            moviesGroupBox.Location = new Point(0, 0);
            moviesGroupBox.Name = "moviesGroupBox";
            moviesGroupBox.Size = new Size(200, 100);
            moviesGroupBox.TabIndex = 3;
            moviesGroupBox.TabStop = false;
            // 
            // rectanglesTabPage
            // 
            rectanglesTabPage.Controls.Add(rectangleCollisionControl1);
            rectanglesTabPage.Location = new Point(4, 29);
            rectanglesTabPage.Name = "rectanglesTabPage";
            rectanglesTabPage.Size = new Size(792, 417);
            rectanglesTabPage.TabIndex = 2;
            rectanglesTabPage.Text = "Rectangles";
            rectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // rectangleCollisionControl1
            // 
            rectangleCollisionControl1.Location = new Point(-4, 3);
            rectangleCollisionControl1.Name = "rectangleCollisionControl1";
            rectangleCollisionControl1.Size = new Size(984, 531);
            rectangleCollisionControl1.TabIndex = 0;
            // 
            // seasonButton
            // 
            seasonButton.Location = new Point(0, 0);
            seasonButton.Name = "seasonButton";
            seasonButton.Size = new Size(75, 23);
            seasonButton.TabIndex = 0;
            // 
            // seasonLabel
            // 
            seasonLabel.Location = new Point(0, 0);
            seasonLabel.Name = "seasonLabel";
            seasonLabel.Size = new Size(100, 23);
            seasonLabel.TabIndex = 0;
            // 
            // seasonComboBox
            // 
            seasonComboBox.Location = new Point(0, 0);
            seasonComboBox.Name = "seasonComboBox";
            seasonComboBox.Size = new Size(121, 28);
            seasonComboBox.TabIndex = 0;
            // 
            // parsedLabel
            // 
            parsedLabel.Location = new Point(0, 0);
            parsedLabel.Name = "parsedLabel";
            parsedLabel.Size = new Size(100, 23);
            parsedLabel.TabIndex = 0;
            // 
            // parsingButton
            // 
            parsingButton.Location = new Point(0, 0);
            parsingButton.Name = "parsingButton";
            parsingButton.Size = new Size(75, 23);
            parsingButton.TabIndex = 0;
            // 
            // parsingTextBox
            // 
            parsingTextBox.Location = new Point(0, 0);
            parsingTextBox.Name = "parsingTextBox";
            parsingTextBox.Size = new Size(100, 27);
            parsingTextBox.TabIndex = 0;
            // 
            // weekdayParsingLabel
            // 
            weekdayParsingLabel.Location = new Point(0, 0);
            weekdayParsingLabel.Name = "weekdayParsingLabel";
            weekdayParsingLabel.Size = new Size(100, 23);
            weekdayParsingLabel.TabIndex = 0;
            // 
            // intValueLabel
            // 
            intValueLabel.Location = new Point(0, 0);
            intValueLabel.Name = "intValueLabel";
            intValueLabel.Size = new Size(100, 23);
            intValueLabel.TabIndex = 0;
            // 
            // ValueTextBox
            // 
            ValueTextBox.Location = new Point(0, 0);
            ValueTextBox.Name = "ValueTextBox";
            ValueTextBox.Size = new Size(100, 27);
            ValueTextBox.TabIndex = 0;
            // 
            // valuesListBox
            // 
            valuesListBox.Location = new Point(0, 0);
            valuesListBox.Name = "valuesListBox";
            valuesListBox.Size = new Size(120, 96);
            valuesListBox.TabIndex = 0;
            // 
            // valueLabel
            // 
            valueLabel.Location = new Point(0, 0);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new Size(100, 23);
            valueLabel.TabIndex = 0;
            // 
            // enumerationListBox
            // 
            enumerationListBox.Location = new Point(0, 0);
            enumerationListBox.Name = "enumerationListBox";
            enumerationListBox.Size = new Size(120, 96);
            enumerationListBox.TabIndex = 0;
            // 
            // enumerationLabel
            // 
            enumerationLabel.Location = new Point(0, 0);
            enumerationLabel.Name = "enumerationLabel";
            enumerationLabel.Size = new Size(100, 23);
            enumerationLabel.TabIndex = 0;
            // 
            // movieRateTextBox
            // 
            movieRateTextBox.Location = new Point(0, 0);
            movieRateTextBox.Name = "movieRateTextBox";
            movieRateTextBox.Size = new Size(100, 27);
            movieRateTextBox.TabIndex = 0;
            // 
            // movieRateLabel
            // 
            movieRateLabel.Location = new Point(0, 0);
            movieRateLabel.Name = "movieRateLabel";
            movieRateLabel.Size = new Size(100, 23);
            movieRateLabel.TabIndex = 0;
            // 
            // movieFindButton
            // 
            movieFindButton.Location = new Point(0, 0);
            movieFindButton.Name = "movieFindButton";
            movieFindButton.Size = new Size(75, 23);
            movieFindButton.TabIndex = 0;
            // 
            // movieGenreTextBox
            // 
            movieGenreTextBox.Location = new Point(0, 0);
            movieGenreTextBox.Name = "movieGenreTextBox";
            movieGenreTextBox.Size = new Size(100, 27);
            movieGenreTextBox.TabIndex = 0;
            // 
            // movieGenreLabel
            // 
            movieGenreLabel.Location = new Point(0, 0);
            movieGenreLabel.Name = "movieGenreLabel";
            movieGenreLabel.Size = new Size(100, 23);
            movieGenreLabel.TabIndex = 0;
            // 
            // movieReleaseTextBox
            // 
            movieReleaseTextBox.Location = new Point(0, 0);
            movieReleaseTextBox.Name = "movieReleaseTextBox";
            movieReleaseTextBox.Size = new Size(100, 27);
            movieReleaseTextBox.TabIndex = 0;
            // 
            // movieReleaseLabel
            // 
            movieReleaseLabel.Location = new Point(0, 0);
            movieReleaseLabel.Name = "movieReleaseLabel";
            movieReleaseLabel.Size = new Size(100, 23);
            movieReleaseLabel.TabIndex = 0;
            // 
            // movieDurationTextBox
            // 
            movieDurationTextBox.Location = new Point(0, 0);
            movieDurationTextBox.Name = "movieDurationTextBox";
            movieDurationTextBox.Size = new Size(100, 27);
            movieDurationTextBox.TabIndex = 0;
            // 
            // movieDurationLabel
            // 
            movieDurationLabel.Location = new Point(0, 0);
            movieDurationLabel.Name = "movieDurationLabel";
            movieDurationLabel.Size = new Size(100, 23);
            movieDurationLabel.TabIndex = 0;
            // 
            // movieNameTextBox
            // 
            movieNameTextBox.Location = new Point(0, 0);
            movieNameTextBox.Name = "movieNameTextBox";
            movieNameTextBox.Size = new Size(100, 27);
            movieNameTextBox.TabIndex = 0;
            // 
            // movieNameLabel
            // 
            movieNameLabel.Location = new Point(0, 0);
            movieNameLabel.Name = "movieNameLabel";
            movieNameLabel.Size = new Size(100, 23);
            movieNameLabel.TabIndex = 0;
            // 
            // movieListBox
            // 
            movieListBox.Location = new Point(0, 0);
            movieListBox.Name = "movieListBox";
            movieListBox.Size = new Size(120, 96);
            movieListBox.TabIndex = 0;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(0, 0);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(100, 27);
            idTextBox.TabIndex = 0;
            // 
            // idLabel
            // 
            idLabel.Location = new Point(0, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(100, 23);
            idLabel.TabIndex = 0;
            // 
            // centerYTextBox
            // 
            centerYTextBox.Location = new Point(0, 0);
            centerYTextBox.Name = "centerYTextBox";
            centerYTextBox.Size = new Size(100, 27);
            centerYTextBox.TabIndex = 0;
            // 
            // centerYLabel
            // 
            centerYLabel.Location = new Point(0, 0);
            centerYLabel.Name = "centerYLabel";
            centerYLabel.Size = new Size(100, 23);
            centerYLabel.TabIndex = 0;
            // 
            // centerXTextBox
            // 
            centerXTextBox.Location = new Point(0, 0);
            centerXTextBox.Name = "centerXTextBox";
            centerXTextBox.Size = new Size(100, 27);
            centerXTextBox.TabIndex = 0;
            // 
            // centerXLabel
            // 
            centerXLabel.Location = new Point(0, 0);
            centerXLabel.Name = "centerXLabel";
            centerXLabel.Size = new Size(100, 23);
            centerXLabel.TabIndex = 0;
            // 
            // rectangleFindButton
            // 
            rectangleFindButton.Location = new Point(0, 0);
            rectangleFindButton.Name = "rectangleFindButton";
            rectangleFindButton.Size = new Size(75, 23);
            rectangleFindButton.TabIndex = 0;
            // 
            // rectanglesListBox
            // 
            rectanglesListBox.Location = new Point(0, 0);
            rectanglesListBox.Name = "rectanglesListBox";
            rectanglesListBox.Size = new Size(120, 96);
            rectanglesListBox.TabIndex = 0;
            // 
            // colorTextBox
            // 
            colorTextBox.Location = new Point(0, 0);
            colorTextBox.Name = "colorTextBox";
            colorTextBox.Size = new Size(100, 27);
            colorTextBox.TabIndex = 0;
            // 
            // colorLabel
            // 
            colorLabel.Location = new Point(0, 0);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(100, 23);
            colorLabel.TabIndex = 0;
            // 
            // widhtTextBox
            // 
            widhtTextBox.Location = new Point(0, 0);
            widhtTextBox.Name = "widhtTextBox";
            widhtTextBox.Size = new Size(100, 27);
            widhtTextBox.TabIndex = 0;
            // 
            // widthLabel
            // 
            widthLabel.Location = new Point(0, 0);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new Size(100, 23);
            widthLabel.TabIndex = 0;
            // 
            // lenghtTextBox
            // 
            lenghtTextBox.Location = new Point(0, 0);
            lenghtTextBox.Name = "lenghtTextBox";
            lenghtTextBox.Size = new Size(100, 27);
            lenghtTextBox.TabIndex = 0;
            // 
            // lenghtLabel
            // 
            lenghtLabel.Location = new Point(0, 0);
            lenghtLabel.Name = "lenghtLabel";
            lenghtLabel.Size = new Size(100, 23);
            lenghtLabel.TabIndex = 0;
            // 
            // mainFormBindingSource1
            // 
            mainFormBindingSource1.DataSource = typeof(MainForm);
            // 
            // mainFormBindingSource
            // 
            mainFormBindingSource.DataSource = typeof(MainForm);
            // 
            // seasonHandleControl1
            // 
            seasonHandleControl1.Location = new Point(366, 229);
            seasonHandleControl1.Name = "seasonHandleControl1";
            seasonHandleControl1.Size = new Size(442, 172);
            seasonHandleControl1.TabIndex = 8;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            enumsTabPage.ResumeLayout(false);
            classesTabPage.ResumeLayout(false);
            rectanglesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainFormBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainFormBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage enumsTabPage;
        private Label enumerationLabel;
        private ListBox enumerationListBox;
        private BindingSource mainFormBindingSource;
        private ListBox valuesListBox;
        private Label valueLabel;
        private Label intValueLabel;
        private TextBox ValueTextBox;
        private GroupBox parsingGroupBox;
        private Label parsedLabel;
        private Button parsingButton;
        private TextBox parsingTextBox;
        private Label weekdayParsingLabel;
        private GroupBox seasonGroupBox;
        private Button seasonButton;
        private Label seasonLabel;
        private ComboBox seasonComboBox;
        private TabPage classesTabPage;
        private Button rectangleFindButton;
        private TextBox colorTextBox;
        private Label colorLabel;
        private TextBox widhtTextBox;
        private Label widthLabel;
        private TextBox lenghtTextBox;
        private Label lenghtLabel;
        private ListBox rectanglesListBox;
        private BindingSource mainFormBindingSource1;
        private GroupBox moviesGroupBox;
        private Label movieNameLabel;
        private ListBox movieListBox;
        private Button movieFindButton;
        private TextBox movieGenreTextBox;
        private Label movieGenreLabel;
        private TextBox movieReleaseTextBox;
        private Label movieReleaseLabel;
        private TextBox movieDurationTextBox;
        private Label movieDurationLabel;
        private TextBox movieNameTextBox;
        private TextBox movieRateTextBox;
        private Label movieRateLabel;
        private TextBox centerYTextBox;
        private Label centerYLabel;
        private TextBox centerXTextBox;
        private Label centerXLabel;
        private TextBox idTextBox;
        private Label idLabel;
        private TabPage rectanglesTabPage;
        private RectangleCollisionControl rectangleCollisionControl1;
        private Panels.RectanglesListControl rectanglesListControl1;
        private Panels.MoviesListControl moviesListControl1;
        private Panels.EnumerationControl enumerationControl1;
        private Panels.WeekdayControl weekdayControl1;
        private Panels.SeasonHandleControl seasonHandleControl1;
    }
}