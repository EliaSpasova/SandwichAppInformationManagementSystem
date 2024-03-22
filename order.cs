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

namespace SandwichesDatabaseManagementProject
{
    public partial class order : Form
    {
        private decimal totalBill;
        public order(decimal totalBill)
        {
            InitializeComponent();
            this.totalBill = totalBill;

            totalBillLabel.Text = $"Total Bill: ${totalBill}";
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string hereOrTakeaway = "";
            if ((hereOrTakeaway = hereOrTakeawayComboBox.SelectedItem.ToString()) == null)
            {
                MessageBox.Show("Please fill out whether your order is for here or takeaway!");
            }

            // Insert order into database
            InsertOrderIntoDatabase(hereOrTakeaway);

            MessageBox.Show("Order confirmed!");
            this.Close();


        }
        private void InsertOrderIntoDatabase(string hereOrTakeaway)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=ELIASPASOVA\SQLEXPRESS; Initial Catalog=sandwiches; Integrated Security=True;"))
            {
                sqlCon.Open();
                var currentUser = Authenticate.User1.GetInstance();

                // Start a transaction
                using (SqlTransaction transaction = sqlCon.BeginTransaction())
                {
                    try
                    {
                        // Insert the order into the orders table
                        string insertOrderQuery = "INSERT INTO orders (customerId, hereOrTakeaway, orderTimestamp, totalBill) VALUES (@customerId, @hereOrTakeaway, @orderTimestamp, @totalBill)";
                        using (SqlCommand insertOrderCmd = new SqlCommand(insertOrderQuery, sqlCon, transaction))
                        {
                            insertOrderCmd.Parameters.AddWithValue("@customerId", currentUser.userID);
                            insertOrderCmd.Parameters.AddWithValue("@hereOrTakeaway", hereOrTakeaway);
                            insertOrderCmd.Parameters.AddWithValue("@orderTimestamp", DateTime.Now);
                            insertOrderCmd.Parameters.AddWithValue("@totalBill", totalBill);
                            insertOrderCmd.ExecuteNonQuery();
                        }

                        // Empty the user's cart
                        string emptyCartQuery = "DELETE FROM cart WHERE userID = @userID";
                        using (SqlCommand emptyCartCmd = new SqlCommand(emptyCartQuery, sqlCon, transaction))
                        {
                            emptyCartCmd.Parameters.AddWithValue("@userID", currentUser.userID);
                            emptyCartCmd.ExecuteNonQuery();
                        }

                        // Commit the transaction
                        transaction.Commit();
                        MessageBox.Show("Order confirmed and cart emptied!");
                    }
                    catch (Exception ex)
                    {
                        // Attempt to roll back the transaction
                        try
                        {
                            transaction.Rollback();
                        }
                        catch (Exception exRollback)
                        {
                            // Handle any errors that occur during the rollback
                            MessageBox.Show("Rollback Exception Type: " + exRollback.GetType());
                            MessageBox.Show("Message: " + exRollback.Message);
                        }
                        MessageBox.Show("Exception Type: " + ex.GetType());
                        MessageBox.Show("Message: " + ex.Message);
                    }
                }
            }
        }
    }
}
