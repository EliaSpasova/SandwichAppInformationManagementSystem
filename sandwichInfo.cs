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
    public partial class sandwichInfo : Form
    {
        public sandwichInfo()
        {
            InitializeComponent();
            this.Load += new EventHandler(sandwichInfo_Load);
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            int updatedAmount = 1;
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=ELIASPASOVA\SQLEXPRESS; Initial Catalog=sandwiches; Integrated Security=True;"))
            {
                sqlCon.Open();
                var currentUser = Authenticate.User1.GetInstance();
                var currentSandwich = CurrentSandwichContext.CurrentSandwich;

                if (int.TryParse(AmountYouWant.Text, out int newAmount) && newAmount > 0)
                {
                    // First, check if the sandwich already exists in the user's cart
                    string checkQuery = "SELECT amount FROM cart WHERE userID = @userID AND nameSandwich = @nameSandwich";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, sqlCon);
                    checkCmd.Parameters.AddWithValue("@userID", currentUser.userID);
                    checkCmd.Parameters.AddWithValue("@nameSandwich", currentSandwich.Title);

                    object result = checkCmd.ExecuteScalar();
                    if (result != null)
                    {
                        // The sandwich is already in the cart; update its quantity
                        int existingAmount = Convert.ToInt32(result);
                        string updateQuery = "UPDATE cart SET amount = amount + @newAmount WHERE userID = @userID AND nameSandwich = @nameSandwich";
                        SqlCommand updateCmd = new SqlCommand(updateQuery, sqlCon);
                        updateCmd.Parameters.AddWithValue("@newAmount", newAmount);
                        updateCmd.Parameters.AddWithValue("@userID", currentUser.userID);
                        updateCmd.Parameters.AddWithValue("@nameSandwich", currentSandwich.Title);
                        updateCmd.ExecuteNonQuery();


                        string updateQueryPrice = "Update cart set calculatedPrice = amount * @priceOfSandwich";
                        SqlCommand updateCmdPrice = new SqlCommand(updateQueryPrice, sqlCon);
                        updateCmdPrice.Parameters.AddWithValue("@priceOfSandwich", currentSandwich.Price);
                        updateCmdPrice.ExecuteNonQuery();



                    }
                    else //if it's null
                    {

                        // The sandwich is not in the cart; insert a new row
                        string insertQuery = "INSERT INTO cart(nameSandwich, amount, calculatedPrice, userID) VALUES (@nameSandwich, @amount, @calculatedPrice, @userID)";
                        SqlCommand insertCmd = new SqlCommand(insertQuery, sqlCon);
                        insertCmd.Parameters.AddWithValue("@nameSandwich", currentSandwich.Title);
                        insertCmd.Parameters.AddWithValue("@amount", newAmount); //from textbox
                                                                                 //reader obj


                        insertCmd.Parameters.AddWithValue("@calculatedPrice", newAmount * currentSandwich.Price); //new amount because it's a new sandwich
                        insertCmd.Parameters.AddWithValue("@userID", currentUser.userID);
                        insertCmd.ExecuteNonQuery();

                    }

                    MessageBox.Show("Cart updated!");
                    // Refresh the cart form, if open
                    var cartForm = Application.OpenForms.OfType<cart>().FirstOrDefault();
                    cartForm?.LoadCartData();
                }
                else
                {
                    MessageBox.Show("Please enter a valid amount.");
                }

                //izvadi amountEl

            }
        }
        private void DisplayCurrentSandwich()
        {
            var currentSandwich = CurrentSandwichContext.CurrentSandwich;
            if (currentSandwich != null)
            {
                // Update the labels with the current sandwich details
                titleOfSandwichLabel.Text = currentSandwich.Title;
                caloriesOfSandwichLabel.Text = $"Calories: {currentSandwich.Calories}";
                allergensLabel.Text = $"Allergens: {currentSandwich.Allergens}";

                if (currentSandwich.Image != null)
                {
                    using (var ms = new MemoryStream(currentSandwich.Image))
                    {
                        pictureSandwich.Image = Image.FromStream(ms);
                    }
                }
            }
        }
        private void sandwichInfo_Load(object sender, EventArgs e)
        {

            if (CurrentSandwichContext.CurrentSandwich != null)
            {
                DisplayCurrentSandwich();
                // Example of updating form controls with the current sandwich details
                var currentSandwich = CurrentSandwichContext.CurrentSandwich;
                // Update your form controls like labels, images etc. here
                // e.g., sandwichNameLabel.Text = currentSandwich.Title;
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            User1 user = Authenticate.User1.GetInstance();
            cart cartForm = new cart(user);
            cartForm.Show();
        }

    }
}
