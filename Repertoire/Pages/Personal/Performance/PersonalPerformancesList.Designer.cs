namespace Theaters
{
    partial class PersonalPerformancesList
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
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.topLabel = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.addPerformanceBtn = new Theaters.UserControls.ButtonUC();
            this.returnBtn = new Theaters.UserControls.ButtonUC();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.dataGridViewUC = new Theaters.UserControls.DataGridViewUC();
            this.searchTxtBox = new Theaters.UserControls.TextBoxUC();
            this.bottomPanel.SuspendLayout();
            this.centerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // topLabel
            // 
            this.topLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.topLabel.Location = new System.Drawing.Point(13, 12);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(320, 53);
            this.topLabel.TabIndex = 28;
            this.topLabel.Text = "Выступления на 16 июня";
            this.topLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.White;
            this.bottomPanel.Controls.Add(this.addPerformanceBtn);
            this.bottomPanel.Controls.Add(this.returnBtn);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 519);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(967, 82);
            this.bottomPanel.TabIndex = 3;
            // 
            // addPerformanceBtn
            // 
            this.addPerformanceBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.addPerformanceBtn.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.addPerformanceBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addPerformanceBtn.BorderRadius = 39;
            this.addPerformanceBtn.BorderSize = 0;
            this.addPerformanceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPerformanceBtn.FlatAppearance.BorderSize = 0;
            this.addPerformanceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPerformanceBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addPerformanceBtn.ForeColor = System.Drawing.Color.White;
            this.addPerformanceBtn.Location = new System.Drawing.Point(721, 17);
            this.addPerformanceBtn.Name = "addPerformanceBtn";
            this.addPerformanceBtn.Size = new System.Drawing.Size(205, 48);
            this.addPerformanceBtn.TabIndex = 1;
            this.addPerformanceBtn.Text = "Добавить выступление";
            this.addPerformanceBtn.TextColor = System.Drawing.Color.White;
            this.addPerformanceBtn.UseVisualStyleBackColor = false;
            this.addPerformanceBtn.Click += new System.EventHandler(this.addPerformanceBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.returnBtn.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.returnBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.returnBtn.BorderRadius = 39;
            this.returnBtn.BorderSize = 0;
            this.returnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnBtn.FlatAppearance.BorderSize = 0;
            this.returnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.returnBtn.ForeColor = System.Drawing.Color.White;
            this.returnBtn.Location = new System.Drawing.Point(47, 17);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(162, 48);
            this.returnBtn.TabIndex = 0;
            this.returnBtn.Text = "Назад";
            this.returnBtn.TextColor = System.Drawing.Color.White;
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // centerPanel
            // 
            this.centerPanel.Controls.Add(this.topLabel);
            this.centerPanel.Controls.Add(this.dataGridViewUC);
            this.centerPanel.Controls.Add(this.searchTxtBox);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(0, 0);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(967, 601);
            this.centerPanel.TabIndex = 4;
            // 
            // dataGridViewUC
            // 
            this.dataGridViewUC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewUC.Location = new System.Drawing.Point(0, 81);
            this.dataGridViewUC.Name = "dataGridViewUC";
            this.dataGridViewUC.Size = new System.Drawing.Size(967, 520);
            this.dataGridViewUC.TabIndex = 0;
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.BackColor = System.Drawing.Color.White;
            this.searchTxtBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.searchTxtBox.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.searchTxtBox.BorderRadius = 20;
            this.searchTxtBox.BorderSize = 1;
            this.searchTxtBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTxtBox.Location = new System.Drawing.Point(639, 26);
            this.searchTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTxtBox.Multiline = false;
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.searchTxtBox.PasswordChar = false;
            this.searchTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.searchTxtBox.PlaceholderText = "Поиск";
            this.searchTxtBox.Size = new System.Drawing.Size(300, 32);
            this.searchTxtBox.TabIndex = 0;
            this.searchTxtBox.UnderlinedStyle = false;
            // 
            // PersonalPerformancesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.centerPanel);
            this.Name = "PersonalPerformancesList";
            this.Size = new System.Drawing.Size(967, 601);
            this.Load += new System.EventHandler(this.PersonalPerformancesList_Load);
            this.bottomPanel.ResumeLayout(false);
            this.centerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.Label topLabel;
        private UserControls.TextBoxUC searchTxtBox;
        private System.Windows.Forms.Panel bottomPanel;
        private UserControls.ButtonUC addPerformanceBtn;
        private UserControls.ButtonUC returnBtn;
        private System.Windows.Forms.Panel centerPanel;
        private UserControls.DataGridViewUC dataGridViewUC;
    }
}
