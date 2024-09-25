namespace Lab8
{
    partial class CityBuildingsControl
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
            nameListBox = new ListBox();
            typeLabel = new Label();
            nameLabel = new Label();
            addressLabel = new Label();
            rateLabel = new Label();
            addressTextBox = new TextBox();
            rateTextBox = new TextBox();
            typeComboBox = new ComboBox();
            addButton = new Button();
            deleteButton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            renameLabel = new Label();
            renameTextBox = new TextBox();
            sortButton = new Button();
            SuspendLayout();
            // 
            // nameListBox
            // 
            nameListBox.FormattingEnabled = true;
            nameListBox.Location = new Point(3, 23);
            nameListBox.Name = "nameListBox";
            nameListBox.Size = new Size(250, 264);
            nameListBox.TabIndex = 0;
            nameListBox.SelectedIndexChanged += nameListBox_SelectedIndexChanged;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new Point(259, 0);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(43, 20);
            typeLabel.TabIndex = 2;
            typeLabel.Text = "Type:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(3, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(52, 20);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(259, 53);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(65, 20);
            addressLabel.TabIndex = 5;
            addressLabel.Text = "Address:";
            // 
            // rateLabel
            // 
            rateLabel.AutoSize = true;
            rateLabel.Location = new Point(259, 106);
            rateLabel.Name = "rateLabel";
            rateLabel.Size = new Size(42, 20);
            rateLabel.TabIndex = 6;
            rateLabel.Text = "Rate:";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(259, 76);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(206, 27);
            addressTextBox.TabIndex = 7;
            addressTextBox.TextChanged += addressTextBox_TextChanged;
            // 
            // rateTextBox
            // 
            rateTextBox.Location = new Point(259, 129);
            rateTextBox.Name = "rateTextBox";
            rateTextBox.Size = new Size(206, 27);
            rateTextBox.TabIndex = 8;
            rateTextBox.TextChanged += rateTextBox_TextChanged;
            // 
            // typeComboBox
            // 
            typeComboBox.FormattingEnabled = true;
            typeComboBox.Location = new Point(259, 23);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(206, 28);
            typeComboBox.TabIndex = 9;
            typeComboBox.SelectedIndexChanged += typeComboBox_SelectedIndexChanged;
            // 
            // addButton
            // 
            addButton.Location = new Point(3, 293);
            addButton.Name = "addButton";
            addButton.Size = new Size(125, 29);
            addButton.TabIndex = 10;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(128, 293);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(125, 29);
            deleteButton.TabIndex = 11;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // renameLabel
            // 
            renameLabel.AutoSize = true;
            renameLabel.Location = new Point(259, 159);
            renameLabel.Name = "renameLabel";
            renameLabel.Size = new Size(66, 20);
            renameLabel.TabIndex = 12;
            renameLabel.Text = "Rename:";
            // 
            // renameTextBox
            // 
            renameTextBox.Location = new Point(259, 182);
            renameTextBox.Name = "renameTextBox";
            renameTextBox.Size = new Size(206, 27);
            renameTextBox.TabIndex = 13;
            renameTextBox.TextChanged += renameTextBox_TextChanged;
            // 
            // sortButton
            // 
            sortButton.Location = new Point(259, 215);
            sortButton.Name = "sortButton";
            sortButton.Size = new Size(94, 29);
            sortButton.TabIndex = 14;
            sortButton.Text = "Sort";
            sortButton.UseVisualStyleBackColor = true;
            sortButton.Click += sortButton_Click;
            // 
            // CityBuildingsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(sortButton);
            Controls.Add(renameTextBox);
            Controls.Add(renameLabel);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(typeComboBox);
            Controls.Add(rateTextBox);
            Controls.Add(addressTextBox);
            Controls.Add(rateLabel);
            Controls.Add(addressLabel);
            Controls.Add(nameLabel);
            Controls.Add(typeLabel);
            Controls.Add(nameListBox);
            Name = "CityBuildingsControl";
            Size = new Size(468, 325);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox nameListBox;
        private Label typeLabel;
        private Label nameLabel;
        private Label addressLabel;
        private Label rateLabel;
        private TextBox addressTextBox;
        private TextBox rateTextBox;
        private ComboBox typeComboBox;
        private Button addButton;
        private Button deleteButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label renameLabel;
        private TextBox renameTextBox;
        private Button sortButton;
    }
}
