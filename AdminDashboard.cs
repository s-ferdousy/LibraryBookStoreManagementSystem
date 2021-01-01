using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Book_Store_Management_System_3
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void addManager_Click(object sender, EventArgs e)
        {
            AddNewManager nxtForm = new AddNewManager();
            nxtForm.Show();
            this.Hide();
        }

        private void deleteManager_Click(object sender, EventArgs e)
        {
            RemoveAManager nxtForm = new RemoveAManager();
            nxtForm.Show();
            this.Hide();
        }

        private void AdminLogoutButton_Click(object sender, EventArgs e)
        {
            Form1 nxtForm = new Form1();
            nxtForm.Show();
            this.Hide();
        }
    }
}
