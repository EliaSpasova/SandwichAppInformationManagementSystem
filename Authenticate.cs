using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandwichesDatabaseManagementProject
{
    public class Authenticate
    {
        public class User1
        {
            private static User1 instance;
            public int userID { get; set; }
            public string Username { get; set; }

            public string Email { get; set; }

            public string EmployeeOrCustomer { get; set; }
            public string Password { get; set; }
            private User1() { }
            public static User1 GetInstance()
            {
                if (instance == null)
                {
                    instance = new User1();
                }
                return instance;
            }
        }

        public class DatabaseManager
        {

                public static bool AuthenticateUser(string username, string password)
                {
                    // Attempt to retrieve user information and update the Singleton instance
                    bool isAuthenticated = RetrieveUserInformation(username, password);

                    return isAuthenticated;
                }

                private static bool RetrieveUserInformation(string username, string password)
                {
                    using (SqlConnection sqlCon = new SqlConnection(@"Data Source=ELIASPASOVA\SQLEXPRESS; Initial Catalog=sandwiches; Integrated Security=True;"))
                    {
                        sqlCon.Open();
                        string query = "SELECT * FROM userInfo WHERE Username = @username AND Password1 = @password";

                        using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                        {
                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.Parameters.AddWithValue("@password", password);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Get the Singleton instance of User1
                                    User1 user = User1.GetInstance();

                                    // Update its properties
                                    user.userID = (int)reader["userID"];
                                    user.Username = reader["Username"].ToString();
                                    user.Email = reader["Email"].ToString();
                                    user.EmployeeOrCustomer = reader["EmployeeOrCustomer"].ToString();
                                    user.Password = password; // Assuming you want to keep it, though it's generally not recommended

                                    return true; // Authentication successful
                                }
                            }
                        }
                    }

                    return false; // Authentication failed
                }
            }

        }
    }
   
