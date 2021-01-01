namespace Library_Book_Store_Management_System_3
{
    partial class RemoveAManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveAManager));
            this.CancelRemovingManager = new System.Windows.Forms.Button();
            this.ConfirmRemovingManager = new System.Windows.Forms.Button();
            this.ManagerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelRemovingManager
            // 
            this.CancelRemovingManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CancelRemovingManager.Location = new System.Drawing.Point(12, 316);
            this.CancelRemovingManager.Name = "CancelRemovingManager";
            this.CancelRemovingManager.Size = new System.Drawing.Size(75, 23);
            this.CancelRemovingManager.TabIndex = 0;
            this.CancelRemovingManager.Text = "Cancel";
            this.CancelRemovingManager.UseVisualStyleBackColor = true;
            this.CancelRemovingManager.Click += new System.EventHandler(this.CancelRemovingManager_Click);
            // 
            // ConfirmRemovingManager
            // 
            this.ConfirmRemovingManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ConfirmRemovingManager.Location = new System.Drawing.Point(267, 316);
            this.ConfirmRemovingManager.Name = "ConfirmRemovingManager";
            this.ConfirmRemovingManager.Size = new System.Drawing.Size(75, 23);
            this.ConfirmRemovingManager.TabIndex = 1;
            this.ConfirmRemovingManager.Text = "Confirm";
            this.ConfirmRemovingManager.UseVisualStyleBackColor = true;
            this.ConfirmRemovingManager.Click += new System.EventHandler(this.ConfirmRemovingManager_Click);
            // 
            // ManagerID
            // 
            this.ManagerID.Location = new System.Drawing.Point(32, 106);
            this.ManagerID.Name = "ManagerID";
            this.ManagerID.Size = new System.Drawing.Size(290, 20);
            this.ManagerID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(29, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Manager\'s Username: ";
            // 
            // RemoveAManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 351);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ManagerID);
            this.Controls.Add(this.ConfirmRemovingManager);
            this.Controls.Add(this.CancelRemovingManager);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RemoveAManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelRemovingManager;
        private System.Windows.Forms.Button ConfirmRemovingManager;
        private System.Windows.Forms.TextBox ManagerID;
        private System.Windows.Forms.Label label1;
    }
}