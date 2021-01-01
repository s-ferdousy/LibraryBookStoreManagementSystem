using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
namespace Library_Book_Store_Management_System_3
{
    public partial class ManagerDashboard : Form
    {
        public ManagerDashboard()
        {
            InitializeComponent();
        }
        private void AddBook_Click(object sender, EventArgs e)
        {
            AddNewBook nxtForm = new AddNewBook();
            nxtForm.Show();
            this.Hide();
        }
        private void UpdateBook_Click(object sender, EventArgs e)
        {
            UpdateBookInfo nxtform = new UpdateBookInfo();
            nxtform.Show();
            this.Hide();

        }
        private void DeleteBook_Click(object sender, EventArgs e)
        {
            DeleteABook nxtForm = new DeleteABook();
            nxtForm.Show();
            this.Hide();
        }
        private void BookList_Click(object sender, EventArgs e)
        {
            ViewBookList nxtForm = new ViewBookList();
            nxtForm.Show();
            this.Hide();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Form1 nxtForm = new Form1();
            nxtForm.Show();
            this.Hide();
        }
    }
}
