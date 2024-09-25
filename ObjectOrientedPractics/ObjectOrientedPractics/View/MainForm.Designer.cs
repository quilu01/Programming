namespace ObjectOrientedPractics
{
    partial class MainForm : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            ItemsTab = new TabPage();
            itemsTab1 = new View.Tabs.ItemsTab();
            tabPage2 = new TabPage();
            customersTabControl1 = new View.Tabs.CustomersTabControl();
            tabControl1.SuspendLayout();
            ItemsTab.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(ItemsTab);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // ItemsTab
            // 
            ItemsTab.Controls.Add(itemsTab1);
            ItemsTab.Location = new Point(4, 29);
            ItemsTab.Name = "ItemsTab";
            ItemsTab.Padding = new Padding(3);
            ItemsTab.Size = new Size(792, 417);
            ItemsTab.TabIndex = 0;
            ItemsTab.Text = "tabPage1";
            ItemsTab.UseVisualStyleBackColor = true;
            ItemsTab.Click += tabPage1_Click;
            // 
            // itemsTab1
            // 
            itemsTab1.Dock = DockStyle.Fill;
            itemsTab1.Location = new Point(3, 3);
            itemsTab1.Name = "itemsTab1";
            itemsTab1.Size = new Size(786, 411);
            itemsTab1.TabIndex = 0;
            itemsTab1.Load += itemsTab1_Load;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(customersTabControl1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 417);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // customersTabControl1
            // 
            customersTabControl1.Dock = DockStyle.Fill;
            customersTabControl1.Location = new Point(3, 3);
            customersTabControl1.Name = "customersTabControl1";
            customersTabControl1.Size = new Size(786, 411);
            customersTabControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            ItemsTab.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage ItemsTab;
        private TabPage tabPage2;
        private View.Tabs.ItemsTab itemsTab1;
        private View.Tabs.CustomersTabControl customersTabControl1;
    }
}
