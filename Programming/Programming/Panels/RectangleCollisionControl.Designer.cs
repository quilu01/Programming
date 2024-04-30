namespace Programming
{
    partial class RectangleCollisionControl
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
            ((System.ComponentModel.ISupportInitialize)flatAddButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flatDeleteButton).BeginInit();
            SuspendLayout();
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
            // RectangleCollisionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CanvasPanel);
            Controls.Add(lenghtRectangleLabel);
            Controls.Add(WidhtRectangleLabel);
            Controls.Add(YRectangleLabel);
            Controls.Add(XRectangleLabel);
            Controls.Add(IdRectangleLabel);
            Controls.Add(LenghtPanelTextBox);
            Controls.Add(WidhtPanelTextBox);
            Controls.Add(YPanelTextBox);
            Controls.Add(XPanelTextBox);
            Controls.Add(IdPanelTextBox);
            Controls.Add(selectedRectangleLabel);
            Controls.Add(flatAddButton);
            Controls.Add(flatDeleteButton);
            Controls.Add(rectanglesPanelListBox);
            Controls.Add(rectanglesLabel);
            Name = "RectangleCollisionControl";
            Size = new Size(787, 425);
            ((System.ComponentModel.ISupportInitialize)flatAddButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)flatDeleteButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel CanvasPanel;
        private Label lenghtRectangleLabel;
        private Label WidhtRectangleLabel;
        private Label YRectangleLabel;
        private Label XRectangleLabel;
        private Label IdRectangleLabel;
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
    }
}
