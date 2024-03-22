using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;
using static SandwichesDatabaseManagementProject.Authenticate;

namespace SandwichesDatabaseManagementProject
{
    public partial class InsertANewSandwich : Form
    {
        public User1 AuthenticatedUser;
        public InsertANewSandwich(User1 user)
        {
            InitializeComponent();
            this.AuthenticatedUser = user;
        }

        private void nameOfSandwichTextBox_TextChanged(object sender, EventArgs e)
        {
            //that is for the dynamic updates
            capitalLetterLabel.Show();
            noSpecialCharacters.Show();
            if (nameOfSandwichTextBox.Text == string.Empty)
            {
                capitalLetterLabel.ForeColor = Color.Red;
                noSpecialCharacters.ForeColor = Color.Red;

            }
            else
            {


                if (char.IsUpper(nameOfSandwichTextBox.Text[0]))
                {
                    capitalLetterLabel.ForeColor = Color.Green;
                }
                else
                {
                    capitalLetterLabel.ForeColor = Color.Red;
                }

                if (HasSpecialChars(nameOfSandwichTextBox.Text))
                {
                    noSpecialCharacters.ForeColor = Color.Red;
                }
                else
                {
                    noSpecialCharacters.ForeColor = Color.Green;
                }
            }


        }
        private bool HasSpecialChars(string yourString)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,1234567890";
            foreach (var item in specialChar)
            {
                if (yourString.Contains(item)) return true;
            }

            return false;
        }

        private void nameOfSandwichTextBox_Validated(object sender, EventArgs e)
        {
            if ((capitalLetterLabel.ForeColor == Color.Green) && (noSpecialCharacters.ForeColor == Color.Green))
            {
                capitalLetterLabel.Hide();
                noSpecialCharacters.Hide();

            }
            else
            {
                MessageBox.Show("title is not valid", "error", MessageBoxButtons.OK);
            }

        }

        private void InsertANewSandwich_Load(object sender, EventArgs e)//ne
        {
            meatBox.SelectedIndex = 0;
            cheeseComboBox.SelectedIndex = 0;
            lettuceBox.SelectedIndex = 0;
            tomatoesBox.SelectedIndex = 0;
            sauceBox.SelectedIndex = 0;
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(meatBox.Text) ||
              string.IsNullOrWhiteSpace(cheeseComboBox.Text) ||
              string.IsNullOrWhiteSpace(lettuceBox.Text) ||
                    string.IsNullOrWhiteSpace(tomatoesBox.Text) ||
                string.IsNullOrWhiteSpace(sauceBox.Text) ||
                string.IsNullOrWhiteSpace(pricetextboc.Text) || meatBox.SelectedIndex == 0 || cheeseComboBox.SelectedIndex == 0 || lettuceBox.SelectedIndex == 0 || tomatoesBox.SelectedIndex == 0 || sauceBox.SelectedIndex == 0)
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=ELIASPASOVA\SQLEXPRESS; Initial Catalog=sandwiches; Integrated Security=True;"))
                {
                    sqlCon.Open();
                    string sandwichesInsertQuery = @"
                INSERT INTO sandwiches 
                (nameSandwich, meat, cheese, lettuce, tomatoes, sauce, price, amount) 
                VALUES 
                (@nameSandwich, @meat, @cheese, @lettuce, @tomatoes, @sauce, @price, @amount)";

                    string sandwichInfoInsertQuery = @"
                INSERT INTO sandwichInfo 
                (nameSandwich, calories, allergens, imageSandwich) 
                VALUES 
                (@nameSandwich, @calories, @allergens, @imageSandwich)";

                    using (SqlTransaction transaction = sqlCon.BeginTransaction())
                    {
                        // Insert into sandwiches table
                        using (SqlCommand cmdSandwiches = new SqlCommand(sandwichesInsertQuery, sqlCon, transaction))
                        {
                            cmdSandwiches.Parameters.AddWithValue("@nameSandwich", nameOfSandwichTextBox.Text);
                            cmdSandwiches.Parameters.AddWithValue("@meat", meatBox.Text);
                            cmdSandwiches.Parameters.AddWithValue("@cheese", cheeseComboBox.Text);
                            cmdSandwiches.Parameters.AddWithValue("@lettuce", lettuceBox.Text);
                            cmdSandwiches.Parameters.AddWithValue("@tomatoes", tomatoesBox.Text);
                            cmdSandwiches.Parameters.AddWithValue("@sauce", sauceBox.Text);
                            cmdSandwiches.Parameters.AddWithValue("@price", decimal.Parse(pricetextboc.Text)); //try for decimal and amount!!!! AND ALSO COMBO BOXES DON'T GIVE INXED 0
                            cmdSandwiches.Parameters.AddWithValue("@amount", int.Parse(amount.Text));

                            cmdSandwiches.ExecuteNonQuery();
                        }

                        // Insert into sandwichInfo table
                        using (SqlCommand cmdSandwichInfo = new SqlCommand(sandwichInfoInsertQuery, sqlCon, transaction))
                        {
                            cmdSandwichInfo.Parameters.AddWithValue("@nameSandwich", nameOfSandwichTextBox.Text);
                            cmdSandwichInfo.Parameters.AddWithValue("@calories", caloriestextBox.Text);
                            cmdSandwichInfo.Parameters.AddWithValue("@allergens", allergens.Text);
                            byte[] imageBytes = ConvertImageToBytes(pictureBox1.Image);
                            cmdSandwichInfo.Parameters.AddWithValue("@imageSandwich", imageBytes);
                            cmdSandwichInfo.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Sandwich and its details added successfully!");
                        this.Hide();
                        AdminWindow admin = new AdminWindow(AuthenticatedUser);
                        admin.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = ofd.FileName;
                System.Drawing.Image selectedImage = System.Drawing.Image.FromFile(selectedImagePath);
                pictureBox1.Image = selectedImage;
            }
        }
        private byte[] ConvertImageToBytes(System.Drawing.Image img)
        {
            using (var stream = new System.IO.MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }

        private void cheeseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
