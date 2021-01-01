namespace Library_Book_Store_Management_System_3
{
    partial class DeleteABook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteABook));
            this.label1 = new System.Windows.Forms.Label();
            this.CancelRemovingBook = new System.Windows.Forms.Button();
            this.ConfirmRemovingBook = new System.Windows.Forms.Button();
            this.BookNameToRemove = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(30, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Book Name Here: ";
            // 
            // CancelRemovingBook
            // 
            this.CancelRemovingBook.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelRemovingBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CancelRemovingBook.Location = new System.Drawing.Point(12, 316);
            this.CancelRemovingBook.Name = "CancelRemovingBook";
            this.CancelRemovingBook.Size = new System.Drawing.Size(75, 23);
            this.CancelRemovingBook.TabIndex = 1;
            this.CancelRemovingBook.Text = "Cancel";
            this.CancelRemovingBook.UseVisualStyleBackColor = false;
            this.CancelRemovingBook.Click += new System.EventHandler(this.CancelRemovingBook_Click);
            // 
            // ConfirmRemovingBook
            // 
            this.ConfirmRemovingBook.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ConfirmRemovingBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ConfirmRemovingBook.Location = new System.Drawing.Point(267, 316);
            this.ConfirmRemovingBook.Name = "ConfirmRemovingBook";
            this.ConfirmRemovingBook.Size = new System.Drawing.Size(75, 23);
            this.ConfirmRemovingBook.TabIndex = 2;
            this.ConfirmRemovingBook.Text = "Confirm";
            this.ConfirmRemovingBook.UseVisualStyleBackColor = false;
            this.ConfirmRemovingBook.Click += new System.EventHandler(this.ConfirmRemovingBook_Click);
            // 
            // BookNameToRemove
            // 
            this.BookNameToRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BookNameToRemove.Location = new System.Drawing.Point(33, 114);
            this.BookNameToRemove.Name = "BookNameToRemove";
            this.BookNameToRemove.Size = new System.Drawing.Size(289, 24);
            this.BookNameToRemove.TabIndex = 3;
            // 
            // DeleteABook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(354, 351);
            this.Controls.Add(this.BookNameToRemove);
            this.Controls.Add(this.ConfirmRemovingBook);
            this.Controls.Add(this.CancelRemovingBook);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteABook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove A Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelRemovingBook;
        private System.Windows.Forms.Button ConfirmRemovingBook;
        private System.Windows.Forms.TextBox BookNameToRemove;
    }
}