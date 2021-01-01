using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace Library_Book_Store_Management_System_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AdminVerification()
        {
            try
            {
                connection CN = new connection();
                CN.thisConnection.Open();
                OracleCommand thisCommand = new OracleCommand();
                thisCommand.Connection = CN.thisConnection;
                thisCommand.CommandText = "SELECT * From userinfo WHERE id='" + adminUsername.Text + "' AND password='" + admnPass.Text + "'";
                OracleDataReader thisReader = thisCommand.ExecuteReader();
                if (thisReader.Read())
                {
                    AdminDashboard nxtform = new AdminDashboard();
                    nxtform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("incorect password or username");
                }
                CN.thisConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ManagerVerification()
        {
            try
            {
                connection CN = new connection();
                CN.thisConnection.Open();
                OracleCommand thisCommand = new OracleCommand();
                thisCommand.Connection = CN.thisConnection;
                thisCommand.CommandText = "SELECT * From userinfo WHERE id='" + mngrUsername.Text + "' AND password='" + mngrPass.Text + "'";
                OracleDataReader thisReader = thisCommand.ExecuteReader();
                if (thisReader.Read())
                {
                    ManagerDashboard nxtform = new ManagerDashboard();
                    nxtform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("incorect password or username");
                }
                CN.thisConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AdminLogin_Click(object sender, EventArgs e)
        {
            AdminVerification();
        }

        private void ManagerLogin_Click(object sender, EventArgs e)
        {
            ManagerVerification();
        }
    }
}
