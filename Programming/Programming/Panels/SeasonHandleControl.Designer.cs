namespace Programming.Panels
{
    partial class SeasonHandleControl
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
            seasonButton = new Button();
            seasonLabel = new Label();
            seasonComboBox = new ComboBox();
            SuspendLayout();
            
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
            // SeasonHandleControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(seasonButton);
            Controls.Add(seasonLabel);
            Controls.Add(seasonComboBox);
            Name = "SeasonHandleControl";
            Size = new Size(354, 138);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button seasonButton;
        private Label seasonLabel;
        private ComboBox seasonComboBox;
    }
}
