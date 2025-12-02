namespace Theaters
{
    partial class PersonalHomePage
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
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.logoutBtnUC1 = new Theaters.UserControls.LogoutBtnUC();
            this.label1 = new System.Windows.Forms.Label();
            this.theaterLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullnameLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.fullnameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fullnameLabel.Location = new System.Drawing.Point(48, 61);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(699, 30);
            this.fullnameLabel.TabIndex = 29;
            this.fullnameLabel.Text = "Анатолий Александрович Макаров";
            this.fullnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logoutBtnUC1
            // 
            this.logoutBtnUC1.BackColor = System.Drawing.Color.RoyalBlue;
            this.logoutBtnUC1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.logoutBtnUC1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.logoutBtnUC1.BorderRadius = 40;
            this.logoutBtnUC1.BorderSize = 0;
            this.logoutBtnUC1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtnUC1.FlatAppearance.BorderSize = 0;
            this.logoutBtnUC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtnUC1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoutBtnUC1.ForeColor = System.Drawing.Color.White;
            this.logoutBtnUC1.Location = new System.Drawing.Point(705, 507);
            this.logoutBtnUC1.Name = "logoutBtnUC1";
            this.logoutBtnUC1.Size = new System.Drawing.Size(183, 51);
            this.logoutBtnUC1.TabIndex = 30;
            this.logoutBtnUC1.Text = "Выйти";
            this.logoutBtnUC1.TextColor = System.Drawing.Color.White;
            this.logoutBtnUC1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(49, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Театр:";
            // 
            // theaterLabel
            // 
            this.theaterLabel.AutoSize = true;
            this.theaterLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theaterLabel.Location = new System.Drawing.Point(135, 286);
            this.theaterLabel.Name = "theaterLabel";
            this.theaterLabel.Size = new System.Drawing.Size(252, 25);
            this.theaterLabel.TabIndex = 32;
            this.theaterLabel.Text = "Московский театр мюзикла";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(49, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Адрес:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressLabel.Location = new System.Drawing.Point(135, 351);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(168, 25);
            this.addressLabel.TabIndex = 34;
            this.addressLabel.Text = "Пушкинская пл., 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(49, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Место работы";
            // 
            // PersonalHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.theaterLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fullnameLabel);
            this.Controls.Add(this.logoutBtnUC1);
            this.Name = "PersonalHomePage";
            this.Size = new System.Drawing.Size(967, 601);
            this.Load += new System.EventHandler(this.PersonalHomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fullnameLabel;
        private UserControls.LogoutBtnUC logoutBtnUC1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label theaterLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label label5;
    }
}
