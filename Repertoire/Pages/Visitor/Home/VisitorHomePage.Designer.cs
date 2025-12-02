namespace Theaters
{
    partial class VisitorHomePage
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
            this.SuspendLayout();
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullnameLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.fullnameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fullnameLabel.Location = new System.Drawing.Point(0, 95);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(964, 30);
            this.fullnameLabel.TabIndex = 27;
            this.fullnameLabel.Text = "Анатолий Александрович Макаров";
            this.fullnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.logoutBtnUC1.Location = new System.Drawing.Point(392, 275);
            this.logoutBtnUC1.Name = "logoutBtnUC1";
            this.logoutBtnUC1.Size = new System.Drawing.Size(183, 51);
            this.logoutBtnUC1.TabIndex = 28;
            this.logoutBtnUC1.Text = "Выйти";
            this.logoutBtnUC1.TextColor = System.Drawing.Color.White;
            this.logoutBtnUC1.UseVisualStyleBackColor = false;
            // 
            // VisitorHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fullnameLabel);
            this.Controls.Add(this.logoutBtnUC1);
            this.Name = "VisitorHomePage";
            this.Size = new System.Drawing.Size(967, 601);
            this.Load += new System.EventHandler(this.VisitorHomePage_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label fullnameLabel;
        private UserControls.LogoutBtnUC logoutBtnUC1;
    }
}
