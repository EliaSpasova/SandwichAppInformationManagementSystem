using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class UpdateSandwich : Form
    {
        public User1 authenticatedUser;
        public UpdateSandwich(User1 user)
        {
            InitializeComponent();

            this.authenticatedUser = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=ELIASPASOVA\SQLEXPRESS; Initial Catalog=sandwiches; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                string baseQuery = "SELECT * FROM sandwiches WHERE 1 = 1";
                SqlCommand cmd = new SqlCommand(baseQuery, sqlCon);
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView12.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                }

            }
        }

        private void dataGridView12_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView12.Rows[e.RowIndex];
                string selectedSandwichName = row.Cells["nameSandwich"].Value.ToString();

                UpdateSandwichForm updateForm = new UpdateSandwichForm(selectedSandwichName, authenticatedUser);
                this.Hide();
                updateForm.ShowDialog();

                // Optionally, refresh the DataGridView to show any updates
                // LoadSandwichesIntoDataGridView(); // You would implement this method to reload the DataGridView's data
            }
        }
    }
}
