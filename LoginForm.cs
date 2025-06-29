using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.Database;
using Hotel.Forms;
using Hotel.Models;

namespace Hotel
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            passwordtext.UseSystemPasswordChar = true;

            DatabaseHelper hp = new DatabaseHelper();
            bool isConnected = hp.TestConnection();
            if (!isConnected)
            {

                loginbutton.Enabled = false;
                MessageBox.Show("Cannot connect to the database. Please check your connection settings.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin lo = new AdminLogin();
            lo.Show();
        }

        private void Registerationbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserRegistration ur = new UserRegistration();
            ur.Show();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string username = usernametext.Text.Trim();
            string password = passwordtext.Text;

            // Input Validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                DatabaseHelper db = new DatabaseHelper();


                User existingUser = db.GetUserByname(username);

                if (existingUser == null)
                {

                    MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (password == existingUser.Password)
                {
                    // Authentication successful
                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Redirect based on role
                    RedirectUser(existingUser.UserID);


                    // Optionally, close the Login Form
                    this.Hide();
                }
                else
                {
                    // Password does not match
                    MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Handle unexpected errors
                MessageBox.Show("An error occurred during login: " + ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void RedirectUser(int userId)
        {

            DatabaseHelper db3 = new DatabaseHelper();
            User user = db3.GetUserByID(userId);

            if (user != null)
            {

                RoomList room = new RoomList(user.UserID);
                room.Show();
            }
            else
            {
                MessageBox.Show("User profile not found. Please contact support.", "Profile Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void forgotbutton_Click(object sender, EventArgs e)
        {

            ResetPassword fp = new ResetPassword();
            fp.Show();
        }
    }
}
