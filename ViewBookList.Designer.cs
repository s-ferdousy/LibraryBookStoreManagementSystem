namespace Library_Book_Store_Management_System_3
{
    partial class ViewBookList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBookList));
            this.listView1 = new System.Windows.Forms.ListView();
            this.book_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.book_writer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.book_Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.book_catagory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReturnFromViewButton = new System.Windows.Forms.Button();
            this.SearchBookButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.book_name,
            this.book_writer,
            this.book_Qty,
            this.book_catagory});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 51);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(328, 249);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // book_name
            // 
            this.book_name.Text = "Name";
            this.book_name.Width = 145;
            // 
            // book_writer
            // 
            this.book_writer.Text = "Writer";
            this.book_writer.Width = 129;
            // 
            // book_Qty
            // 
            this.book_Qty.Text = "Quantity";
            this.book_Qty.Width = 53;
            // 
            // book_catagory
            // 
            this.book_catagory.Text = "Category";
            this.book_catagory.Width = 105;
            // 
            // ReturnFromViewButton
            // 
            this.ReturnFromViewButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReturnFromViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ReturnFromViewButton.Location = new System.Drawing.Point(12, 306);
            this.ReturnFromViewButton.Name = "ReturnFromViewButton";
            this.ReturnFromViewButton.Size = new System.Drawing.Size(330, 33);
            this.ReturnFromViewButton.TabIndex = 1;
            this.ReturnFromViewButton.Text = "Return to Dashboard";
            this.ReturnFromViewButton.UseVisualStyleBackColor = false;
            this.ReturnFromViewButton.Click += new System.EventHandler(this.ReturnFromViewButton_Click);
            // 
            // SearchBookButton
            // 
            this.SearchBookButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SearchBookButton.Location = new System.Drawing.Point(12, 12);
            this.SearchBookButton.Name = "SearchBookButton";
            this.SearchBookButton.Size = new System.Drawing.Size(328, 33);
            this.SearchBookButton.TabIndex = 2;
            this.SearchBookButton.Text = "Search a Book";
            this.SearchBookButton.UseVisualStyleBackColor = false;
            this.SearchBookButton.Click += new System.EventHandler(this.SearchBookButton_Click);
            // 
            // ViewBookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(354, 351);
            this.Controls.Add(this.SearchBookButton);
            this.Controls.Add(this.ReturnFromViewButton);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewBookList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Book List";
            this.Load += new System.EventHandler(this.ViewBookList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader book_name;
        private System.Windows.Forms.ColumnHeader book_writer;
        private System.Windows.Forms.ColumnHeader book_Qty;
        private System.Windows.Forms.Button ReturnFromViewButton;
        private System.Windows.Forms.ColumnHeader book_catagory;
        private System.Windows.Forms.Button SearchBookButton;
    }
}