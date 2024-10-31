namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            Model.Address address1 = new Model.Address();
            dataGridView = new DataGridView();
            IdColumn = new DataGridViewTextBoxColumn();
            DateColumn = new DataGridViewTextBoxColumn();
            FullnameColumn = new DataGridViewTextBoxColumn();
            AddressColumn = new DataGridViewTextBoxColumn();
            CostColumn = new DataGridViewTextBoxColumn();
            StatusColumn = new DataGridViewTextBoxColumn();
            addressControl1 = new Controls.AddressControl();
            groupBox = new GroupBox();
            statusComboBox = new ComboBox();
            createdTextBox = new TextBox();
            idTextBox = new TextBox();
            statusLabel = new Label();
            createdLabel = new Label();
            idLabel = new Label();
            itemsListBox = new ListBox();
            amountLabel = new Label();
            amountTextLabel = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            priorityGroupBox = new GroupBox();
            deliveryDateLabel = new Label();
            deliveryTimeLabel = new Label();
            deliveryDatePicker = new DateTimePicker();
            deliveryTimeComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox.SuspendLayout();
            priorityGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { IdColumn, DateColumn, FullnameColumn, AddressColumn, CostColumn, StatusColumn });
            dataGridView.Location = new Point(3, 3);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(647, 679);
            dataGridView.TabIndex = 0;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // IdColumn
            // 
            IdColumn.HeaderText = "Id заказа";
            IdColumn.MinimumWidth = 6;
            IdColumn.Name = "IdColumn";
            IdColumn.ReadOnly = true;
            IdColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            IdColumn.Width = 125;
            // 
            // DateColumn
            // 
            DateColumn.HeaderText = "Дата создания";
            DateColumn.MinimumWidth = 6;
            DateColumn.Name = "DateColumn";
            DateColumn.ReadOnly = true;
            DateColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            DateColumn.Width = 125;
            // 
            // FullnameColumn
            // 
            FullnameColumn.HeaderText = "ФИО покупателя";
            FullnameColumn.MinimumWidth = 6;
            FullnameColumn.Name = "FullnameColumn";
            FullnameColumn.ReadOnly = true;
            FullnameColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            FullnameColumn.Width = 125;
            // 
            // AddressColumn
            // 
            AddressColumn.HeaderText = "Адрес доставки";
            AddressColumn.MinimumWidth = 6;
            AddressColumn.Name = "AddressColumn";
            AddressColumn.ReadOnly = true;
            AddressColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            AddressColumn.Width = 125;
            // 
            // CostColumn
            // 
            CostColumn.HeaderText = "Общая стоимость";
            CostColumn.MinimumWidth = 6;
            CostColumn.Name = "CostColumn";
            CostColumn.ReadOnly = true;
            CostColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            CostColumn.Width = 125;
            // 
            // StatusColumn
            // 
            StatusColumn.HeaderText = "Статус";
            StatusColumn.MinimumWidth = 6;
            StatusColumn.Name = "StatusColumn";
            StatusColumn.ReadOnly = true;
            StatusColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            StatusColumn.Width = 125;
            // 
            // addressControl1
            // 
            address1.Apartament = "None";
            address1.Building = "None";
            address1.City = "None";
            address1.Country = "None";
            address1.Index = 123456;
            address1.Street = "None";
            addressControl1.Address = address1;
            addressControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addressControl1.Enabled = false;
            addressControl1.Location = new Point(656, 142);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(661, 162);
            addressControl1.TabIndex = 1;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(statusComboBox);
            groupBox.Controls.Add(createdTextBox);
            groupBox.Controls.Add(idTextBox);
            groupBox.Controls.Add(statusLabel);
            groupBox.Controls.Add(createdLabel);
            groupBox.Controls.Add(idLabel);
            groupBox.Location = new Point(656, 3);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(255, 133);
            groupBox.TabIndex = 2;
            groupBox.TabStop = false;
            groupBox.Text = "Selected Order";
            // 
            // statusComboBox
            // 
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(86, 96);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(163, 28);
            statusComboBox.TabIndex = 5;
            statusComboBox.SelectedIndexChanged += statusTextBox_SelectedIndexChanged;
            // 
            // createdTextBox
            // 
            createdTextBox.Location = new Point(86, 60);
            createdTextBox.Name = "createdTextBox";
            createdTextBox.ReadOnly = true;
            createdTextBox.Size = new Size(163, 27);
            createdTextBox.TabIndex = 4;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(86, 26);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(163, 27);
            idTextBox.TabIndex = 3;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(6, 99);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(52, 20);
            statusLabel.TabIndex = 2;
            statusLabel.Text = "Status:";
            // 
            // createdLabel
            // 
            createdLabel.AutoSize = true;
            createdLabel.Location = new Point(6, 63);
            createdLabel.Name = "createdLabel";
            createdLabel.Size = new Size(64, 20);
            createdLabel.TabIndex = 1;
            createdLabel.Text = "Created:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(6, 29);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(27, 20);
            idLabel.TabIndex = 0;
            idLabel.Text = "ID:";
            // 
            // itemsListBox
            // 
            itemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            itemsListBox.Enabled = false;
            itemsListBox.FormattingEnabled = true;
            itemsListBox.Location = new Point(656, 310);
            itemsListBox.Name = "itemsListBox";
            itemsListBox.Size = new Size(661, 264);
            itemsListBox.TabIndex = 3;
            // 
            // amountLabel
            // 
            amountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Swis721 Blk BT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amountLabel.ImageAlign = ContentAlignment.TopLeft;
            amountLabel.Location = new Point(1268, 603);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(35, 36);
            amountLabel.TabIndex = 10;
            amountLabel.Text = "0";
            amountLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // amountTextLabel
            // 
            amountTextLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            amountTextLabel.AutoSize = true;
            amountTextLabel.Font = new Font("Swis721 Hv BT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amountTextLabel.Location = new Point(1211, 577);
            amountTextLabel.Name = "amountTextLabel";
            amountTextLabel.Size = new Size(106, 27);
            amountTextLabel.TabIndex = 9;
            amountTextLabel.Text = "Amount:";
            // 
            // priorityGroupBox
            // 
            priorityGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            priorityGroupBox.Controls.Add(deliveryDateLabel);
            priorityGroupBox.Controls.Add(deliveryTimeLabel);
            priorityGroupBox.Controls.Add(deliveryDatePicker);
            priorityGroupBox.Controls.Add(deliveryTimeComboBox);
            priorityGroupBox.Location = new Point(917, 11);
            priorityGroupBox.Name = "priorityGroupBox";
            priorityGroupBox.Size = new Size(400, 125);
            priorityGroupBox.TabIndex = 11;
            priorityGroupBox.TabStop = false;
            priorityGroupBox.Text = "Priority options";
            priorityGroupBox.Visible = false;
            // 
            // deliveryDateLabel
            // 
            deliveryDateLabel.AutoSize = true;
            deliveryDateLabel.Location = new Point(6, 74);
            deliveryDateLabel.Name = "deliveryDateLabel";
            deliveryDateLabel.Size = new Size(100, 20);
            deliveryDateLabel.TabIndex = 3;
            deliveryDateLabel.Text = "Delivery date:";
            // 
            // deliveryTimeLabel
            // 
            deliveryTimeLabel.AutoSize = true;
            deliveryTimeLabel.Location = new Point(6, 29);
            deliveryTimeLabel.Name = "deliveryTimeLabel";
            deliveryTimeLabel.Size = new Size(100, 20);
            deliveryTimeLabel.TabIndex = 2;
            deliveryTimeLabel.Text = "Delivery time:";
            // 
            // deliveryDatePicker
            // 
            deliveryDatePicker.Location = new Point(112, 69);
            deliveryDatePicker.Name = "deliveryDatePicker";
            deliveryDatePicker.Size = new Size(282, 27);
            deliveryDatePicker.TabIndex = 1;
            deliveryDatePicker.ValueChanged += deliveryDatePicker_ValueChanged;
            // 
            // deliveryTimeComboBox
            // 
            deliveryTimeComboBox.FormattingEnabled = true;
            deliveryTimeComboBox.Location = new Point(112, 26);
            deliveryTimeComboBox.Name = "deliveryTimeComboBox";
            deliveryTimeComboBox.Size = new Size(282, 28);
            deliveryTimeComboBox.TabIndex = 0;
            deliveryTimeComboBox.SelectedIndexChanged += deliveryTimeComboBox_SelectedIndexChanged;
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(priorityGroupBox);
            Controls.Add(amountLabel);
            Controls.Add(amountTextLabel);
            Controls.Add(itemsListBox);
            Controls.Add(groupBox);
            Controls.Add(addressControl1);
            Controls.Add(dataGridView);
            Name = "OrdersTab";
            Size = new Size(1320, 685);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            priorityGroupBox.ResumeLayout(false);
            priorityGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Controls.AddressControl addressControl1;
        private GroupBox groupBox;
        private ComboBox statusComboBox;
        private TextBox createdTextBox;
        private TextBox idTextBox;
        private Label statusLabel;
        private Label createdLabel;
        private Label idLabel;
        private ListBox itemsListBox;
        private Label amountLabel;
        private Label amountTextLabel;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn DateColumn;
        private DataGridViewTextBoxColumn FullnameColumn;
        private DataGridViewTextBoxColumn AddressColumn;
        private DataGridViewTextBoxColumn CostColumn;
        private DataGridViewTextBoxColumn StatusColumn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox priorityGroupBox;
        private Label deliveryDateLabel;
        private Label deliveryTimeLabel;
        private DateTimePicker deliveryDatePicker;
        private ComboBox deliveryTimeComboBox;
    }
}
