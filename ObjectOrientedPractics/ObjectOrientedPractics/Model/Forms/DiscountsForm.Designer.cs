namespace ObjectOrientedPractics.Model.Forms
{
    partial class DiscountsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            categoryComboBox = new ComboBox();
            percentDiscountLabel = new Label();
            categoryLabel = new Label();
            cancelButton = new Button();
            okButton = new Button();
            SuspendLayout();
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(110, 32);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(249, 28);
            categoryComboBox.TabIndex = 0;
            
            // 
            // percentDiscountLabel
            // 
            percentDiscountLabel.AutoSize = true;
            percentDiscountLabel.Location = new Point(12, 9);
            percentDiscountLabel.Name = "percentDiscountLabel";
            percentDiscountLabel.Size = new Size(120, 20);
            percentDiscountLabel.TabIndex = 1;
            percentDiscountLabel.Text = "Percent discount:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(12, 35);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(72, 20);
            categoryLabel.TabIndex = 2;
            categoryLabel.Text = "Category:";
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelButton.Location = new Point(265, 147);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // okButton
            // 
            okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okButton.Location = new Point(165, 147);
            okButton.Name = "okButton";
            okButton.Size = new Size(94, 29);
            okButton.TabIndex = 4;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // DiscountsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 188);
            Controls.Add(okButton);
            Controls.Add(cancelButton);
            Controls.Add(categoryLabel);
            Controls.Add(percentDiscountLabel);
            Controls.Add(categoryComboBox);
            Name = "DiscountsForm";
            Text = "DiscountsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox categoryComboBox;
        private Label percentDiscountLabel;
        private Label categoryLabel;
        private Button cancelButton;
        private Button okButton;
    }
}