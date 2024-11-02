namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            itemsListBox = new ListBox();
            customerLabel = new Label();
            groupBox = new GroupBox();
            totalLabel = new Label();
            totalTextLabel = new Label();
            discountAmountLabel = new Label();
            discountAmountTextLabel = new Label();
            discountsLabel = new Label();
            discountsCheckedListBox = new CheckedListBox();
            customerComboBox = new ComboBox();
            clearButton = new Button();
            removeButton = new Button();
            amountLabel = new Label();
            orderButton = new Button();
            amountTextLabel = new Label();
            cartListBox = new ListBox();
            cartLabel = new Label();
            addButton = new Button();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // itemsListBox
            // 
            itemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            itemsListBox.FormattingEnabled = true;
            itemsListBox.Location = new Point(6, 26);
            itemsListBox.Name = "itemsListBox";
            itemsListBox.Size = new Size(271, 584);
            itemsListBox.TabIndex = 0;
            itemsListBox.SelectedIndexChanged += itemsListBox_SelectedIndexChanged;
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.Location = new Point(283, 26);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new Size(75, 20);
            customerLabel.TabIndex = 1;
            customerLabel.Text = "Customer:";
            // 
            // groupBox
            // 
            groupBox.Controls.Add(totalLabel);
            groupBox.Controls.Add(totalTextLabel);
            groupBox.Controls.Add(discountAmountLabel);
            groupBox.Controls.Add(discountAmountTextLabel);
            groupBox.Controls.Add(discountsLabel);
            groupBox.Controls.Add(discountsCheckedListBox);
            groupBox.Controls.Add(customerComboBox);
            groupBox.Controls.Add(clearButton);
            groupBox.Controls.Add(removeButton);
            groupBox.Controls.Add(amountLabel);
            groupBox.Controls.Add(orderButton);
            groupBox.Controls.Add(amountTextLabel);
            groupBox.Controls.Add(cartListBox);
            groupBox.Controls.Add(cartLabel);
            groupBox.Controls.Add(addButton);
            groupBox.Controls.Add(itemsListBox);
            groupBox.Controls.Add(customerLabel);
            groupBox.Dock = DockStyle.Fill;
            groupBox.Location = new Point(0, 0);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(1062, 650);
            groupBox.TabIndex = 2;
            groupBox.TabStop = false;
            groupBox.Text = "Items";
            // 
            // totalLabel
            // 
            totalLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Swis721 Blk BT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalLabel.ImageAlign = ContentAlignment.TopLeft;
            totalLabel.Location = new Point(1001, 605);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(35, 36);
            totalLabel.TabIndex = 17;
            totalLabel.Text = "0";
            totalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // totalTextLabel
            // 
            totalTextLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            totalTextLabel.AutoSize = true;
            totalTextLabel.Font = new Font("Swis721 Blk BT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalTextLabel.Location = new Point(966, 578);
            totalTextLabel.Name = "totalTextLabel";
            totalTextLabel.Size = new Size(84, 27);
            totalTextLabel.TabIndex = 16;
            totalTextLabel.Text = "Total:";
            // 
            // discountAmountLabel
            // 
            discountAmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            discountAmountLabel.AutoSize = true;
            discountAmountLabel.Font = new Font("Swis721 Blk BT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            discountAmountLabel.ImageAlign = ContentAlignment.TopLeft;
            discountAmountLabel.Location = new Point(1001, 473);
            discountAmountLabel.Name = "discountAmountLabel";
            discountAmountLabel.Size = new Size(35, 36);
            discountAmountLabel.TabIndex = 15;
            discountAmountLabel.Text = "0";
            discountAmountLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // discountAmountTextLabel
            // 
            discountAmountTextLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            discountAmountTextLabel.AutoSize = true;
            discountAmountTextLabel.Font = new Font("Swis721 Blk BT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            discountAmountTextLabel.Location = new Point(813, 446);
            discountAmountTextLabel.Name = "discountAmountTextLabel";
            discountAmountTextLabel.Size = new Size(237, 27);
            discountAmountTextLabel.TabIndex = 14;
            discountAmountTextLabel.Text = "Discount amount:";
            // 
            // discountsLabel
            // 
            discountsLabel.AutoSize = true;
            discountsLabel.Location = new Point(283, 446);
            discountsLabel.Name = "discountsLabel";
            discountsLabel.Size = new Size(76, 20);
            discountsLabel.TabIndex = 13;
            discountsLabel.Text = "Discounts:";
            // 
            // discountsCheckedListBox
            // 
            discountsCheckedListBox.BackColor = SystemColors.Control;
            discountsCheckedListBox.BorderStyle = BorderStyle.None;
            discountsCheckedListBox.FormattingEnabled = true;
            discountsCheckedListBox.Location = new Point(283, 465);
            discountsCheckedListBox.Name = "discountsCheckedListBox";
            discountsCheckedListBox.Size = new Size(379, 176);
            discountsCheckedListBox.TabIndex = 12;
            discountsCheckedListBox.SelectedIndexChanged += discountsCheckedListBox_SelectedIndexChanged;
            // 
            // customerComboBox
            // 
            customerComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customerComboBox.FormattingEnabled = true;
            customerComboBox.Location = new Point(364, 23);
            customerComboBox.Name = "customerComboBox";
            customerComboBox.Size = new Size(692, 28);
            customerComboBox.TabIndex = 11;
            customerComboBox.SelectedIndexChanged += customerComboBox_SelectedIndexChanged;
            // 
            // clearButton
            // 
            clearButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            clearButton.Location = new Point(830, 414);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(107, 29);
            clearButton.TabIndex = 10;
            clearButton.Text = "Clear cart";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // removeButton
            // 
            removeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            removeButton.Location = new Point(943, 414);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(107, 29);
            removeButton.TabIndex = 9;
            removeButton.Text = "Remove item";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // amountLabel
            // 
            amountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Swis721 Blk BT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amountLabel.ImageAlign = ContentAlignment.TopLeft;
            amountLabel.Location = new Point(1001, 374);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(35, 36);
            amountLabel.TabIndex = 8;
            amountLabel.Text = "0";
            amountLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // orderButton
            // 
            orderButton.Location = new Point(283, 414);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(107, 29);
            orderButton.TabIndex = 7;
            orderButton.Text = "Create order";
            orderButton.UseVisualStyleBackColor = true;
            orderButton.Click += orderButton_Click;
            // 
            // amountTextLabel
            // 
            amountTextLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            amountTextLabel.AutoSize = true;
            amountTextLabel.Font = new Font("Swis721 Hv BT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amountTextLabel.Location = new Point(944, 348);
            amountTextLabel.Name = "amountTextLabel";
            amountTextLabel.Size = new Size(106, 27);
            amountTextLabel.TabIndex = 6;
            amountTextLabel.Text = "Amount:";
            // 
            // cartListBox
            // 
            cartListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cartListBox.FormattingEnabled = true;
            cartListBox.Location = new Point(283, 102);
            cartListBox.Name = "cartListBox";
            cartListBox.Size = new Size(767, 244);
            cartListBox.TabIndex = 5;
            // 
            // cartLabel
            // 
            cartLabel.AutoSize = true;
            cartLabel.Location = new Point(283, 79);
            cartLabel.Name = "cartLabel";
            cartLabel.Size = new Size(39, 20);
            cartLabel.TabIndex = 4;
            cartLabel.Text = "Cart:";
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addButton.Location = new Point(6, 612);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 2;
            addButton.Text = "Add to cart";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox);
            Name = "CartsTab";
            Size = new Size(1062, 650);
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox itemsListBox;
        private Label customerLabel;
        private GroupBox groupBox;
        private Label amountTextLabel;
        private ListBox cartListBox;
        private Label cartLabel;
        private Button addButton;
        private Label amountLabel;
        private Button orderButton;
        private Button removeButton;
        private Button clearButton;
        private ComboBox customerComboBox;
        private Label discountAmountLabel;
        private Label discountAmountTextLabel;
        private Label discountsLabel;
        private CheckedListBox discountsCheckedListBox;
        private Label totalLabel;
        private Label totalTextLabel;
    }
}
