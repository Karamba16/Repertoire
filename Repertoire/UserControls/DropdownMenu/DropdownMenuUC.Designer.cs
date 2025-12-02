namespace Theaters.UserControls
{
    partial class DropdownMenuUC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DropdownMenuUC));
            this.openBtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // openBtn
            // 
            this.openBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.openBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.openBtn.FlatAppearance.BorderSize = 0;
            this.openBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openBtn.ForeColor = System.Drawing.Color.White;
            this.openBtn.Image = ((System.Drawing.Image)(resources.GetObject("openBtn.Image")));
            this.openBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.openBtn.Location = new System.Drawing.Point(0, 0);
            this.openBtn.Margin = new System.Windows.Forms.Padding(0);
            this.openBtn.Name = "openBtn";
            this.openBtn.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.openBtn.Size = new System.Drawing.Size(250, 50);
            this.openBtn.TabIndex = 1;
            this.openBtn.Text = "Select";
            this.openBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openBtn.UseVisualStyleBackColor = false;
            this.openBtn.Click += new System.EventHandler(this.button_Click);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 50);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(250, 0);
            this.panel.TabIndex = 2;
            // 
            // DropdownMenuUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.panel);
            this.Controls.Add(this.openBtn);
            this.MaximumSize = new System.Drawing.Size(250, 50);
            this.MinimumSize = new System.Drawing.Size(0, 50);
            this.Name = "DropdownMenuUC";
            this.Size = new System.Drawing.Size(250, 50);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel;
    }
}
