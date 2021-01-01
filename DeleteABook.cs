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
    public partial class DeleteABook : Form
    {
        public DeleteABook()
        {
            InitializeComponent();
        }

        private void ConfirmRemovingBook_Click(object sender, EventArgs e)
        {
            connection CN = new connection();
            CN.thisConnection.Open();
            OracleCommand thisCommand1 = CN.thisConnection.CreateCommand();
            thisCommand1.CommandText = "delete bookinfo where book_name= '" + BookNameToRemove.Text + "'";
            thisCommand1.Connection = CN.thisConnection;
            thisCommand1.CommandType = CommandType.Text;
            try
            {
                thisCommand1.ExecuteNonQuery();
                MessageBox.Show("Book Removed");
                ManagerDashboard nxtform = new ManagerDashboard();
                nxtform.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void CancelRemovingBook_Click(object sender, EventArgs e)
        {
            ManagerDashboard nxtform = new ManagerDashboard();
            nxtform.Show();
            this.Hide();
        }
    }
}
