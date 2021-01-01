namespace Library_Book_Store_Management_System_3
{
    partial class AdminDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.addManager = new System.Windows.Forms.Button();
            this.deleteManager = new System.Windows.Forms.Button();
            this.AdminLogoutButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // addManager
            // 
            this.addManager.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addManager.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addManager.Location = new System.Drawing.Point(210, 167);
            this.addManager.Name = "addManager";
            this.addManager.Size = new System.Drawing.Size(117, 66);
            this.addManager.TabIndex = 0;
            this.addManager.Text = "Add a Manager";
            this.addManager.UseVisualStyleBackColor = false;
            this.addManager.Click += new System.EventHandler(this.addManager_Click);
            // 
            // deleteManager
            // 
            this.deleteManager.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.deleteManager.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deleteManager.Location = new System.Drawing.Point(27, 167);
            this.deleteManager.Name = "deleteManager";
            this.deleteManager.Size = new System.Drawing.Size(117, 66);
            this.deleteManager.TabIndex = 1;
            this.deleteManager.Text = "Remove a Manager";
            this.deleteManager.UseVisualStyleBackColor = false;
            this.deleteManager.Click += new System.EventHandler(this.deleteManager_Click);
            // 
            // AdminLogoutButton
            // 
            this.AdminLogoutButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AdminLogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminLogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.AdminLogoutButton.Location = new System.Drawing.Point(121, 308);
            this.AdminLogoutButton.Name = "AdminLogoutButton";
            this.AdminLogoutButton.Size = new System.Drawing.Size(113, 28);
            this.AdminLogoutButton.TabIndex = 4;
            this.AdminLogoutButton.Text = "Logout";
            this.AdminLogoutButton.UseVisualStyleBackColor = false;
            this.AdminLogoutButton.Click += new System.EventHandler(this.AdminLogoutButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(210, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(354, 351);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AdminLogoutButton);
            this.Controls.Add(this.deleteManager);
            this.Controls.Add(this.addManager);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addManager;
        private System.Windows.Forms.Button deleteManager;
        private System.Windows.Forms.Button AdminLogoutButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}