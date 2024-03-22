using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SandwichesDatabaseManagementProject.Authenticate;

namespace SandwichesDatabaseManagementProject
{
    public partial class AdminWindow : Form
    {
        public User1 authenticatedUser;
        public AdminWindow(Authenticate.User1 user)
        {
            InitializeComponent();
            this.authenticatedUser = user;

            welcomeLabel.Text = $"Welcome, {authenticatedUser.Username}!";
        }

        private void insertANewItemButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertANewSandwich insert = new InsertANewSandwich(authenticatedUser);
            insert.ShowDialog();
        }

        private void updateASandwich_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateSandwich update = new UpdateSandwich(authenticatedUser);
            update.ShowDialog();

        }

        private void allOrdersButton_Click(object sender, EventArgs e)
        {
            AllOrders newPage = new AllOrders();
            newPage.ShowDialog();
        }
    }
}
