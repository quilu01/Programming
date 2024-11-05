namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            itemsGroupBox = new GroupBox();
            sortComboBox = new ComboBox();
            orderByLabel = new Label();
            findLabel = new Label();
            findTextBox = new TextBox();
            deleteButton = new Button();
            addButton = new Button();
            itemsListBox = new ListBox();
            selectedItemGroupBox = new GroupBox();
            categoryComboBox = new ComboBox();
            categoryLabel = new Label();
            descriptionTextBox = new TextBox();
            descriptionLabel = new Label();
            nameTextBox = new TextBox();
            nameLabel = new Label();
            costTextBox = new TextBox();
            idTextBox = new TextBox();
            costLabel = new Label();
            idLabel = new Label();
            itemsGroupBox.SuspendLayout();
            selectedItemGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // itemsGroupBox
            // 
            itemsGroupBox.Controls.Add(sortComboBox);
            itemsGroupBox.Controls.Add(orderByLabel);
            itemsGroupBox.Controls.Add(findLabel);
            itemsGroupBox.Controls.Add(findTextBox);
            itemsGroupBox.Controls.Add(deleteButton);
            itemsGroupBox.Controls.Add(addButton);
            itemsGroupBox.Controls.Add(itemsListBox);
            itemsGroupBox.Dock = DockStyle.Left;
            itemsGroupBox.Location = new Point(0, 0);
            itemsGroupBox.Name = "itemsGroupBox";
            itemsGroupBox.Size = new Size(324, 436);
            itemsGroupBox.TabIndex = 0;
            itemsGroupBox.TabStop = false;
            itemsGroupBox.Text = "Items";
            // 
            // sortComboBox
            // 
            sortComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            sortComboBox.FormattingEnabled = true;
            sortComboBox.Location = new Point(82, 369);
            sortComboBox.Name = "sortComboBox";
            sortComboBox.Size = new Size(236, 28);
            sortComboBox.TabIndex = 6;
            sortComboBox.SelectedIndexChanged += sortComboBox_SelectedIndexChanged;
            // 
            // orderByLabel
            // 
            orderByLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            orderByLabel.AutoSize = true;
            orderByLabel.Location = new Point(6, 372);
            orderByLabel.Name = "orderByLabel";
            orderByLabel.Size = new Size(70, 20);
            orderByLabel.TabIndex = 5;
            orderByLabel.Text = "Order by:";
            // 
            // findLabel
            // 
            findLabel.AutoSize = true;
            findLabel.Location = new Point(6, 40);
            findLabel.Name = "findLabel";
            findLabel.Size = new Size(40, 20);
            findLabel.TabIndex = 4;
            findLabel.Text = "Find:";
            // 
            // findTextBox
            // 
            findTextBox.Location = new Point(52, 38);
            findTextBox.Name = "findTextBox";
            findTextBox.Size = new Size(266, 27);
            findTextBox.TabIndex = 3;
            findTextBox.TextChanged += findTextBox_TextChanged;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            deleteButton.Location = new Point(106, 403);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addButton.Location = new Point(6, 403);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 1;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // itemsListBox
            // 
            itemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            itemsListBox.FormattingEnabled = true;
            itemsListBox.Location = new Point(6, 71);
            itemsListBox.Name = "itemsListBox";
            itemsListBox.Size = new Size(312, 284);
            itemsListBox.TabIndex = 0;
            itemsListBox.SelectedIndexChanged += itemsListBox_SelectedIndexChanged;
            // 
            // selectedItemGroupBox
            // 
            selectedItemGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            selectedItemGroupBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            selectedItemGroupBox.Controls.Add(categoryComboBox);
            selectedItemGroupBox.Controls.Add(categoryLabel);
            selectedItemGroupBox.Controls.Add(descriptionTextBox);
            selectedItemGroupBox.Controls.Add(descriptionLabel);
            selectedItemGroupBox.Controls.Add(nameTextBox);
            selectedItemGroupBox.Controls.Add(nameLabel);
            selectedItemGroupBox.Controls.Add(costTextBox);
            selectedItemGroupBox.Controls.Add(idTextBox);
            selectedItemGroupBox.Controls.Add(costLabel);
            selectedItemGroupBox.Controls.Add(idLabel);
            selectedItemGroupBox.Location = new Point(324, 0);
            selectedItemGroupBox.Name = "selectedItemGroupBox";
            selectedItemGroupBox.Size = new Size(468, 436);
            selectedItemGroupBox.TabIndex = 1;
            selectedItemGroupBox.TabStop = false;
            selectedItemGroupBox.Text = "Selected Item";
            selectedItemGroupBox.Enter += selectedItemGroupBox_Enter;
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(271, 33);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(151, 28);
            categoryComboBox.TabIndex = 9;
            categoryComboBox.SelectedIndexChanged += categoryComboBox_SelectedIndexChanged;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(193, 36);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(72, 20);
            categoryLabel.TabIndex = 8;
            categoryLabel.Text = "Category:";
            categoryLabel.Click += label1_Click;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            descriptionTextBox.Location = new Point(6, 299);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(456, 131);
            descriptionTextBox.TabIndex = 7;
            descriptionTextBox.TextChanged += descriptionTextBox_TextChanged;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(6, 276);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(88, 20);
            descriptionLabel.TabIndex = 6;
            descriptionLabel.Text = "Description:";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Location = new Point(6, 127);
            nameTextBox.Multiline = true;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(456, 142);
            nameTextBox.TabIndex = 5;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(6, 104);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(52, 20);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // costTextBox
            // 
            costTextBox.Location = new Point(62, 71);
            costTextBox.Name = "costTextBox";
            costTextBox.Size = new Size(125, 27);
            costTextBox.TabIndex = 3;
            costTextBox.TextChanged += costTextBox_TextChanged;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(62, 33);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(125, 27);
            idTextBox.TabIndex = 2;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new Point(6, 74);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(41, 20);
            costLabel.TabIndex = 1;
            costLabel.Text = "Cost:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(6, 36);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(27, 20);
            idLabel.TabIndex = 0;
            idLabel.Text = "ID:";
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(selectedItemGroupBox);
            Controls.Add(itemsGroupBox);
            Name = "ItemsTab";
            Size = new Size(792, 436);
            itemsGroupBox.ResumeLayout(false);
            itemsGroupBox.PerformLayout();
            selectedItemGroupBox.ResumeLayout(false);
            selectedItemGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox itemsGroupBox;
        private GroupBox selectedItemGroupBox;
        private TextBox idTextBox;
        private Label costLabel;
        private Label idLabel;
        private TextBox costTextBox;
        private TextBox descriptionTextBox;
        private Label descriptionLabel;
        private TextBox nameTextBox;
        private Label nameLabel;
        private Label categoryLabel;
        public ComboBox categoryComboBox;
        private Label findLabel;
        private TextBox findTextBox;
        private Button deleteButton;
        private Button addButton;
        private ListBox itemsListBox;
        private ComboBox sortComboBox;
        private Label orderByLabel;
    }
}
