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
            mainFormBindingSource = new BindingSource(components);
            tabControl1.SuspendLayout();
            enumsTabPage.SuspendLayout();
            seasonGroupBox.SuspendLayout();
            parsingGroupBox.SuspendLayout();
            enumerationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainFormBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(enumsTabPage);
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
    }
}