namespace Programming.Panels
{
    partial class RectanglesListControl
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
            SuspendLayout();
            
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
            // RectanglesListControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(idTextBox);
            Controls.Add(idLabel);
            Controls.Add(centerYTextBox);
            Controls.Add(centerYLabel);
            Controls.Add(centerXTextBox);
            Controls.Add(centerXLabel);
            Controls.Add(rectangleFindButton);
            Controls.Add(rectanglesListBox);
            Controls.Add(colorTextBox);
            Controls.Add(colorLabel);
            Controls.Add(widhtTextBox);
            Controls.Add(widthLabel);
            Controls.Add(lenghtTextBox);
            Controls.Add(lenghtLabel);
            Name = "RectanglesListControl";
            Size = new Size(355, 396);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox idTextBox;
        private Label idLabel;
        private TextBox centerYTextBox;
        private Label centerYLabel;
        private TextBox centerXTextBox;
        private Label centerXLabel;
        private Button rectangleFindButton;
        private ListBox rectanglesListBox;
        private TextBox colorTextBox;
        private Label colorLabel;
        private TextBox widhtTextBox;
        private Label widthLabel;
        private TextBox lenghtTextBox;
        private Label lenghtLabel;
    }
}
