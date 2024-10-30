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
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonsTableLayoutPanel = new TableLayoutPanel();
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
            tableLayoutPanel1.SuspendLayout();
            buttonsTableLayoutPanel.SuspendLayout();
            selectedItemGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // itemsGroupBox
            // 
            itemsGroupBox.Controls.Add(tableLayoutPanel1);
            itemsGroupBox.Dock = DockStyle.Left;
            itemsGroupBox.Location = new Point(0, 0);
            itemsGroupBox.Name = "itemsGroupBox";
            itemsGroupBox.Size = new Size(324, 417);
            itemsGroupBox.TabIndex = 0;
            itemsGroupBox.TabStop = false;
            itemsGroupBox.Text = "Items";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(buttonsTableLayoutPanel, 0, 1);
            tableLayoutPanel1.Controls.Add(itemsListBox, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(3, 23);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(318, 391);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonsTableLayoutPanel
            // 
            buttonsTableLayoutPanel.ColumnCount = 3;
            buttonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            buttonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            buttonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            buttonsTableLayoutPanel.Controls.Add(deleteButton, 1, 0);
            buttonsTableLayoutPanel.Controls.Add(addButton, 0, 0);
            buttonsTableLayoutPanel.Dock = DockStyle.Top;
            buttonsTableLayoutPanel.Location = new Point(3, 313);
            buttonsTableLayoutPanel.Name = "buttonsTableLayoutPanel";
            buttonsTableLayoutPanel.RowCount = 1;
            buttonsTableLayoutPanel.RowStyles.Add(new RowStyle());
            buttonsTableLayoutPanel.Size = new Size(312, 75);
            buttonsTableLayoutPanel.TabIndex = 1;
            // 
            // deleteButton
            // 
            deleteButton.Dock = DockStyle.Fill;
            deleteButton.Location = new Point(107, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(98, 72);
            deleteButton.TabIndex = 0;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // addButton
            // 
            addButton.Dock = DockStyle.Fill;
            addButton.Location = new Point(3, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(98, 72);
            addButton.TabIndex = 0;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // itemsListBox
            // 
            itemsListBox.Dock = DockStyle.Top;
            itemsListBox.FormattingEnabled = true;
            itemsListBox.Location = new Point(3, 3);
            itemsListBox.Name = "itemsListBox";
            itemsListBox.Size = new Size(312, 304);
            itemsListBox.TabIndex = 0;
            itemsListBox.SelectedIndexChanged += itemsListBox_SelectedIndexChanged;
            // 
            // selectedItemGroupBox
            // 
            selectedItemGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            selectedItemGroupBox.Size = new Size(468, 417);
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
            descriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            descriptionTextBox.Location = new Point(6, 299);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(456, 112);
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
            Size = new Size(792, 417);
            itemsGroupBox.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            buttonsTableLayoutPanel.ResumeLayout(false);
            selectedItemGroupBox.ResumeLayout(false);
            selectedItemGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox itemsGroupBox;
        private GroupBox selectedItemGroupBox;
        private TableLayoutPanel buttonsTableLayoutPanel;
        private ListBox itemsListBox;
        private Button deleteButton;
        private Button addButton;
        private TextBox idTextBox;
        private Label costLabel;
        private Label idLabel;
        private TextBox costTextBox;
        private TextBox descriptionTextBox;
        private Label descriptionLabel;
        private TextBox nameTextBox;
        private Label nameLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private Label categoryLabel;
        public ComboBox categoryComboBox;
    }
}
