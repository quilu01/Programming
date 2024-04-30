namespace Programming.Panels
{
    partial class EnumerationControl
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
            intValueLabel = new Label();
            ValueTextBox = new TextBox();
            valuesListBox = new ListBox();
            valueLabel = new Label();
            enumerationListBox = new ListBox();
            enumerationLabel = new Label();
            SuspendLayout();
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
            // 
            // EnumerationControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(intValueLabel);
            Controls.Add(ValueTextBox);
            Controls.Add(valuesListBox);
            Controls.Add(valueLabel);
            Controls.Add(enumerationListBox);
            Controls.Add(enumerationLabel);
            Name = "EnumerationControl";
            Size = new Size(455, 201);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label intValueLabel;
        private TextBox ValueTextBox;
        private ListBox valuesListBox;
        private Label valueLabel;
        private ListBox enumerationListBox;
        private Label enumerationLabel;
    }
}
