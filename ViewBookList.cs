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
    public partial class ViewBookList : Form
    {
        public ViewBookList()
        {
            InitializeComponent();
        }
        /*public string GetSearchText()
        {
            return SearchText.Text;
        }*/
        private void ViewBookList_Load(object sender, EventArgs e)
        {
            connection CN = new connection();
            CN.thisConnection.Open();
            OracleCommand thisCommand = CN.thisConnection.CreateCommand();
            thisCommand.CommandText = "SELECT * FROM bookinfo order by book_name";
            OracleDataReader thisReader = thisCommand.ExecuteReader();
            while (thisReader.Read())
            {
                ListViewItem lsvItem = new ListViewItem();
                lsvItem.Text = thisReader["book_name"].ToString();
                lsvItem.SubItems.Add(thisReader["writer_name"].ToString());
                lsvItem.SubItems.Add(thisReader["book_qty"].ToString());
                lsvItem.SubItems.Add(thisReader["book_category"].ToString());
                listView1.Items.Add(lsvItem);
            }
            CN.thisConnection.Close();
        }

        private void ReturnFromViewButton_Click(object sender, EventArgs e)
        {
            ManagerDashboard nxtForm = new ManagerDashboard();
            nxtForm.Show();
            this.Hide();
        }

        private void SearchBookButton_Click(object sender, EventArgs e)
        {
            SearchBook nxtform = new SearchBook();
            nxtform.Show();
            this.Hide();
        }
    }
}
