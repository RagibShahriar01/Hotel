using Hotel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.Database;
using Hotel.Forms;

namespace Hotel.Forms
{
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
        }

        private void UserRegistration_Load(object sender, EventArgs e)
        {

        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            string username = usernametext.Text.Trim();
            string password = passwordBox.Text;
            string confirmPassword = confirmtext.Text;
            string email = emailtext.Text.Trim();
            string address = Addresstext.Text.Trim();
            string mobile = mobiletext.Text.Trim();



            // Input Validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(mobile))
            {
                MessageBox.Show("Please fill in all required fields.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Initialize DatabaseQ
            DatabaseHelper db = new DatabaseHelper();

            // **NEW**: Check for existing username
            if (db.GetUserByname(username) != null)
            {
                MessageBox.Show($"The username '{username}' is already taken. Please choose another.",
                                "Registration Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }


            try
            {

                // Create User Object
                User newUser = new User
                {
                    Username = username,
                    Password = password,
                    Email = email,
                    Address = address,
                    Mobile = mobile

                };



                // Insert User and Get New UserID
                int newUserId = db.UserC(newUser);

                // Insert into tblUserProfile for the new user


                UserProfile newProfile = new UserProfile
                {
                    UserID = newUserId,
                    Username = username, // Default to username or empty
                    Email = email,
                    Address = address,
                    Mobile = mobile,
                };
                db.UserProfileC(newProfile);


                MessageBox.Show("Registration Successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Navigate back to Login Form
                this.Hide();
                LoginForm lo = new LoginForm();
                lo.Show();
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 2627) // Unique constraint violation
                {
                    MessageBox.Show("Username or Email already exists. Please choose another.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("An error occurred during registration: " + sqlEx.Message, "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
