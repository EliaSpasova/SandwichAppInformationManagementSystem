using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static SandwichesDatabaseManagementProject.Authenticate;

namespace SandwichesDatabaseManagementProject
{
    public partial class UpdateSandwichForm : Form
    {
        
        private string sandwichName;
        public User1 User1;
        public UpdateSandwichForm(string sandwichName, User1 user1)
        {
            InitializeComponent();
            this.sandwichName = sandwichName;
            LoadSandwichDetails(sandwichName);
            label1.Text = $"Update the properties of sandwich {sandwichName}";
            User1 = user1;
        }
        private void LoadSandwichDetails(string sandwichName)
        {
            // Here you'd fetch the sandwich details from the database using sandwichName
            // For demonstration, I'll just show setting up a command; you'd need to execute it and use the results
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=ELIASPASOVA\SQLEXPRESS; Initial Catalog=sandwiches; Integrated Security=True;"))
            {
                sqlCon.Open();
                string query = "SELECT * FROM sandwiches INNER JOIN sandwichInfo ON sandwiches.nameSandwich = sandwichInfo.nameSandwich WHERE sandwichInfo.nameSandwich = @nameSandwich";
                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@nameSandwich", sandwichName);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Assuming you have text boxes for each field:
                            meatBox.Text = reader["meat"].ToString();
                            cheeseComboBox.Text = reader["cheese"].ToString();
                            lettuceBox.Text = reader["lettuce"].ToString();
                            tomatoesBox.Text = reader["tomatoes"].ToString();
                            sauceBox.Text = reader["sauce"].ToString();
                            pricetextboc.Text = reader["price"].ToString();
                            amount.Text = reader["amount"].ToString();
                            caloriestextBox.Text = reader["calories"].ToString();
                            allergens.Text = reader["allergens"].ToString();
                        }
                    }
                }
            }
        }

        private void UpdateSandwichForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=ELIASPASOVA\SQLEXPRESS; Initial Catalog=sandwiches; Integrated Security=True;"))
            {
                sqlCon.Open();
                string query = @"UPDATE sandwiches SET meat = @meat, cheese = @cheese WHERE nameSandwich = @nameSandwich"; // Simplified for brevity
                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@meat", meatBox.Text); // Repeat for all parameters
                    cmd.Parameters.AddWithValue("@cheese", cheeseComboBox.Text);

                    cmd.Parameters.AddWithValue("@lettuce", lettuceBox.Text);
                    cmd.Parameters.AddWithValue("@tomatoes", tomatoesBox.Text);
                    cmd.Parameters.AddWithValue("@sauce", sauceBox.Text);
                    cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(pricetextboc.Text));
                    cmd.Parameters.AddWithValue("@nameSandwich", sandwichName);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void updateSandwich_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon1 = new SqlConnection(@"Data Source=ELIASPASOVA\SQLEXPRESS; Initial Catalog=sandwiches; Integrated Security=True;"))
            {
                sqlCon1.Open();
                SqlTransaction transaction = sqlCon1.BeginTransaction();

                try
                {
                    // Update 'sandwiches' table
                    string updateSandwiches = @"
            UPDATE sandwiches 
            SET meat = @meat, cheese = @cheese, lettuce = @lettuce, tomatoes = @tomatoes, sauce = @sauce, price = @price, amount = @amount 
            WHERE nameSandwich = @nameSandwich";

                    using (SqlCommand cmd = new SqlCommand(updateSandwiches, sqlCon1, transaction))
                    {
                        // Using SelectedItem.ToString() to get the string representation of the selected item in the combo boxes
                        cmd.Parameters.AddWithValue("@meat", meatBox.SelectedItem?.ToString() ?? string.Empty);
                        cmd.Parameters.AddWithValue("@cheese", cheeseComboBox.SelectedItem?.ToString() ?? string.Empty);
                        cmd.Parameters.AddWithValue("@lettuce", lettuceBox.SelectedItem?.ToString() ?? string.Empty);
                        cmd.Parameters.AddWithValue("@tomatoes", tomatoesBox.SelectedItem?.ToString() ?? string.Empty);
                        cmd.Parameters.AddWithValue("@sauce", sauceBox.SelectedItem?.ToString() ?? string.Empty);
                        // For numeric fields, ensure conversion from the Text property is handled correctly
                        cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(pricetextboc.Text));
                        cmd.Parameters.AddWithValue("@amount", Convert.ToInt32(amount.Text));
                        cmd.Parameters.AddWithValue("@nameSandwich", sandwichName);
                        cmd.ExecuteNonQuery();
                        cmd.ExecuteNonQuery();
                    }

                    // Update 'sandwichInfo' table
                    string updateSandwichInfo = @"
            UPDATE sandwichInfo 
            SET calories = @calories, allergens = @allergens
            WHERE nameSandwich = @nameSandwich";

                    using (SqlCommand cmd = new SqlCommand(updateSandwichInfo, sqlCon1, transaction))
                    {
                        cmd.Parameters.AddWithValue("@calories", caloriestextBox.Text);
                        cmd.Parameters.AddWithValue("@allergens", allergens.Text);
                        cmd.Parameters.AddWithValue("@nameSandwich", sandwichName);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Sandwich updated successfully!");
this.Hide();
                    AdminWindow admin = new AdminWindow(User1);
                    admin.ShowDialog();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
