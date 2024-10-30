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
            cartTab = new TabPage();
            cartsTab1 = new View.Tabs.CartsTab();
            customersTab = new TabPage();
            customersTabControl = new View.Tabs.CustomersTab();
            itemsTab = new TabPage();
            itemsTabControl = new View.Tabs.ItemsTab();
            tabControl1 = new TabControl();
            cartTab.SuspendLayout();
            customersTab.SuspendLayout();
            itemsTab.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // cartTab
            // 
            cartTab.Controls.Add(cartsTab1);
            cartTab.Location = new Point(4, 29);
            cartTab.Name = "cartTab";
            cartTab.Size = new Size(792, 417);
            cartTab.TabIndex = 2;
            cartTab.Text = "Cart";
            cartTab.UseVisualStyleBackColor = true;
            // 
            // cartsTab1
            // 
            cartsTab1.Customers = null;
            cartsTab1.Dock = DockStyle.Fill;
            cartsTab1.Items = null;
            cartsTab1.Location = new Point(0, 0);
            cartsTab1.Name = "cartsTab1";
            cartsTab1.Size = new Size(792, 417);
            cartsTab1.TabIndex = 0;
            // 
            // customersTab
            // 
            customersTab.Controls.Add(customersTabControl);
            customersTab.Location = new Point(4, 29);
            customersTab.Name = "customersTab";
            customersTab.Padding = new Padding(3);
            customersTab.Size = new Size(792, 417);
            customersTab.TabIndex = 1;
            customersTab.Text = "Customers";
            customersTab.UseVisualStyleBackColor = true;
            // 
            // customersTabControl
            // 
            customersTabControl.Customers = null;
            customersTabControl.Dock = DockStyle.Fill;
            customersTabControl.Location = new Point(3, 3);
            customersTabControl.Name = "customersTabControl";
            customersTabControl.Size = new Size(786, 411);
            customersTabControl.TabIndex = 0;
            // 
            // itemsTab
            // 
            itemsTab.Controls.Add(itemsTabControl);
            itemsTab.Location = new Point(4, 29);
            itemsTab.Name = "itemsTab";
            itemsTab.Padding = new Padding(3);
            itemsTab.Size = new Size(792, 417);
            itemsTab.TabIndex = 0;
            itemsTab.Text = "Items";
            itemsTab.UseVisualStyleBackColor = true;
            itemsTab.Click += tabPage1_Click;
            // 
            // itemsTabControl
            // 
            itemsTabControl.Dock = DockStyle.Fill;
            itemsTabControl.Items = null;
            itemsTabControl.Location = new Point(3, 3);
            itemsTabControl.Name = "itemsTabControl";
            itemsTabControl.Size = new Size(786, 411);
            itemsTabControl.TabIndex = 0;
            itemsTabControl.Load += itemsTab1_Load;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(itemsTab);
            tabControl1.Controls.Add(customersTab);
            tabControl1.Controls.Add(cartTab);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
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
            cartTab.ResumeLayout(false);
            customersTab.ResumeLayout(false);
            itemsTab.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage cartTab;
        private TabPage customersTab;
        private View.Tabs.CustomersTab customersTabControl;
        private TabPage itemsTab;
        private View.Tabs.ItemsTab itemsTabControl;
        private TabControl tabControl1;
        private View.Tabs.CartsTab cartsTab1;
    }
}
