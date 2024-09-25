﻿namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTabControl
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
            splitContainer1 = new SplitContainer();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            addButton = new Button();
            deleteButton = new Button();
            customersListBox = new ListBox();
            customersLabel = new Label();
            addressTextBox = new TextBox();
            fullnameTextBox = new TextBox();
            addressLabel = new Label();
            fullnameLabel = new Label();
            idTextBox = new TextBox();
            idLabel = new Label();
            selectedCustomerLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel2);
            splitContainer1.Panel1.Controls.Add(customersLabel);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(addressTextBox);
            splitContainer1.Panel2.Controls.Add(fullnameTextBox);
            splitContainer1.Panel2.Controls.Add(addressLabel);
            splitContainer1.Panel2.Controls.Add(fullnameLabel);
            splitContainer1.Panel2.Controls.Add(idTextBox);
            splitContainer1.Panel2.Controls.Add(idLabel);
            splitContainer1.Panel2.Controls.Add(selectedCustomerLabel);
            splitContainer1.Size = new Size(792, 417);
            splitContainer1.SplitterDistance = 330;
            splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Controls.Add(customersListBox, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 23);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 71F));
            tableLayoutPanel2.Size = new Size(321, 391);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(addButton, 0, 0);
            tableLayoutPanel3.Controls.Add(deleteButton, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Left;
            tableLayoutPanel3.Location = new Point(3, 313);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(312, 75);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.Dock = DockStyle.Fill;
            addButton.Location = new Point(3, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(98, 69);
            addButton.TabIndex = 0;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Dock = DockStyle.Fill;
            deleteButton.Location = new Point(107, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(98, 69);
            deleteButton.TabIndex = 0;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // customersListBox
            // 
            customersListBox.Dock = DockStyle.Left;
            customersListBox.FormattingEnabled = true;
            customersListBox.Location = new Point(3, 3);
            customersListBox.Name = "customersListBox";
            customersListBox.Size = new Size(312, 304);
            customersListBox.TabIndex = 1;
            customersListBox.SelectedIndexChanged += customersListBox_SelectedIndexChanged;
            // 
            // customersLabel
            // 
            customersLabel.AutoSize = true;
            customersLabel.Location = new Point(0, 0);
            customersLabel.Name = "customersLabel";
            customersLabel.Size = new Size(78, 20);
            customersLabel.TabIndex = 0;
            customersLabel.Text = "Customers";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(81, 102);
            addressTextBox.Multiline = true;
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(412, 225);
            addressTextBox.TabIndex = 6;
            addressTextBox.TextChanged += addressTextBox_TextChanged;
            // 
            // fullnameTextBox
            // 
            fullnameTextBox.Location = new Point(81, 69);
            fullnameTextBox.Name = "fullnameTextBox";
            fullnameTextBox.Size = new Size(412, 27);
            fullnameTextBox.TabIndex = 5;
            fullnameTextBox.TextChanged += fullnameTextBox_TextChanged;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(3, 105);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(65, 20);
            addressLabel.TabIndex = 4;
            addressLabel.Text = "Address:";
            // 
            // fullnameLabel
            // 
            fullnameLabel.AutoSize = true;
            fullnameLabel.Location = new Point(3, 72);
            fullnameLabel.Name = "fullnameLabel";
            fullnameLabel.Size = new Size(72, 20);
            fullnameLabel.TabIndex = 3;
            fullnameLabel.Text = "Fullname:";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(81, 36);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(412, 27);
            idTextBox.TabIndex = 2;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(3, 39);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(27, 20);
            idLabel.TabIndex = 1;
            idLabel.Text = "ID:";
            // 
            // selectedCustomerLabel
            // 
            selectedCustomerLabel.AutoSize = true;
            selectedCustomerLabel.Location = new Point(3, 0);
            selectedCustomerLabel.Name = "selectedCustomerLabel";
            selectedCustomerLabel.Size = new Size(133, 20);
            selectedCustomerLabel.TabIndex = 0;
            selectedCustomerLabel.Text = "Selected Customer";
            // 
            // CustomersTabControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "CustomersTabControl";
            Size = new Size(792, 417);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label customersLabel;
        private TableLayoutPanel tableLayoutPanel3;
        private Button addButton;
        private Button deleteButton;
        private ListBox customersListBox;
        private TextBox fullnameTextBox;
        private Label addressLabel;
        private Label fullnameLabel;
        private TextBox idTextBox;
        private Label idLabel;
        private Label selectedCustomerLabel;
        private TextBox addressTextBox;
    }
}