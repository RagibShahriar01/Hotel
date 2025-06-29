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
    public partial class AdminDashboard : Form
    {

        private int _adminId;

        private readonly DatabaseHelper db = new DatabaseHelper();
        public AdminDashboard(int adminId)
        {
            InitializeComponent();
            _adminId = adminId;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            dgv.DataSource = db.SearchByUsername(null);

            Loadbuy();
        }


        private void Loadbuy()
        {
            DataTable dt = db.GetBuy(/* all: no filter*/0);
            dgv.DataSource = dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm login = new LoginForm();
                login.Show();
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            dgv.DataSource = db.SearchByUsername(TxtSearch.Text.Trim());
        }
    }
}
