namespace Lab8
{
    partial class MainForm
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            cityBuildingsControl1 = new CityBuildingsControl();
            SuspendLayout();
            // 
            // cityBuildingsControl1
            // 
            cityBuildingsControl1.AutoSize = true;
            cityBuildingsControl1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cityBuildingsControl1.Location = new Point(12, 12);
            cityBuildingsControl1.Name = "cityBuildingsControl1";
            cityBuildingsControl1.Size = new Size(468, 325);
            cityBuildingsControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 450);
            Controls.Add(cityBuildingsControl1);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CityBuildingsControl cityBuildingsControl1;
    }
}
