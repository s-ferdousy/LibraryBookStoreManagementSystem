namespace Library_Book_Store_Management_System_3
{
    partial class AddNewManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewManager));
            this.CancelNewManager = new System.Windows.Forms.Button();
            this.ConfirmNewManager = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NewManagerUsername = new System.Windows.Forms.TextBox();
            this.NewManagerPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CancelNewManager
            // 
            this.CancelNewManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CancelNewManager.Location = new System.Drawing.Point(12, 316);
            this.CancelNewManager.Name = "CancelNewManager";
            this.CancelNewManager.Size = new System.Drawing.Size(75, 23);
            this.CancelNewManager.TabIndex = 0;
            this.CancelNewManager.Text = "Cancel";
            this.CancelNewManager.UseVisualStyleBackColor = true;
            this.CancelNewManager.Click += new System.EventHandler(this.CancelNewManager_Click);
            // 
            // ConfirmNewManager
            // 
            this.ConfirmNewManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ConfirmNewManager.Location = new System.Drawing.Point(267, 316);
            this.ConfirmNewManager.Name = "ConfirmNewManager";
            this.ConfirmNewManager.Size = new System.Drawing.Size(75, 23);
            this.ConfirmNewManager.TabIndex = 1;
            this.ConfirmNewManager.Text = "Confirm";
            this.ConfirmNewManager.UseVisualStyleBackColor = true;
            this.ConfirmNewManager.Click += new System.EventHandler(this.ConfirmNewManager_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(29, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Create Username: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(29, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Create Password: ";
            // 
            // NewManagerUsername
            // 
            this.NewManagerUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.NewManagerUsername.Location = new System.Drawing.Point(32, 106);
            this.NewManagerUsername.Name = "NewManagerUsername";
            this.NewManagerUsername.Size = new System.Drawing.Size(290, 24);
            this.NewManagerUsername.TabIndex = 4;
            // 
            // NewManagerPass
            // 
            this.NewManagerPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.NewManagerPass.Location = new System.Drawing.Point(32, 186);
            this.NewManagerPass.Name = "NewManagerPass";
            this.NewManagerPass.Size = new System.Drawing.Size(290, 24);
            this.NewManagerPass.TabIndex = 5;
            // 
            // AddNewManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 351);
            this.Controls.Add(this.NewManagerPass);
            this.Controls.Add(this.NewManagerUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmNewManager);
            this.Controls.Add(this.CancelNewManager);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelNewManager;
        private System.Windows.Forms.Button ConfirmNewManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewManagerUsername;
        private System.Windows.Forms.TextBox NewManagerPass;
    }
}