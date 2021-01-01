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
    public partial class UpdateBookInfo : Form
    {
        public UpdateBookInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagerDashboard nxtForm = new ManagerDashboard();
            nxtForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection sv = new connection();
            sv.thisConnection.Open();
            OracleCommand thisCommand = sv.thisConnection.CreateCommand();
            thisCommand.CommandText = "update bookinfo set book_qty = '" + NewQty.Text + "'where book_name= '" + BookNameToUpdate.Text + "'";
            thisCommand.Connection = sv.thisConnection;
            thisCommand.CommandType = CommandType.Text;
            try
            {
                thisCommand.ExecuteNonQuery();
                MessageBox.Show("Quantity Updated");
                //this.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            sv.thisConnection.Close();
            ManagerDashboard nxtForm = new ManagerDashboard();
            nxtForm.Show();
            this.Hide();
        }
    }
}
