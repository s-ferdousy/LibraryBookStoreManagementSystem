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
    public partial class RemoveAManager : Form
    {
        public RemoveAManager()
        {
            InitializeComponent();
        }

        private void CancelRemovingManager_Click(object sender, EventArgs e)
        {
            AdminDashboard nxtform = new AdminDashboard();
            nxtform.Show();
            this.Hide();
        }

        private void ConfirmRemovingManager_Click(object sender, EventArgs e)
        {
            connection CN = new connection();
            CN.thisConnection.Open();
            OracleCommand thisCommand1 = CN.thisConnection.CreateCommand();
            thisCommand1.CommandText = "delete userinfo where id= '" + ManagerID.Text + "'";
            thisCommand1.Connection = CN.thisConnection;
            thisCommand1.CommandType = CommandType.Text;
            try
            {
                thisCommand1.ExecuteNonQuery();
                MessageBox.Show("Manager Removed");
                AdminDashboard nxtform = new AdminDashboard();
                nxtform.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
