namespace Theaters
{
    partial class VisitorTheatersList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topPanel = new System.Windows.Forms.Panel();
            this.searchTxtBox = new Theaters.UserControls.TextBoxUC();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.dataGridViewUC = new Theaters.UserControls.DataGridViewUC();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.Control;
            this.topPanel.Controls.Add(this.searchTxtBox);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(967, 94);
            this.topPanel.TabIndex = 0;
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.BackColor = System.Drawing.Color.White;
            this.searchTxtBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.searchTxtBox.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.searchTxtBox.BorderRadius = 20;
            this.searchTxtBox.BorderSize = 1;
            this.searchTxtBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTxtBox.Location = new System.Drawing.Point(659, 31);
            this.searchTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTxtBox.Multiline = false;
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.searchTxtBox.PasswordChar = false;
            this.searchTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.searchTxtBox.PlaceholderText = "Поиск";
            this.searchTxtBox.Size = new System.Drawing.Size(290, 32);
            this.searchTxtBox.TabIndex = 1;
            this.searchTxtBox.UnderlinedStyle = false;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.dataGridViewUC);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel.Location = new System.Drawing.Point(0, 94);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(967, 507);
            this.bottomPanel.TabIndex = 1;
            // 
            // dataGridViewUC
            // 
            this.dataGridViewUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUC.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUC.Name = "dataGridViewUC";
            this.dataGridViewUC.Size = new System.Drawing.Size(967, 507);
            this.dataGridViewUC.TabIndex = 0;
            // 
            // VisitorTheatersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "VisitorTheatersList";
            this.Size = new System.Drawing.Size(967, 601);
            this.Load += new System.EventHandler(this.VisitorTheatersList_Load);
            this.topPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private UserControls.DataGridViewUC dataGridViewUC;
        private UserControls.TextBoxUC searchTxtBox;
    }
}
