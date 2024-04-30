namespace Programming.Panels
{
    partial class WeekdayControl
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
            parsedLabel = new Label();
            parsingButton = new Button();
            parsingTextBox = new TextBox();
            weekdayParsingLabel = new Label();
            SuspendLayout();
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
            // WeekdayControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(parsedLabel);
            Controls.Add(parsingButton);
            Controls.Add(parsingTextBox);
            Controls.Add(weekdayParsingLabel);
            Name = "WeekdayControl";
            Size = new Size(368, 124);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label parsedLabel;
        private Button parsingButton;
        private TextBox parsingTextBox;
        private Label weekdayParsingLabel;
    }
}
