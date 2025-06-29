using Hotel.Models;
using Hotel.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Forms
{
    public partial class RoomList : Form
    {

        private readonly int newUserId;
        private bool _showingAc;
        public RoomList(int userId)
        {
            InitializeComponent();
             newUserId = userId;


            Ac.Click += (s, e) => ShowAc();
            NonAc.Click += (s, e) => ShowNonAc();

            // 1) Check‑in: show only date, but default time to 12:00 PM
            CheckIndateTimePicker.Format = DateTimePickerFormat.Custom;
            CheckIndateTimePicker.CustomFormat = "dd-MM-yyyy";
            CheckIndateTimePicker.MinDate = DateTime.Today;
            CheckIndateTimePicker.Value = DateTime.Today.AddHours(12);  // ← noon

            // 2) Check‑out: show date + time, default to tomorrow at 12:00 PM
            CheckOutdateTimePicker.Format = DateTimePickerFormat.Custom;
            CheckOutdateTimePicker.CustomFormat = "dd-MM-yyyy hh:mm tt";
            CheckOutdateTimePicker.Value = DateTime.Today.AddDays(1).AddHours(12);  // ← also noon

            // 3) Hook up clamp
            CheckIndateTimePicker.ValueChanged += CheckIndateTimePicker_ValueChanged;
            CheckIndateTimePicker_ValueChanged(this, EventArgs.Empty);

            CheckIndateTimePicker.ValueChanged += (s, e) => {
                CheckIndateTimePicker_ValueChanged(s, e);
                ReloadCurrent();
            };

            CheckOutdateTimePicker.ValueChanged += (s, e) => {
                ReloadCurrent();
            };


        }

        private void RoomList_Load(object sender, EventArgs e)
        {

            // start in Non‑AC mode:
            ShowNonAc();
        }


        private void ReloadCurrent()
        {
            if (_showingAc) ShowAc();
            else ShowNonAc();
        }



        private void ShowNonAc()
        {
            _showingAc = false;
            var ci = CheckIndateTimePicker.Value;
            var co = CheckOutdateTimePicker.Value;

            int nights = (int)(co.Date - ci.Date).TotalDays;

            var cart = new Cart
            {
                UserId = newUserId,
                Nights = nights,
                CheckIn = ci,
                CheckOut = co
            };
            var f = new NonAc(newUserId, cart);
            LoadFormInPanel(f);
        }

        private void ShowAc()
        {
            _showingAc = true;
            var ci = CheckIndateTimePicker.Value;
            var co = CheckOutdateTimePicker.Value;

            int nights = (int)(co.Date - ci.Date).TotalDays;

            var cart = new Cart
            {
                UserId = newUserId,
                Nights = nights,
                CheckIn = ci,
                CheckOut = co
            };
            var f = new AcRoom(newUserId, cart);
            LoadFormInPanel(f);
        }

        private void LoadFormInPanel(Form f)
        {
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(f);
            f.Show();
        }

        private void Ac_Click(object sender, EventArgs e)
        {

        }

        private void CheckIndateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // Never before today at 12 PM
            if (CheckIndateTimePicker.Value.Date < DateTime.Today)
                CheckIndateTimePicker.Value = DateTime.Today.AddHours(12);

            // Next-day check‑out at 12 PM
            var minOut = CheckIndateTimePicker.Value.Date
                          .AddDays(1)
                          .AddHours(12);

            if (CheckOutdateTimePicker.Value < minOut)
                CheckOutdateTimePicker.Value = minOut;

            CheckOutdateTimePicker.MinDate = CheckIndateTimePicker.Value.Date.AddDays(1);
        }

        private void CheckOutdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyUserProfilecs myprofile = new MyUserProfilecs(newUserId);
            myprofile.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
