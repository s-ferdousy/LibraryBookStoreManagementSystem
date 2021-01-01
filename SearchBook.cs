using System;
using System.Windows.Forms;
using System.Data.OracleClient;
namespace Library_Book_Store_Management_System_3
{
    public partial class SearchBook : Form
    {
        public SearchBook()
        {
            InitializeComponent();
        }

        private void FromSearchToViewlist_Click(object sender, EventArgs e)
        {
            ViewBookList nxtForm = new ViewBookList();
            nxtForm.Show();
            this.Hide();
        }

        private void FromSearchToDashboard_Click(object sender, EventArgs e)
        {
            ManagerDashboard nxtform = new ManagerDashboard();
            nxtform.Show();
            this.Hide();
        }

        private void GetSearchResultButton_Click(object sender, EventArgs e)
        {
            //lsvItem.Items.Clear();
            connection CN = new connection();
            CN.thisConnection.Open();
            OracleCommand thisCommand = CN.thisConnection.CreateCommand();
            thisCommand.CommandText = "SELECT * FROM bookinfo where book_name= '" + SearchText.Text + "'";
            OracleDataReader thisReader = thisCommand.ExecuteReader();
            while (thisReader.Read())
            {
                ListViewItem lsvItem = new ListViewItem();
                //lsvItem.Clear();
                listView1.Items.Clear();
//                lsvItem.SubItems.Clear();
                lsvItem.Text = thisReader["book_name"].ToString();
                lsvItem.SubItems.Add(thisReader["writer_name"].ToString());
                lsvItem.SubItems.Add(thisReader["book_qty"].ToString());
                lsvItem.SubItems.Add(thisReader["book_category"].ToString());
                listView1.Items.Add(lsvItem);
            }
            CN.thisConnection.Close();
        }
    }
}
