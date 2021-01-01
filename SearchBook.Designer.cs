namespace Library_Book_Store_Management_System_3
{
    partial class SearchBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBook));
            this.FromSearchToDashboard = new System.Windows.Forms.Button();
            this.FromSearchToViewlist = new System.Windows.Forms.Button();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.book_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.book_writer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.book_Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.book_catagory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GetSearchResultButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FromSearchToDashboard
            // 
            this.FromSearchToDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FromSearchToDashboard.Location = new System.Drawing.Point(220, 316);
            this.FromSearchToDashboard.Name = "FromSearchToDashboard";
            this.FromSearchToDashboard.Size = new System.Drawing.Size(122, 23);
            this.FromSearchToDashboard.TabIndex = 3;
            this.FromSearchToDashboard.Text = "Go to Dashboard";
            this.FromSearchToDashboard.UseVisualStyleBackColor = true;
            this.FromSearchToDashboard.Click += new System.EventHandler(this.FromSearchToDashboard_Click);
            // 
            // FromSearchToViewlist
            // 
            this.FromSearchToViewlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FromSearchToViewlist.Location = new System.Drawing.Point(12, 316);
            this.FromSearchToViewlist.Name = "FromSearchToViewlist";
            this.FromSearchToViewlist.Size = new System.Drawing.Size(75, 23);
            this.FromSearchToViewlist.TabIndex = 2;
            this.FromSearchToViewlist.Text = "Back";
            this.FromSearchToViewlist.UseVisualStyleBackColor = true;
            this.FromSearchToViewlist.Click += new System.EventHandler(this.FromSearchToViewlist_Click);
            // 
            // SearchText
            // 
            this.SearchText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.SearchText.Location = new System.Drawing.Point(12, 12);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(250, 27);
            this.SearchText.TabIndex = 5;
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
            this.listView1.Location = new System.Drawing.Point(11, 49);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(331, 249);
            this.listView1.TabIndex = 4;
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
            // GetSearchResultButton
            // 
            this.GetSearchResultButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GetSearchResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.GetSearchResultButton.Location = new System.Drawing.Point(271, 10);
            this.GetSearchResultButton.Name = "GetSearchResultButton";
            this.GetSearchResultButton.Size = new System.Drawing.Size(71, 33);
            this.GetSearchResultButton.TabIndex = 6;
            this.GetSearchResultButton.Text = "Search";
            this.GetSearchResultButton.UseVisualStyleBackColor = false;
            this.GetSearchResultButton.Click += new System.EventHandler(this.GetSearchResultButton_Click);
            // 
            // SearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 351);
            this.Controls.Add(this.GetSearchResultButton);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.FromSearchToDashboard);
            this.Controls.Add(this.FromSearchToViewlist);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search a Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FromSearchToDashboard;
        private System.Windows.Forms.Button FromSearchToViewlist;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader book_name;
        private System.Windows.Forms.ColumnHeader book_writer;
        private System.Windows.Forms.ColumnHeader book_Qty;
        private System.Windows.Forms.ColumnHeader book_catagory;
        private System.Windows.Forms.Button GetSearchResultButton;
    }
}