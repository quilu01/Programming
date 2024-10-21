namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            addressGroupBox = new GroupBox();
            apartamentTextBox = new TextBox();
            buildingTextBox = new TextBox();
            streetTextBox = new TextBox();
            cityTextBox = new TextBox();
            countryTextBox = new TextBox();
            postIndexTextBox = new TextBox();
            apartamentLabel = new Label();
            buildingLabel = new Label();
            streetLabel = new Label();
            cityLabel = new Label();
            countryLabel = new Label();
            postIndexLabel = new Label();
            addressGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // addressGroupBox
            // 
            addressGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            addressGroupBox.Controls.Add(apartamentTextBox);
            addressGroupBox.Controls.Add(buildingTextBox);
            addressGroupBox.Controls.Add(streetTextBox);
            addressGroupBox.Controls.Add(cityTextBox);
            addressGroupBox.Controls.Add(countryTextBox);
            addressGroupBox.Controls.Add(postIndexTextBox);
            addressGroupBox.Controls.Add(apartamentLabel);
            addressGroupBox.Controls.Add(buildingLabel);
            addressGroupBox.Controls.Add(streetLabel);
            addressGroupBox.Controls.Add(cityLabel);
            addressGroupBox.Controls.Add(countryLabel);
            addressGroupBox.Controls.Add(postIndexLabel);
            addressGroupBox.Font = new Font("Segoe UI", 9F);
            addressGroupBox.Location = new Point(0, 0);
            addressGroupBox.Name = "addressGroupBox";
            addressGroupBox.Size = new Size(530, 172);
            addressGroupBox.TabIndex = 0;
            addressGroupBox.TabStop = false;
            addressGroupBox.Text = "Delivery Address";
            // 
            // apartamentTextBox
            // 
            apartamentTextBox.Location = new Point(319, 125);
            apartamentTextBox.Name = "apartamentTextBox";
            apartamentTextBox.Size = new Size(125, 27);
            apartamentTextBox.TabIndex = 11;
            apartamentTextBox.TextChanged += apartamentTextBox_TextChanged;
            // 
            // buildingTextBox
            // 
            buildingTextBox.Location = new Point(91, 125);
            buildingTextBox.Name = "buildingTextBox";
            buildingTextBox.Size = new Size(125, 27);
            buildingTextBox.TabIndex = 10;
            buildingTextBox.TextChanged += buildingTextBox_TextChanged;
            // 
            // streetTextBox
            // 
            streetTextBox.Location = new Point(91, 92);
            streetTextBox.Name = "streetTextBox";
            streetTextBox.Size = new Size(427, 27);
            streetTextBox.TabIndex = 9;
            streetTextBox.TextChanged += streetTextBox_TextChanged;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(329, 62);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(189, 27);
            cityTextBox.TabIndex = 8;
            cityTextBox.TextChanged += cityTextBox_TextChanged;
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(91, 59);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(189, 27);
            countryTextBox.TabIndex = 7;
            countryTextBox.TextChanged += countryTextBox_TextChanged;
            // 
            // postIndexTextBox
            // 
            postIndexTextBox.Location = new Point(91, 26);
            postIndexTextBox.Name = "postIndexTextBox";
            postIndexTextBox.Size = new Size(125, 27);
            postIndexTextBox.TabIndex = 6;
            postIndexTextBox.TextChanged += postIndexTextBox_TextChanged;
            // 
            // apartamentLabel
            // 
            apartamentLabel.AutoSize = true;
            apartamentLabel.Location = new Point(222, 128);
            apartamentLabel.Name = "apartamentLabel";
            apartamentLabel.Size = new Size(91, 20);
            apartamentLabel.TabIndex = 5;
            apartamentLabel.Text = "Apartament:";
            // 
            // buildingLabel
            // 
            buildingLabel.AutoSize = true;
            buildingLabel.Location = new Point(6, 128);
            buildingLabel.Name = "buildingLabel";
            buildingLabel.Size = new Size(67, 20);
            buildingLabel.TabIndex = 4;
            buildingLabel.Text = "Building:";
            buildingLabel.Click += label1_Click;
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new Point(6, 95);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new Size(51, 20);
            streetLabel.TabIndex = 3;
            streetLabel.Text = "Street:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(286, 62);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(37, 20);
            cityLabel.TabIndex = 2;
            cityLabel.Text = "City:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new Font("Segoe UI", 9F);
            countryLabel.Location = new Point(6, 62);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(63, 20);
            countryLabel.TabIndex = 1;
            countryLabel.Text = "Country:";
            countryLabel.Click += countryLabel_Click;
            // 
            // postIndexLabel
            // 
            postIndexLabel.AutoSize = true;
            postIndexLabel.Font = new Font("Segoe UI", 9F);
            postIndexLabel.Location = new Point(6, 29);
            postIndexLabel.Name = "postIndexLabel";
            postIndexLabel.Size = new Size(79, 20);
            postIndexLabel.TabIndex = 0;
            postIndexLabel.Text = "Post index:";
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(addressGroupBox);
            Name = "AddressControl";
            Size = new Size(530, 172);
            addressGroupBox.ResumeLayout(false);
            addressGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox addressGroupBox;
        private Label postIndexLabel;
        private Label countryLabel;
        private Label buildingLabel;
        private Label streetLabel;
        private Label cityLabel;
        private TextBox countryTextBox;
        private TextBox postIndexTextBox;
        private Label apartamentLabel;
        private TextBox apartamentTextBox;
        private TextBox buildingTextBox;
        private TextBox streetTextBox;
        private TextBox cityTextBox;
    }
}
