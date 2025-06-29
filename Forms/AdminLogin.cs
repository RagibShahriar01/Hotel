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

namespace Hotel.Forms
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
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

        private void Registerationbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminRegistration reg = new AdminRegistration();
            reg.Show();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string adminname = usernametext.Text.Trim();
            string password = passwordtext.Text;

            // Input Validation
            if (string.IsNullOrEmpty(adminname) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                DatabaseHelper db = new DatabaseHelper();


                GetAdmin existingAdmin = db.GetAdminByName(adminname);

                if (existingAdmin == null)
                {

                    MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (password == existingAdmin.Password)
                {
                    // Authentication successful
                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Redirect based on role
                    RedirectAdmin(existingAdmin.AdminID);


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




        private void RedirectAdmin(int adminId)
        {

            DatabaseHelper db3 = new DatabaseHelper();
            GetAdmin admin = db3.GetAdminByID(adminId);

            if (admin != null)
            {

                AdminDashboard a1 = new AdminDashboard(admin.AdminID);
                a1.Show();
            }
            else
            {
                MessageBox.Show("Admin profile not found. Please contact support.", "Profile Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lo2 = new LoginForm();
            lo2.Show();
        }
    }
}
