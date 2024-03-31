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
            seasonGroupBox = new GroupBox();
            seasonButton = new Button();
            seasonLabel = new Label();
            seasonComboBox = new ComboBox();
            parsingGroupBox = new GroupBox();
            parsedLabel = new Label();
            parsingButton = new Button();
            parsingTextBox = new TextBox();
            weekdayParsingLabel = new Label();
            enumerationGroupBox = new GroupBox();
            intValueLabel = new Label();
            ValueTextBox = new TextBox();
            valuesListBox = new ListBox();
            valueLabel = new Label();
            enumerationListBox = new ListBox();
            enumerationLabel = new Label();
            classesTabPage = new TabPage();
            moviesGroupBox = new GroupBox();
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
            rectanglesGroupBox = new GroupBox();
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
            rectanglesTabPage = new TabPage();
            CanvasPanel = new Panel();
            lenghtRectangleLabel = new Label();
            WidhtRectangleLabel = new Label();
            YRectangleLabel = new Label();
            XRectangleLabel = new Label();
            IdRectangleLabel = new Label();
            LenghtPanelTextBox = new TextBox();
            WidhtPanelTextBox = new TextBox();
            YPanelTextBox = new TextBox();
            XPanelTextBox = new TextBox();
            IdPanelTextBox = new TextBox();
            selectedRectangleLabel = new Label();
            flatAddButton = new PictureBox();
            flatDeleteButton = new PictureBox();
            rectanglesPanelListBox = new ListBox();
            rectanglesLabel = new Label();
            mainFormBindingSource1 = new BindingSource(components);
            mainFormBindingSource = new BindingSource(components);
            tabControl1.SuspendLayout();
            enumsTabPage.SuspendLayout();
            seasonGroupBox.SuspendLayout();
            parsingGroupBox.SuspendLayout();
            enumerationGroupBox.SuspendLayout();
            classesTabPage.SuspendLayout();
            moviesGroupBox.SuspendLayout();
            rectanglesGroupBox.SuspendLayout();
            rectanglesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)flatAddButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flatDeleteButton).BeginInit();
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
            enumsTabPage.Controls.Add(seasonGroupBox);
            enumsTabPage.Controls.Add(parsingGroupBox);
            enumsTabPage.Controls.Add(enumerationGroupBox);
            enumsTabPage.Location = new Point(4, 29);
            enumsTabPage.Name = "enumsTabPage";
            enumsTabPage.Padding = new Padding(3);
            enumsTabPage.Size = new Size(792, 417);
            enumsTabPage.TabIndex = 0;
            enumsTabPage.Text = "Enums";
            enumsTabPage.UseVisualStyleBackColor = true;
            // 
            // seasonGroupBox
            // 
            seasonGroupBox.Controls.Add(seasonButton);
            seasonGroupBox.Controls.Add(seasonLabel);
            seasonGroupBox.Controls.Add(seasonComboBox);
            seasonGroupBox.Location = new Point(405, 229);
            seasonGroupBox.Name = "seasonGroupBox";
            seasonGroupBox.Size = new Size(381, 182);
            seasonGroupBox.TabIndex = 2;
            seasonGroupBox.TabStop = false;
            seasonGroupBox.Text = "Season Handle";
            // 
            // seasonButton
            // 
            seasonButton.Location = new Point(255, 46);
            seasonButton.Name = "seasonButton";
            seasonButton.Size = new Size(94, 29);
            seasonButton.TabIndex = 2;
            seasonButton.Text = "Go!";
            seasonButton.UseVisualStyleBackColor = true;
            seasonButton.Click += seasonButton_Click;
            // 
            // seasonLabel
            // 
            seasonLabel.AutoSize = true;
            seasonLabel.Location = new Point(6, 23);
            seasonLabel.Name = "seasonLabel";
            seasonLabel.Size = new Size(114, 20);
            seasonLabel.TabIndex = 1;
            seasonLabel.Text = "Choose season: ";
            // 
            // seasonComboBox
            // 
            seasonComboBox.FormattingEnabled = true;
            seasonComboBox.ImeMode = ImeMode.NoControl;
            seasonComboBox.Location = new Point(6, 45);
            seasonComboBox.Name = "seasonComboBox";
            seasonComboBox.Size = new Size(243, 28);
            seasonComboBox.TabIndex = 0;
            // 
            // parsingGroupBox
            // 
            parsingGroupBox.Controls.Add(parsedLabel);
            parsingGroupBox.Controls.Add(parsingButton);
            parsingGroupBox.Controls.Add(parsingTextBox);
            parsingGroupBox.Controls.Add(weekdayParsingLabel);
            parsingGroupBox.Location = new Point(6, 229);
            parsingGroupBox.Name = "parsingGroupBox";
            parsingGroupBox.Size = new Size(393, 182);
            parsingGroupBox.TabIndex = 1;
            parsingGroupBox.TabStop = false;
            parsingGroupBox.Text = "Weekday Parsing";
            parsingGroupBox.Enter += parsingGroupBox_Enter;
            // 
            // parsedLabel
            // 
            parsedLabel.AutoSize = true;
            parsedLabel.Location = new Point(6, 76);
            parsedLabel.Name = "parsedLabel";
            parsedLabel.Size = new Size(0, 20);
            parsedLabel.TabIndex = 3;
            // 
            // parsingButton
            // 
            parsingButton.Location = new Point(269, 46);
            parsingButton.Name = "parsingButton";
            parsingButton.Size = new Size(94, 29);
            parsingButton.TabIndex = 2;
            parsingButton.Text = "Parse";
            parsingButton.UseVisualStyleBackColor = true;
            parsingButton.Click += parsingButton_Click;
            // 
            // parsingTextBox
            // 
            parsingTextBox.Location = new Point(6, 46);
            parsingTextBox.Name = "parsingTextBox";
            parsingTextBox.Size = new Size(257, 27);
            parsingTextBox.TabIndex = 1;
            // 
            // weekdayParsingLabel
            // 
            weekdayParsingLabel.AutoSize = true;
            weekdayParsingLabel.Location = new Point(6, 23);
            weekdayParsingLabel.Name = "weekdayParsingLabel";
            weekdayParsingLabel.Size = new Size(162, 20);
            weekdayParsingLabel.TabIndex = 0;
            weekdayParsingLabel.Text = "Type value for parsing: ";
            // 
            // enumerationGroupBox
            // 
            enumerationGroupBox.AutoSize = true;
            enumerationGroupBox.Controls.Add(intValueLabel);
            enumerationGroupBox.Controls.Add(ValueTextBox);
            enumerationGroupBox.Controls.Add(valuesListBox);
            enumerationGroupBox.Controls.Add(valueLabel);
            enumerationGroupBox.Controls.Add(enumerationListBox);
            enumerationGroupBox.Controls.Add(enumerationLabel);
            enumerationGroupBox.Location = new Point(6, 6);
            enumerationGroupBox.Name = "enumerationGroupBox";
            enumerationGroupBox.Size = new Size(780, 217);
            enumerationGroupBox.TabIndex = 0;
            enumerationGroupBox.TabStop = false;
            enumerationGroupBox.Text = "Enumerations";
            // 
            // intValueLabel
            // 
            intValueLabel.AutoSize = true;
            intValueLabel.Location = new Point(321, 23);
            intValueLabel.Name = "intValueLabel";
            intValueLabel.Size = new Size(72, 20);
            intValueLabel.TabIndex = 5;
            intValueLabel.Text = "Int value: ";
            // 
            // ValueTextBox
            // 
            ValueTextBox.Location = new Point(321, 46);
            ValueTextBox.Name = "ValueTextBox";
            ValueTextBox.Size = new Size(125, 27);
            ValueTextBox.TabIndex = 4;
            // 
            // valuesListBox
            // 
            valuesListBox.FormattingEnabled = true;
            valuesListBox.ItemHeight = 20;
            valuesListBox.Location = new Point(165, 46);
            valuesListBox.Name = "valuesListBox";
            valuesListBox.Size = new Size(150, 144);
            valuesListBox.TabIndex = 3;
            valuesListBox.SelectedIndexChanged += valuesListBox_SelectedIndexChanged;
            // 
            // valueLabel
            // 
            valueLabel.AutoSize = true;
            valueLabel.Location = new Point(165, 23);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new Size(104, 20);
            valueLabel.TabIndex = 2;
            valueLabel.Text = "Choose value: ";
            // 
            // enumerationListBox
            // 
            enumerationListBox.FormattingEnabled = true;
            enumerationListBox.ItemHeight = 20;
            enumerationListBox.Location = new Point(6, 46);
            enumerationListBox.Name = "enumerationListBox";
            enumerationListBox.Size = new Size(153, 144);
            enumerationListBox.TabIndex = 1;
            enumerationListBox.SelectedIndexChanged += enumerationListBox_SelectedIndexChanged;
            // 
            // enumerationLabel
            // 
            enumerationLabel.AutoSize = true;
            enumerationLabel.Location = new Point(6, 23);
            enumerationLabel.Name = "enumerationLabel";
            enumerationLabel.Size = new Size(153, 20);
            enumerationLabel.TabIndex = 0;
            enumerationLabel.Text = "Choose enumeration: ";
            enumerationLabel.Click += label1_Click;
            // 
            // classesTabPage
            // 
            classesTabPage.Controls.Add(moviesGroupBox);
            classesTabPage.Controls.Add(rectanglesGroupBox);
            classesTabPage.Location = new Point(4, 29);
            classesTabPage.Name = "classesTabPage";
            classesTabPage.Size = new Size(792, 417);
            classesTabPage.TabIndex = 1;
            classesTabPage.Text = "Classes";
            classesTabPage.UseVisualStyleBackColor = true;
            // 
            // moviesGroupBox
            // 
            moviesGroupBox.Controls.Add(movieRateTextBox);
            moviesGroupBox.Controls.Add(movieRateLabel);
            moviesGroupBox.Controls.Add(movieFindButton);
            moviesGroupBox.Controls.Add(movieGenreTextBox);
            moviesGroupBox.Controls.Add(movieGenreLabel);
            moviesGroupBox.Controls.Add(movieReleaseTextBox);
            moviesGroupBox.Controls.Add(movieReleaseLabel);
            moviesGroupBox.Controls.Add(movieDurationTextBox);
            moviesGroupBox.Controls.Add(movieDurationLabel);
            moviesGroupBox.Controls.Add(movieNameTextBox);
            moviesGroupBox.Controls.Add(movieNameLabel);
            moviesGroupBox.Controls.Add(movieListBox);
            moviesGroupBox.Location = new Point(406, 3);
            moviesGroupBox.Name = "moviesGroupBox";
            moviesGroupBox.Size = new Size(383, 411);
            moviesGroupBox.TabIndex = 1;
            moviesGroupBox.TabStop = false;
            moviesGroupBox.Text = "Movies";
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
            // rectanglesGroupBox
            // 
            rectanglesGroupBox.Controls.Add(idTextBox);
            rectanglesGroupBox.Controls.Add(idLabel);
            rectanglesGroupBox.Controls.Add(centerYTextBox);
            rectanglesGroupBox.Controls.Add(centerYLabel);
            rectanglesGroupBox.Controls.Add(centerXTextBox);
            rectanglesGroupBox.Controls.Add(centerXLabel);
            rectanglesGroupBox.Controls.Add(rectangleFindButton);
            rectanglesGroupBox.Controls.Add(rectanglesListBox);
            rectanglesGroupBox.Controls.Add(colorTextBox);
            rectanglesGroupBox.Controls.Add(colorLabel);
            rectanglesGroupBox.Controls.Add(widhtTextBox);
            rectanglesGroupBox.Controls.Add(widthLabel);
            rectanglesGroupBox.Controls.Add(lenghtTextBox);
            rectanglesGroupBox.Controls.Add(lenghtLabel);
            rectanglesGroupBox.Location = new Point(3, 3);
            rectanglesGroupBox.Name = "rectanglesGroupBox";
            rectanglesGroupBox.Size = new Size(397, 411);
            rectanglesGroupBox.TabIndex = 0;
            rectanglesGroupBox.TabStop = false;
            rectanglesGroupBox.Text = "Rectangles";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(6, 356);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(125, 27);
            idTextBox.TabIndex = 13;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(6, 333);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(29, 20);
            idLabel.TabIndex = 12;
            idLabel.Text = "Id: ";
            // 
            // centerYTextBox
            // 
            centerYTextBox.Location = new Point(169, 264);
            centerYTextBox.Name = "centerYTextBox";
            centerYTextBox.ReadOnly = true;
            centerYTextBox.Size = new Size(146, 27);
            centerYTextBox.TabIndex = 11;
            // 
            // centerYLabel
            // 
            centerYLabel.AutoSize = true;
            centerYLabel.Location = new Point(169, 241);
            centerYLabel.Name = "centerYLabel";
            centerYLabel.Size = new Size(67, 20);
            centerYLabel.TabIndex = 10;
            centerYLabel.Text = "Center Y:";
            // 
            // centerXTextBox
            // 
            centerXTextBox.Location = new Point(169, 208);
            centerXTextBox.Name = "centerXTextBox";
            centerXTextBox.ReadOnly = true;
            centerXTextBox.Size = new Size(146, 27);
            centerXTextBox.TabIndex = 9;
            // 
            // centerXLabel
            // 
            centerXLabel.AutoSize = true;
            centerXLabel.Location = new Point(169, 185);
            centerXLabel.Name = "centerXLabel";
            centerXLabel.Size = new Size(68, 20);
            centerXLabel.TabIndex = 8;
            centerXLabel.Text = "Center X:";
            centerXLabel.Click += label1_Click_1;
            // 
            // rectangleFindButton
            // 
            rectangleFindButton.Location = new Point(169, 301);
            rectangleFindButton.Name = "rectangleFindButton";
            rectangleFindButton.Size = new Size(146, 29);
            rectangleFindButton.TabIndex = 7;
            rectangleFindButton.Text = "Find";
            rectangleFindButton.UseVisualStyleBackColor = true;
            rectangleFindButton.Click += rectangleFindButton_Click;
            // 
            // rectanglesListBox
            // 
            rectanglesListBox.FormattingEnabled = true;
            rectanglesListBox.ItemHeight = 20;
            rectanglesListBox.Location = new Point(5, 26);
            rectanglesListBox.Name = "rectanglesListBox";
            rectanglesListBox.Size = new Size(158, 304);
            rectanglesListBox.TabIndex = 0;
            rectanglesListBox.SelectedIndexChanged += rectanglesListBox_SelectedIndexChanged;
            // 
            // colorTextBox
            // 
            colorTextBox.Location = new Point(169, 155);
            colorTextBox.Name = "colorTextBox";
            colorTextBox.Size = new Size(146, 27);
            colorTextBox.TabIndex = 6;
            colorTextBox.TextChanged += colorTextBox_TextChanged_1;
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new Point(169, 132);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(48, 20);
            colorLabel.TabIndex = 5;
            colorLabel.Text = "Color:";
            // 
            // widhtTextBox
            // 
            widhtTextBox.Location = new Point(169, 102);
            widhtTextBox.Name = "widhtTextBox";
            widhtTextBox.Size = new Size(146, 27);
            widhtTextBox.TabIndex = 4;
            widhtTextBox.TextChanged += widhtTextBox_TextChanged;
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Location = new Point(169, 79);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new Size(52, 20);
            widthLabel.TabIndex = 3;
            widthLabel.Text = "Width:";
            // 
            // lenghtTextBox
            // 
            lenghtTextBox.Location = new Point(169, 49);
            lenghtTextBox.Name = "lenghtTextBox";
            lenghtTextBox.Size = new Size(146, 27);
            lenghtTextBox.TabIndex = 2;
            lenghtTextBox.TextChanged += lenghtTextBox_TextChanged;
            // 
            // lenghtLabel
            // 
            lenghtLabel.AutoSize = true;
            lenghtLabel.Location = new Point(169, 26);
            lenghtLabel.Name = "lenghtLabel";
            lenghtLabel.Size = new Size(57, 20);
            lenghtLabel.TabIndex = 1;
            lenghtLabel.Text = "Lenght:";
            // 
            // rectanglesTabPage
            // 
            rectanglesTabPage.Controls.Add(CanvasPanel);
            rectanglesTabPage.Controls.Add(lenghtRectangleLabel);
            rectanglesTabPage.Controls.Add(WidhtRectangleLabel);
            rectanglesTabPage.Controls.Add(YRectangleLabel);
            rectanglesTabPage.Controls.Add(XRectangleLabel);
            rectanglesTabPage.Controls.Add(IdRectangleLabel);
            rectanglesTabPage.Controls.Add(LenghtPanelTextBox);
            rectanglesTabPage.Controls.Add(WidhtPanelTextBox);
            rectanglesTabPage.Controls.Add(YPanelTextBox);
            rectanglesTabPage.Controls.Add(XPanelTextBox);
            rectanglesTabPage.Controls.Add(IdPanelTextBox);
            rectanglesTabPage.Controls.Add(selectedRectangleLabel);
            rectanglesTabPage.Controls.Add(flatAddButton);
            rectanglesTabPage.Controls.Add(flatDeleteButton);
            rectanglesTabPage.Controls.Add(rectanglesPanelListBox);
            rectanglesTabPage.Controls.Add(rectanglesLabel);
            rectanglesTabPage.Location = new Point(4, 29);
            rectanglesTabPage.Name = "rectanglesTabPage";
            rectanglesTabPage.Size = new Size(792, 417);
            rectanglesTabPage.TabIndex = 2;
            rectanglesTabPage.Text = "Rectangles";
            rectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // CanvasPanel
            // 
            CanvasPanel.BorderStyle = BorderStyle.FixedSingle;
            CanvasPanel.Location = new Point(329, 3);
            CanvasPanel.Name = "CanvasPanel";
            CanvasPanel.Size = new Size(460, 411);
            CanvasPanel.TabIndex = 15;
            CanvasPanel.Paint += RectanglePanel_Paint;
            // 
            // lenghtRectangleLabel
            // 
            lenghtRectangleLabel.AutoSize = true;
            lenghtRectangleLabel.Location = new Point(35, 390);
            lenghtRectangleLabel.Name = "lenghtRectangleLabel";
            lenghtRectangleLabel.Size = new Size(57, 20);
            lenghtRectangleLabel.TabIndex = 14;
            lenghtRectangleLabel.Text = "Height:";
            // 
            // WidhtRectangleLabel
            // 
            WidhtRectangleLabel.AutoSize = true;
            WidhtRectangleLabel.Location = new Point(40, 357);
            WidhtRectangleLabel.Name = "WidhtRectangleLabel";
            WidhtRectangleLabel.Size = new Size(52, 20);
            WidhtRectangleLabel.TabIndex = 13;
            WidhtRectangleLabel.Text = "Widht:";
            // 
            // YRectangleLabel
            // 
            YRectangleLabel.AutoSize = true;
            YRectangleLabel.Location = new Point(72, 324);
            YRectangleLabel.Name = "YRectangleLabel";
            YRectangleLabel.Size = new Size(20, 20);
            YRectangleLabel.TabIndex = 12;
            YRectangleLabel.Text = "Y:";
            // 
            // XRectangleLabel
            // 
            XRectangleLabel.AutoSize = true;
            XRectangleLabel.Location = new Point(71, 291);
            XRectangleLabel.Name = "XRectangleLabel";
            XRectangleLabel.Size = new Size(21, 20);
            XRectangleLabel.TabIndex = 11;
            XRectangleLabel.Text = "X:";
            // 
            // IdRectangleLabel
            // 
            IdRectangleLabel.AutoSize = true;
            IdRectangleLabel.Location = new Point(67, 258);
            IdRectangleLabel.Name = "IdRectangleLabel";
            IdRectangleLabel.Size = new Size(25, 20);
            IdRectangleLabel.TabIndex = 10;
            IdRectangleLabel.Text = "Id:";
            IdRectangleLabel.Click += IdRectangleLabel_Click;
            // 
            // LenghtPanelTextBox
            // 
            LenghtPanelTextBox.Location = new Point(98, 387);
            LenghtPanelTextBox.Name = "LenghtPanelTextBox";
            LenghtPanelTextBox.Size = new Size(125, 27);
            LenghtPanelTextBox.TabIndex = 9;
            LenghtPanelTextBox.TextChanged += LenghtPanelTextBox_TextChanged;
            // 
            // WidhtPanelTextBox
            // 
            WidhtPanelTextBox.Location = new Point(98, 354);
            WidhtPanelTextBox.Name = "WidhtPanelTextBox";
            WidhtPanelTextBox.Size = new Size(125, 27);
            WidhtPanelTextBox.TabIndex = 8;
            WidhtPanelTextBox.TextChanged += WidhtPanelTextBox_TextChanged;
            // 
            // YPanelTextBox
            // 
            YPanelTextBox.Location = new Point(98, 321);
            YPanelTextBox.Name = "YPanelTextBox";
            YPanelTextBox.Size = new Size(125, 27);
            YPanelTextBox.TabIndex = 7;
            YPanelTextBox.TextChanged += YPanelTextBox_TextChanged;
            // 
            // XPanelTextBox
            // 
            XPanelTextBox.Location = new Point(98, 288);
            XPanelTextBox.Name = "XPanelTextBox";
            XPanelTextBox.Size = new Size(125, 27);
            XPanelTextBox.TabIndex = 6;
            XPanelTextBox.TextChanged += XPanelTextBox_TextChanged;
            // 
            // IdPanelTextBox
            // 
            IdPanelTextBox.Location = new Point(98, 255);
            IdPanelTextBox.Name = "IdPanelTextBox";
            IdPanelTextBox.ReadOnly = true;
            IdPanelTextBox.Size = new Size(125, 27);
            IdPanelTextBox.TabIndex = 5;
            // 
            // selectedRectangleLabel
            // 
            selectedRectangleLabel.AutoSize = true;
            selectedRectangleLabel.Location = new Point(8, 232);
            selectedRectangleLabel.Name = "selectedRectangleLabel";
            selectedRectangleLabel.Size = new Size(135, 20);
            selectedRectangleLabel.TabIndex = 4;
            selectedRectangleLabel.Text = "Selected rectangle:";
            // 
            // flatAddButton
            // 
            flatAddButton.ImageLocation = "C:\\Users\\nikita\\source\\repos\\Programming\\Programming\\Programming\\Model\\Resources\\add_icon.png";
            flatAddButton.Location = new Point(177, 204);
            flatAddButton.Name = "flatAddButton";
            flatAddButton.Size = new Size(24, 26);
            flatAddButton.TabIndex = 3;
            flatAddButton.TabStop = false;
            flatAddButton.Click += flatAddButton_Click;
            // 
            // flatDeleteButton
            // 
            flatDeleteButton.ImageLocation = "C:\\Users\\nikita\\source\\repos\\Programming\\Programming\\Programming\\Model\\Resources\\delete_icon.png";
            flatDeleteButton.Location = new Point(207, 204);
            flatDeleteButton.Name = "flatDeleteButton";
            flatDeleteButton.Size = new Size(25, 27);
            flatDeleteButton.TabIndex = 2;
            flatDeleteButton.TabStop = false;
            flatDeleteButton.Click += flatDeleteButton_Click;
            // 
            // rectanglesPanelListBox
            // 
            rectanglesPanelListBox.FormattingEnabled = true;
            rectanglesPanelListBox.ItemHeight = 20;
            rectanglesPanelListBox.Location = new Point(8, 40);
            rectanglesPanelListBox.Name = "rectanglesPanelListBox";
            rectanglesPanelListBox.Size = new Size(315, 144);
            rectanglesPanelListBox.TabIndex = 1;
            rectanglesPanelListBox.SelectedIndexChanged += rectanglesPanelListBox_SelectedIndexChanged;
            // 
            // rectanglesLabel
            // 
            rectanglesLabel.AutoSize = true;
            rectanglesLabel.Location = new Point(8, 17);
            rectanglesLabel.Name = "rectanglesLabel";
            rectanglesLabel.Size = new Size(84, 20);
            rectanglesLabel.TabIndex = 0;
            rectanglesLabel.Text = "Rectangles:";
            // 
            // mainFormBindingSource1
            // 
            mainFormBindingSource1.DataSource = typeof(MainForm);
            // 
            // mainFormBindingSource
            // 
            mainFormBindingSource.DataSource = typeof(MainForm);
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
            enumsTabPage.PerformLayout();
            seasonGroupBox.ResumeLayout(false);
            seasonGroupBox.PerformLayout();
            parsingGroupBox.ResumeLayout(false);
            parsingGroupBox.PerformLayout();
            enumerationGroupBox.ResumeLayout(false);
            enumerationGroupBox.PerformLayout();
            classesTabPage.ResumeLayout(false);
            moviesGroupBox.ResumeLayout(false);
            moviesGroupBox.PerformLayout();
            rectanglesGroupBox.ResumeLayout(false);
            rectanglesGroupBox.PerformLayout();
            rectanglesTabPage.ResumeLayout(false);
            rectanglesTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)flatAddButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)flatDeleteButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainFormBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainFormBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage enumsTabPage;
        private GroupBox enumerationGroupBox;
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
        private GroupBox rectanglesGroupBox;
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
        private TextBox LenghtPanelTextBox;
        private TextBox WidhtPanelTextBox;
        private TextBox YPanelTextBox;
        private TextBox XPanelTextBox;
        private TextBox IdPanelTextBox;
        private Label selectedRectangleLabel;
        private PictureBox flatAddButton;
        private PictureBox flatDeleteButton;
        private ListBox rectanglesPanelListBox;
        private Label rectanglesLabel;
        private Label lenghtRectangleLabel;
        private Label WidhtRectangleLabel;
        private Label YRectangleLabel;
        private Label XRectangleLabel;
        private Label IdRectangleLabel;
        private Panel CanvasPanel;
    }
}