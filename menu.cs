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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=ELIASPASOVA\SQLEXPRESS; Initial Catalog=sandwiches; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                string baseQuery = "SELECT * FROM sandwiches WHERE 1 = 1";
                List<string> conditions = new List<string>();

                // Assuming your first item in the ComboBox is "Select" or similar and represents an unselected state.
                if (Meat.SelectedIndex > 0)
                {
                    conditions.Add("meat = @meat");
                }

                if (Cheese.SelectedIndex > 0)
                {
                    conditions.Add("cheese = @cheese");
                }

                if (Lettuce.SelectedIndex > 0)
                {
                    conditions.Add("lettuce = @lettuce");
                }

                if (Tomatoes.SelectedIndex > 0)
                {
                    conditions.Add("tomatoes = @tomatoes");
                }

                if (Sauce.SelectedIndex > 0)
                {
                    conditions.Add("sauce = @sauce");
                }

                // Assuming Price is a special case where it represents a maximum value or similar
                if (Price.SelectedIndex > 0)
                {
                    conditions.Add("price <= @price");
                }

                // Append conditions to the base query if any
                if (conditions.Count > 0)
                {
                    baseQuery += " AND " + string.Join(" AND ", conditions);
                }

                SqlCommand cmd = new SqlCommand(baseQuery, sqlCon);

                // Only add parameters if the respective ComboBox is selected
                if (Meat.SelectedIndex > 0)
                {
                    cmd.Parameters.AddWithValue("@meat", Meat.SelectedItem.ToString());
                }

                if (Cheese.SelectedIndex > 0)
                {
                    cmd.Parameters.AddWithValue("@cheese", Cheese.SelectedItem.ToString());
                }

                // For Lettuce and Tomatoes, ensure their values are correctly mapped to "Yes" or "No"
                if (Lettuce.SelectedIndex > 0)
                {
                    cmd.Parameters.AddWithValue("@lettuce", Lettuce.SelectedItem.ToString());
                }

                if (Tomatoes.SelectedIndex > 0)
                {
                    cmd.Parameters.AddWithValue("@tomatoes", Tomatoes.SelectedItem.ToString());
                }

                if (Sauce.SelectedIndex > 0)
                {
                    cmd.Parameters.AddWithValue("@sauce", Sauce.SelectedItem.ToString());
                }

                // Adjust this part according to how you store or handle the price in the ComboBox
                if (Price.SelectedIndex > 0)
                {
                    cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(Price.SelectedItem.ToString()));
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                }
            }
        }

        private void menu_Load(object sender, EventArgs e)
        {
            Meat.SelectedIndex = 0;
            Cheese.SelectedIndex = 0;
            Lettuce.SelectedIndex = 0;
            Tomatoes.SelectedIndex = 0;
            Sauce.SelectedIndex = 0;
            Price.SelectedIndex = 0;
        }

        private void cleanFilter_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            Meat.SelectedIndex = 0;
            Cheese.SelectedIndex = 0;
            Lettuce.SelectedIndex = 0;
            Tomatoes.SelectedIndex = 0;
            Sauce.SelectedIndex = 0;
            Price.SelectedIndex = 0;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            User1 user = Authenticate.User1.GetInstance(); // Or however you get the user
            cart cartForm = new cart(user);
            cartForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensuring the click is on a valid row
            {
                // Assuming your DataGridView is set up to have the sandwich name in a specific column, adjust accordingly.
                if (dataGridView1.CurrentCell.ColumnIndex.Equals(0))
                {
                    SqlConnection sqlCon = new SqlConnection(@"Data Source=ELIASPASOVA\SQLEXPRESS; Initial Catalog=sandwiches; Integrated Security=True;");
                    sqlCon.Open();
                    var sandwich = DatabaseManagerForSandwich.cuurentSandwichMethod(dataGridView1.CurrentCell.Value.ToString());
                    CurrentSandwichContext.CurrentSandwich = sandwich;
                    if (sandwich != null)
                    {
                        // Display the username on Form5
                        sandwichInfo welcome = new sandwichInfo();
                        welcome.Show();
                        this.Hide();
                    }
                    sqlCon.Close();
                }
            }
        }


    }
}
