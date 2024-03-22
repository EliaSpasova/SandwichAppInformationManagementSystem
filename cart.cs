using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SandwichesDatabaseManagementProject.Authenticate;

namespace SandwichesDatabaseManagementProject
{
    public partial class cart : Form
    {
        public User1 authenticatedUser;

        public cart(Authenticate.User1 user)
        {
            InitializeComponent();
            this.authenticatedUser = user;

            welcomeLabel.Text = $"Welcome, {authenticatedUser.Username}!";
            this.Shown += (sender, e) => LoadCartData();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu menu = new menu();
            menu.ShowDialog();
        }
        public void LoadCartData()
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=ELIASPASOVA\SQLEXPRESS; Initial Catalog=sandwiches; Integrated Security=True;"))
            {
                sqlCon.Open();
                var currentUser = Authenticate.User1.GetInstance();

                string query = "SELECT nameSandwich, amount, calculatedPrice FROM cart WHERE userID = @userID";
                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@userID", currentUser.userID);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    dataGridView1.DataSource = dt; // Assuming your DataGridView is named dataGridViewCart
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                    }
                }
            }
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            decimal totalSum = CalculateTotalSum();
            order orderForm = new order(totalSum);
            var dialogResult = orderForm.ShowDialog();

            if (dialogResult == DialogResult.OK || dialogResult == DialogResult.Cancel)
            {
                // Reload the cart data to reflect the emptied cart
                LoadCartData();
            }
        }
        private decimal CalculateTotalSum()
        {
            // Assuming your DataGridView is named dataGridView1 and has a column for calculatedPrice
            decimal totalSum = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                totalSum += Convert.ToDecimal(row.Cells["calculatedPrice"].Value);
            }
            return totalSum;
        }
    }
}
