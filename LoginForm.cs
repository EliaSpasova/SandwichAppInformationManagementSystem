using static SandwichesDatabaseManagementProject.Authenticate;

namespace SandwichesDatabaseManagementProject
{
    public partial class loginForm : Form
    {

        public loginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string user = usernameText.Text;
            string pass = passwordTextbox.Text;
            if (!string.IsNullOrWhiteSpace(user) && !string.IsNullOrWhiteSpace(pass))
            {
                // AuthenticateUser now returns a bool
                bool isAuthenticated = DatabaseManager.AuthenticateUser(user, pass);

                if (isAuthenticated)
                {
                    // Directly get the singleton User1 instance
                    User1 authenticatedUser = User1.GetInstance();

                    // Assuming 'cart' form accepts a User1 instance in its constructor
                    if (authenticatedUser.EmployeeOrCustomer == "employee")
                    {
                        //admin form
                        //inserting new sandwich
                        AdminWindow win = new AdminWindow(authenticatedUser);
                        this.Hide();
                        win.ShowDialog();
                        //updating price etc etc
                    }
                    else if (authenticatedUser.EmployeeOrCustomer == "customer")
                    {
                        cart welcome = new cart(authenticatedUser);
                        welcome.Show();
                        this.Hide();
                    }


                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            else
            {
                MessageBox.Show("Please enter both username and password.");
            }
        }
    }
}