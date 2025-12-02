namespace Theaters
{
    partial class PersonalPerformanceVisitorsList
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
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.dataGridViewUC = new Theaters.UserControls.DataGridViewUC();
            this.buttonUC1 = new Theaters.UserControls.ButtonUC();
            this.bottomPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.White;
            this.bottomPanel.Controls.Add(this.buttonUC1);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 501);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(967, 100);
            this.bottomPanel.TabIndex = 0;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.dataGridViewUC);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(967, 501);
            this.topPanel.TabIndex = 1;
            // 
            // dataGridViewUC
            // 
            this.dataGridViewUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUC.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUC.Name = "dataGridViewUC";
            this.dataGridViewUC.Size = new System.Drawing.Size(967, 501);
            this.dataGridViewUC.TabIndex = 0;
            // 
            // buttonUC1
            // 
            this.buttonUC1.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonUC1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.buttonUC1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonUC1.BorderRadius = 40;
            this.buttonUC1.BorderSize = 0;
            this.buttonUC1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUC1.FlatAppearance.BorderSize = 0;
            this.buttonUC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUC1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonUC1.ForeColor = System.Drawing.Color.White;
            this.buttonUC1.Location = new System.Drawing.Point(42, 28);
            this.buttonUC1.Name = "buttonUC1";
            this.buttonUC1.Size = new System.Drawing.Size(145, 45);
            this.buttonUC1.TabIndex = 0;
            this.buttonUC1.Text = "Назад";
            this.buttonUC1.TextColor = System.Drawing.Color.White;
            this.buttonUC1.UseVisualStyleBackColor = false;
            this.buttonUC1.Click += new System.EventHandler(this.buttonUC1_Click);
            // 
            // PersonalPerformanceVisitorsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.bottomPanel);
            this.Name = "PersonalPerformanceVisitorsList";
            this.Size = new System.Drawing.Size(967, 601);
            this.Load += new System.EventHandler(this.PersonalPerformanceVisitorsList_Load);
            this.bottomPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel topPanel;
        private UserControls.DataGridViewUC dataGridViewUC;
        private UserControls.ButtonUC buttonUC1;
    }
}
