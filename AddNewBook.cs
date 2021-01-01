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
    public partial class AddNewBook : Form
    {
        public AddNewBook()
        {
            InitializeComponent();
        }

        private void ConfirmNewBook_Click(object sender, EventArgs e)
        {
            connection CN2 = new connection();
            CN2.thisConnection.Open();
            OracleDataAdapter thisAdapter = new OracleDataAdapter("SELECT * FROM bookinfo", CN2.thisConnection);
            OracleCommandBuilder thisBuilder = new OracleCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "bookinfo");
            DataRow thisRow = thisDataSet.Tables["bookinfo"].NewRow();
            try
            {
                thisRow["isbn"] = IsbnOfTheBook.Text;
                thisRow["book_name"] = NameOfTheBook.Text;
                thisRow["writer_name"] = NameOfTheWriter.Text;
                thisRow["book_category"] = CategoryOfTheBook.Text;
                thisRow["entry_date"] = DateOfEntry.Text;
                thisRow["year_published"] = YearOfPublication.Text;
                thisRow["book_qty"] = NumberOfBook.Text;
                thisDataSet.Tables["bookinfo"].Rows.Add(thisRow);
                thisAdapter.Update(thisDataSet, "bookinfo");
                MessageBox.Show("A New Book Added");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            CN2.thisConnection.Close();
            ManagerDashboard nxtForm = new ManagerDashboard();
            nxtForm.Show();
            this.Hide();
        }

        private void CancelNewBook_Click(object sender, EventArgs e)
        {
            ManagerDashboard nxtForm = new ManagerDashboard();
            nxtForm.Show();
            this.Hide();
        }
    }
}
