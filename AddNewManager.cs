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
    public partial class AddNewManager : Form
    {
        public AddNewManager()
        {
            InitializeComponent();
        }

        private void CancelNewManager_Click(object sender, EventArgs e)
        {
            AdminDashboard nxtform = new AdminDashboard();
            nxtform.Show();
            this.Hide();
        }

        private void ConfirmNewManager_Click(object sender, EventArgs e)
        {
            connection CN2 = new connection();
            CN2.thisConnection.Open();
            OracleDataAdapter thisAdapter = new OracleDataAdapter("SELECT * FROM userinfo", CN2.thisConnection);
            OracleCommandBuilder thisBuilder = new OracleCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "userinfo");
            DataRow thisRow = thisDataSet.Tables["userinfo"].NewRow();
            try
            {
                thisRow["id"] = NewManagerUsername.Text;
                thisRow["password"] = NewManagerPass.Text;
                thisDataSet.Tables["userinfo"].Rows.Add(thisRow);
                thisAdapter.Update(thisDataSet, "userinfo");
                MessageBox.Show("New Manager Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            CN2.thisConnection.Close();

            AdminDashboard nxtform = new AdminDashboard();
            nxtform.Show();
            this.Hide();
        }
    }
}
