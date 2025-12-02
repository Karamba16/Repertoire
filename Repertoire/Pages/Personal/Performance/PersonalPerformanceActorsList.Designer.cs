namespace Theaters
{
    partial class PersonalPerformanceActorsList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.actorsDropdown = new Theaters.UserControls.DropdownMenuUC();
            this.dataGridViewUC = new Theaters.UserControls.DataGridViewUC();
            this.returnBtn = new Theaters.UserControls.ButtonUC();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.returnBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 501);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.actorsDropdown);
            this.panel2.Controls.Add(this.dataGridViewUC);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(967, 501);
            this.panel2.TabIndex = 1;
            // 
            // actorsDropdown
            // 
            this.actorsDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.actorsDropdown.Location = new System.Drawing.Point(680, 21);
            this.actorsDropdown.MaximumSize = new System.Drawing.Size(250, 50);
            this.actorsDropdown.MinimumSize = new System.Drawing.Size(0, 50);
            this.actorsDropdown.Name = "actorsDropdown";
            this.actorsDropdown.Size = new System.Drawing.Size(239, 50);
            this.actorsDropdown.TabIndex = 1;
            this.actorsDropdown.Title = "Добавить актера";
            this.actorsDropdown.Load += new System.EventHandler(this.actorsDropdown_Load);
            // 
            // dataGridViewUC
            // 
            this.dataGridViewUC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewUC.Location = new System.Drawing.Point(0, 93);
            this.dataGridViewUC.Name = "dataGridViewUC";
            this.dataGridViewUC.Size = new System.Drawing.Size(967, 408);
            this.dataGridViewUC.TabIndex = 0;
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.returnBtn.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.returnBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.returnBtn.BorderRadius = 40;
            this.returnBtn.BorderSize = 0;
            this.returnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnBtn.FlatAppearance.BorderSize = 0;
            this.returnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.returnBtn.ForeColor = System.Drawing.Color.White;
            this.returnBtn.Location = new System.Drawing.Point(38, 30);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(169, 52);
            this.returnBtn.TabIndex = 0;
            this.returnBtn.Text = "Назад";
            this.returnBtn.TextColor = System.Drawing.Color.White;
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // PersonalPerformanceActorsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PersonalPerformanceActorsList";
            this.Size = new System.Drawing.Size(967, 601);
            this.Load += new System.EventHandler(this.PersonalPerformanceAcrotsList_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private UserControls.DataGridViewUC dataGridViewUC;
        private UserControls.ButtonUC returnBtn;
        private UserControls.DropdownMenuUC actorsDropdown;
    }
}
